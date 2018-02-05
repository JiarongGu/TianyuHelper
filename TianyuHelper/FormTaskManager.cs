using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TianyuHelper.Module;

namespace TianyuHelper
{
    public partial class FormTaskManager : Form
    {
        public FormTaskManager()
        {
            InitializeComponent();
        }

        private void FormTaskManager_Load(object sender, EventArgs e)
        {
            Process[] myProcs = Process.GetProcesses();
            foreach (Process p in myProcs)
            {
                if (p.ProcessName.Contains("tianyu"))
                {
                    string title = p.MainWindowTitle;
                    if (title.Contains("天谕"))
                    {
                        int index = title.IndexOf("[") + 1;
                        if( index > 0)
                        {
                            ListViewItem task = new ListViewItem(p.Id.ToString());
                            task.SubItems.Add(p.ProcessName);
                        
                            task.SubItems.Add(title.Substring(index, title.IndexOf("]") - index));
                            //task.Tag = p;
                            listViewTasks.Items.Add(task);
                            task.Tag = title;
                        }
                    }
                }
            }
        }

        private void listViewTasks_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem task = listViewTasks.SelectedItems[0];
            Program.main.setProcess(new MemoryProcess(int.Parse(task.Text), task.SubItems[2].Text, task.Tag.ToString()));
            this.Close();
        }
    }
}
