using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TianyuHelper.Module;
using TianyuHelper.Handler;

namespace TianyuHelper
{
    public partial class FormHelper : Form
    {

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        
        private IntPtr thisWindow;
        private Core tianyuCore = new Core();
        delegate void SetTextCallback(TaskEventArgs e);

        public FormHelper()
        {
            InitializeComponent();
        }
        private void FormHelper_Load(object sender, EventArgs e)
        {
            thisWindow = FindWindow(null, "Helper");
            RegisterHotKey(thisWindow, 1, 0x0002, (uint)Keys.T);
            RegisterHotKey(thisWindow, 2, 0x0002, (uint)Keys.Y);

            btnProcess_Click(this, null);

            foreach (string scriptName in tianyuCore.getFileScripts())
            {
                cBoxQuestList.Items.Add(scriptName);
            }
        }

        public void runTimeHandler_scriptEventHandler(object sender, TaskEventArgs e)
        {
            SetTextCallback callback = new SetTextCallback(updateRunTimeInterface);
            this.Invoke (callback, e);
        }

        private void updateRunTimeInterface(TaskEventArgs e)
        {
            switch (e.type)
            {
                case (int)TypeEnum.action:
                    int index = listBoxRTQuest.Items.Add(e.currentAction);
                    listBoxRTQuest.SelectedIndex = index;
                    labSelectedQuestName.Text = e.currentScript;
                    break;

                case (int)TypeEnum.script:
                    if (e.isComplete) { listBoxRTQuest.Items.Clear(); }
                    labCompleteTime.Text = e.counter.ToString();
                    break;
            }
        }

        public void setProcess(MemoryProcess process)
        {
            tianyuCore.initalize(process);
            Text = tianyuCore.process.taskDetail;
            tmrCore.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Coordinate: " + 
            tianyuCore.process.getCoordinate().toRealString());
        }

        private void tmrCore_Tick(object sender, EventArgs e)
        {
            labMapCo.Text = tianyuCore.getCoordinate();
        }

        private void FormHelper_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(thisWindow, 1);
        }

        protected override void WndProc(ref Message keyPressed)
        {
            base.WndProc(ref keyPressed);

            if (keyPressed.Msg == 0x0312)
            {
                int id = keyPressed.WParam.ToInt32();
                switch (id)
                {
                    case 1:
                        runScripts();
                        tianyuCore.runTimeHandler.scriptEventHandler += runTimeHandler_scriptEventHandler;
                        break;
                    case 2:
                        tianyuCore.stopTest();
                        //tmrKeyEvent.Enabled = false;
                        labRTEvent.Text = "未开始";
                        labSelectedQuestName.Text = "(无)";
                        tianyuCore.runTimeHandler.scriptEventHandler -= runTimeHandler_scriptEventHandler;
                        break;
                }
            }
        }


        private void runScripts()
        {
            tianyuCore.initalizeRunTime(dateTimePickerStartTime.Value,dateTimePickerEndTime.Value,
                dateTimePickerRunTime.Value, dateTimePickerListDelay.Value, Convert.ToInt32(numTxtLoopAmount.Value), 
                checkBoxStartTime.Checked, checkBoxEndTime.Checked);
            tianyuCore.sendTest();
            labRTEvent.Text = "进行中";
            //tmrKeyEvent.Enabled = true;
        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            int val = Int32.Parse(txtCalI.Text);
            txtCalR.Text = (1.14 * val - Math.Pow(val, 1.5) * 0.03 - Math.Pow(val, 2) * 0.0005).ToString();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            FormTaskManager frm = new FormTaskManager();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Location.X + 25, this.Location.Y + 25);
            frm.ShowDialog();
            this.TopMost = checkBoxFormTopUp.Checked;
        }

        private void cBoxQuestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Index: " + cBoxQuestList.SelectedIndex + " Script: " + cBoxQuestList.SelectedItem);
            listViewFileText.Items.Clear();
            tianyuCore.clearQuest();
            foreach (ActionEvent actionEvent in tianyuCore.readScript(cBoxQuestList.SelectedIndex, cBoxQuestList.SelectedItem.ToString()))
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = actionEvent.getActionName();
                viewItem.SubItems.Add(actionEvent.value);
                viewItem.SubItems.Add(actionEvent.tag);
                listViewFileText.Items.Add(viewItem);
            }
            
        }

        private void btnQuestToRunList_Click(object sender, EventArgs e)
        {
            tianyuCore.addScriptToRun();
            listBoxScripts.Items.Clear();
            foreach (ScriptHandler script in tianyuCore.runTimeHandler.scripts)
            {
                listBoxScripts.Items.Add(script.scriptName);
            }
        }

        private void checkBoxFormTopUp_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxFormTopUp.Checked;
        }
    }
}
