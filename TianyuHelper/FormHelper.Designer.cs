namespace TianyuHelper
{
    partial class FormHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMapCo = new System.Windows.Forms.Panel();
            this.labMapCoInfo = new System.Windows.Forms.Label();
            this.labMapCo = new System.Windows.Forms.Label();
            this.tmrCore = new System.Windows.Forms.Timer(this.components);
            this.tmrKeyEvent = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labCompleteTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimeSetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEndTime = new System.Windows.Forms.CheckBox();
            this.checkBoxStartTime = new System.Windows.Forms.CheckBox();
            this.dateTimePickerListDelay = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.listBoxScripts = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numTxtLoopAmount = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerRunTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFormTopUp = new System.Windows.Forms.CheckBox();
            this.labSeparatorLine2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSeparatorLine1 = new System.Windows.Forms.Label();
            this.labSelectedQuestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labRTEvent = new System.Windows.Forms.Label();
            this.listBoxRTQuest = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.btnQuestAddEvent = new System.Windows.Forms.Button();
            this.btnQuestToRunList = new System.Windows.Forms.Button();
            this.btnQuestDeleteEvent = new System.Windows.Forms.Button();
            this.btnQuestSave = new System.Windows.Forms.Button();
            this.btnQuestNew = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewFileText = new System.Windows.Forms.ListView();
            this.listFTEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listFTEventValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listFTEventTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxQuestList = new System.Windows.Forms.ComboBox();
            this.tabPageMake = new System.Windows.Forms.TabPage();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.txtCalI = new System.Windows.Forms.TextBox();
            this.txtCalR = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelMapCo.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtLoopAmount)).BeginInit();
            this.tabPageScript.SuspendLayout();
            this.tabPageSetup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMapCo
            // 
            this.panelMapCo.BackColor = System.Drawing.Color.Transparent;
            this.panelMapCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMapCo.Controls.Add(this.labMapCoInfo);
            this.panelMapCo.Controls.Add(this.labMapCo);
            this.panelMapCo.Location = new System.Drawing.Point(256, 0);
            this.panelMapCo.Name = "panelMapCo";
            this.panelMapCo.Size = new System.Drawing.Size(160, 25);
            this.panelMapCo.TabIndex = 2;
            this.panelMapCo.TabStop = true;
            // 
            // labMapCoInfo
            // 
            this.labMapCoInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labMapCoInfo.Location = new System.Drawing.Point(0, 0);
            this.labMapCoInfo.Name = "labMapCoInfo";
            this.labMapCoInfo.Size = new System.Drawing.Size(42, 25);
            this.labMapCoInfo.TabIndex = 1;
            this.labMapCoInfo.Text = "坐标: ";
            this.labMapCoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMapCo
            // 
            this.labMapCo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labMapCo.Location = new System.Drawing.Point(40, 0);
            this.labMapCo.Name = "labMapCo";
            this.labMapCo.Size = new System.Drawing.Size(120, 25);
            this.labMapCo.TabIndex = 0;
            this.labMapCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCore
            // 
            this.tmrCore.Interval = 200;
            this.tmrCore.Tick += new System.EventHandler(this.tmrCore_Tick);
            // 
            // tmrKeyEvent
            // 
            this.tmrKeyEvent.Interval = 200;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageInfo);
            this.tabMain.Controls.Add(this.tabPageScript);
            this.tabMain.Controls.Add(this.tabPageMake);
            this.tabMain.Controls.Add(this.tabPageSetup);
            this.tabMain.Controls.Add(this.tabPageTest);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(426, 275);
            this.tabMain.TabIndex = 3;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.button2);
            this.tabPageInfo.Controls.Add(this.label9);
            this.tabPageInfo.Controls.Add(this.labCompleteTime);
            this.tabPageInfo.Controls.Add(this.label7);
            this.tabPageInfo.Controls.Add(this.btnTimeSetting);
            this.tabPageInfo.Controls.Add(this.panel1);
            this.tabPageInfo.Controls.Add(this.labRTEvent);
            this.tabPageInfo.Controls.Add(this.listBoxRTQuest);
            this.tabPageInfo.Controls.Add(this.btnProcess);
            this.tabPageInfo.Controls.Add(this.panelMapCo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(418, 249);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = " 信息";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "保存设置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(256, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 1);
            this.label9.TabIndex = 11;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labCompleteTime
            // 
            this.labCompleteTime.AutoSize = true;
            this.labCompleteTime.Font = new System.Drawing.Font("SimSun", 9F);
            this.labCompleteTime.Location = new System.Drawing.Point(393, 33);
            this.labCompleteTime.Name = "labCompleteTime";
            this.labCompleteTime.Size = new System.Drawing.Size(11, 12);
            this.labCompleteTime.TabIndex = 10;
            this.labCompleteTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "完成次数";
            // 
            // btnTimeSetting
            // 
            this.btnTimeSetting.Location = new System.Drawing.Point(94, 222);
            this.btnTimeSetting.Name = "btnTimeSetting";
            this.btnTimeSetting.Size = new System.Drawing.Size(67, 23);
            this.btnTimeSetting.TabIndex = 8;
            this.btnTimeSetting.Text = "时间设置";
            this.btnTimeSetting.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxEndTime);
            this.panel1.Controls.Add(this.checkBoxStartTime);
            this.panel1.Controls.Add(this.dateTimePickerListDelay);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.listBoxScripts);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numTxtLoopAmount);
            this.panel1.Controls.Add(this.dateTimePickerRunTime);
            this.panel1.Controls.Add(this.dateTimePickerEndTime);
            this.panel1.Controls.Add(this.dateTimePickerStartTime);
            this.panel1.Controls.Add(this.checkBoxFormTopUp);
            this.panel1.Controls.Add(this.labSeparatorLine2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labSeparatorLine1);
            this.panel1.Controls.Add(this.labSelectedQuestName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 219);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "循环持续";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "列表间隔";
            // 
            // checkBoxEndTime
            // 
            this.checkBoxEndTime.AutoSize = true;
            this.checkBoxEndTime.Location = new System.Drawing.Point(5, 66);
            this.checkBoxEndTime.Name = "checkBoxEndTime";
            this.checkBoxEndTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxEndTime.TabIndex = 23;
            this.checkBoxEndTime.Text = "结束时间";
            this.checkBoxEndTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartTime
            // 
            this.checkBoxStartTime.AutoSize = true;
            this.checkBoxStartTime.Location = new System.Drawing.Point(5, 36);
            this.checkBoxStartTime.Name = "checkBoxStartTime";
            this.checkBoxStartTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxStartTime.TabIndex = 22;
            this.checkBoxStartTime.Text = "开始时间";
            this.checkBoxStartTime.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerListDelay
            // 
            this.dateTimePickerListDelay.CustomFormat = "HH:mm";
            this.dateTimePickerListDelay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerListDelay.Location = new System.Drawing.Point(77, 122);
            this.dateTimePickerListDelay.Name = "dateTimePickerListDelay";
            this.dateTimePickerListDelay.ShowUpDown = true;
            this.dateTimePickerListDelay.Size = new System.Drawing.Size(57, 21);
            this.dateTimePickerListDelay.TabIndex = 20;
            this.dateTimePickerListDelay.Value = new System.DateTime(2016, 2, 17, 1, 15, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "脚本列表";
            // 
            // listBoxScripts
            // 
            this.listBoxScripts.FormattingEnabled = true;
            this.listBoxScripts.ItemHeight = 12;
            this.listBoxScripts.Location = new System.Drawing.Point(140, 42);
            this.listBoxScripts.Name = "listBoxScripts";
            this.listBoxScripts.Size = new System.Drawing.Size(110, 64);
            this.listBoxScripts.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(2, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 1);
            this.label10.TabIndex = 16;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numTxtLoopAmount
            // 
            this.numTxtLoopAmount.Location = new System.Drawing.Point(77, 152);
            this.numTxtLoopAmount.Name = "numTxtLoopAmount";
            this.numTxtLoopAmount.Size = new System.Drawing.Size(57, 21);
            this.numTxtLoopAmount.TabIndex = 15;
            this.numTxtLoopAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerRunTime
            // 
            this.dateTimePickerRunTime.CustomFormat = "HH:mm";
            this.dateTimePickerRunTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRunTime.Location = new System.Drawing.Point(77, 92);
            this.dateTimePickerRunTime.Name = "dateTimePickerRunTime";
            this.dateTimePickerRunTime.ShowUpDown = true;
            this.dateTimePickerRunTime.Size = new System.Drawing.Size(57, 21);
            this.dateTimePickerRunTime.TabIndex = 13;
            this.dateTimePickerRunTime.Value = new System.DateTime(2016, 2, 19, 0, 45, 0, 0);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "HH:mm";
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(77, 62);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(57, 21);
            this.dateTimePickerEndTime.TabIndex = 12;
            this.dateTimePickerEndTime.Value = new System.DateTime(2016, 2, 17, 12, 0, 0, 0);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "HH:mm";
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(77, 32);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(57, 21);
            this.dateTimePickerStartTime.TabIndex = 11;
            this.dateTimePickerStartTime.Value = new System.DateTime(2016, 2, 20, 1, 5, 0, 0);
            // 
            // checkBoxFormTopUp
            // 
            this.checkBoxFormTopUp.AutoSize = true;
            this.checkBoxFormTopUp.Location = new System.Drawing.Point(10, 193);
            this.checkBoxFormTopUp.Name = "checkBoxFormTopUp";
            this.checkBoxFormTopUp.Size = new System.Drawing.Size(72, 16);
            this.checkBoxFormTopUp.TabIndex = 10;
            this.checkBoxFormTopUp.Text = "窗口置顶";
            this.checkBoxFormTopUp.UseVisualStyleBackColor = true;
            this.checkBoxFormTopUp.CheckedChanged += new System.EventHandler(this.checkBoxFormTopUp_CheckedChanged);
            // 
            // labSeparatorLine2
            // 
            this.labSeparatorLine2.BackColor = System.Drawing.SystemColors.Control;
            this.labSeparatorLine2.ForeColor = System.Drawing.SystemColors.Control;
            this.labSeparatorLine2.Location = new System.Drawing.Point(2, 183);
            this.labSeparatorLine2.Name = "labSeparatorLine2";
            this.labSeparatorLine2.Size = new System.Drawing.Size(250, 1);
            this.labSeparatorLine2.TabIndex = 9;
            this.labSeparatorLine2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "循环次数";
            // 
            // labSeparatorLine1
            // 
            this.labSeparatorLine1.BackColor = System.Drawing.SystemColors.Control;
            this.labSeparatorLine1.ForeColor = System.Drawing.SystemColors.Control;
            this.labSeparatorLine1.Location = new System.Drawing.Point(1, 24);
            this.labSeparatorLine1.Name = "labSeparatorLine1";
            this.labSeparatorLine1.Size = new System.Drawing.Size(250, 1);
            this.labSeparatorLine1.TabIndex = 2;
            this.labSeparatorLine1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labSelectedQuestName
            // 
            this.labSelectedQuestName.BackColor = System.Drawing.Color.Transparent;
            this.labSelectedQuestName.Location = new System.Drawing.Point(72, 1);
            this.labSelectedQuestName.Name = "labSelectedQuestName";
            this.labSelectedQuestName.Size = new System.Drawing.Size(178, 24);
            this.labSelectedQuestName.TabIndex = 1;
            this.labSelectedQuestName.Text = "(无)";
            this.labSelectedQuestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "当前脚本:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRTEvent
            // 
            this.labRTEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labRTEvent.Location = new System.Drawing.Point(256, 29);
            this.labRTEvent.Name = "labRTEvent";
            this.labRTEvent.Size = new System.Drawing.Size(68, 20);
            this.labRTEvent.TabIndex = 5;
            this.labRTEvent.Text = "未开始";
            this.labRTEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRTQuest
            // 
            this.listBoxRTQuest.FormattingEnabled = true;
            this.listBoxRTQuest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxRTQuest.ItemHeight = 12;
            this.listBoxRTQuest.Location = new System.Drawing.Point(256, 48);
            this.listBoxRTQuest.Name = "listBoxRTQuest";
            this.listBoxRTQuest.Size = new System.Drawing.Size(160, 196);
            this.listBoxRTQuest.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(2, 222);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(67, 23);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "选择进程";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.btnQuestAddEvent);
            this.tabPageScript.Controls.Add(this.btnQuestToRunList);
            this.tabPageScript.Controls.Add(this.btnQuestDeleteEvent);
            this.tabPageScript.Controls.Add(this.btnQuestSave);
            this.tabPageScript.Controls.Add(this.btnQuestNew);
            this.tabPageScript.Controls.Add(this.flowLayoutPanel1);
            this.tabPageScript.Controls.Add(this.listViewFileText);
            this.tabPageScript.Controls.Add(this.label1);
            this.tabPageScript.Controls.Add(this.cBoxQuestList);
            this.tabPageScript.Location = new System.Drawing.Point(4, 22);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScript.Size = new System.Drawing.Size(418, 249);
            this.tabPageScript.TabIndex = 1;
            this.tabPageScript.Text = "脚本";
            this.tabPageScript.UseVisualStyleBackColor = true;
            // 
            // btnQuestAddEvent
            // 
            this.btnQuestAddEvent.Location = new System.Drawing.Point(367, 94);
            this.btnQuestAddEvent.Name = "btnQuestAddEvent";
            this.btnQuestAddEvent.Size = new System.Drawing.Size(49, 23);
            this.btnQuestAddEvent.TabIndex = 8;
            this.btnQuestAddEvent.Text = "添加";
            this.btnQuestAddEvent.UseVisualStyleBackColor = true;
            // 
            // btnQuestToRunList
            // 
            this.btnQuestToRunList.Location = new System.Drawing.Point(367, 222);
            this.btnQuestToRunList.Name = "btnQuestToRunList";
            this.btnQuestToRunList.Size = new System.Drawing.Size(48, 23);
            this.btnQuestToRunList.TabIndex = 7;
            this.btnQuestToRunList.Text = "加入";
            this.btnQuestToRunList.UseVisualStyleBackColor = true;
            this.btnQuestToRunList.Click += new System.EventHandler(this.btnQuestToRunList_Click);
            // 
            // btnQuestDeleteEvent
            // 
            this.btnQuestDeleteEvent.Location = new System.Drawing.Point(367, 123);
            this.btnQuestDeleteEvent.Name = "btnQuestDeleteEvent";
            this.btnQuestDeleteEvent.Size = new System.Drawing.Size(49, 23);
            this.btnQuestDeleteEvent.TabIndex = 6;
            this.btnQuestDeleteEvent.Text = "删除";
            this.btnQuestDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // btnQuestSave
            // 
            this.btnQuestSave.Location = new System.Drawing.Point(367, 35);
            this.btnQuestSave.Name = "btnQuestSave";
            this.btnQuestSave.Size = new System.Drawing.Size(49, 23);
            this.btnQuestSave.TabIndex = 5;
            this.btnQuestSave.Text = "保存";
            this.btnQuestSave.UseVisualStyleBackColor = true;
            // 
            // btnQuestNew
            // 
            this.btnQuestNew.Location = new System.Drawing.Point(367, 6);
            this.btnQuestNew.Name = "btnQuestNew";
            this.btnQuestNew.Size = new System.Drawing.Size(49, 23);
            this.btnQuestNew.TabIndex = 4;
            this.btnQuestNew.Text = "新建";
            this.btnQuestNew.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 214);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // listViewFileText
            // 
            this.listViewFileText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listFTEventName,
            this.listFTEventValue,
            this.listFTEventTag});
            this.listViewFileText.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewFileText.FullRowSelect = true;
            this.listViewFileText.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFileText.Location = new System.Drawing.Point(129, 6);
            this.listViewFileText.Name = "listViewFileText";
            this.listViewFileText.ShowItemToolTips = true;
            this.listViewFileText.Size = new System.Drawing.Size(236, 239);
            this.listViewFileText.TabIndex = 2;
            this.listViewFileText.UseCompatibleStateImageBehavior = false;
            this.listViewFileText.View = System.Windows.Forms.View.Details;
            // 
            // listFTEventName
            // 
            this.listFTEventName.Text = "行动";
            this.listFTEventName.Width = 56;
            // 
            // listFTEventValue
            // 
            this.listFTEventValue.Text = "参数";
            this.listFTEventValue.Width = 116;
            // 
            // listFTEventTag
            // 
            this.listFTEventTag.Text = "附加";
            this.listFTEventTag.Width = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择";
            // 
            // cBoxQuestList
            // 
            this.cBoxQuestList.FormattingEnabled = true;
            this.cBoxQuestList.Location = new System.Drawing.Point(32, 6);
            this.cBoxQuestList.Name = "cBoxQuestList";
            this.cBoxQuestList.Size = new System.Drawing.Size(95, 20);
            this.cBoxQuestList.TabIndex = 0;
            this.cBoxQuestList.SelectedIndexChanged += new System.EventHandler(this.cBoxQuestList_SelectedIndexChanged);
            // 
            // tabPageMake
            // 
            this.tabPageMake.Location = new System.Drawing.Point(4, 22);
            this.tabPageMake.Name = "tabPageMake";
            this.tabPageMake.Size = new System.Drawing.Size(418, 249);
            this.tabPageMake.TabIndex = 2;
            this.tabPageMake.Text = "制作";
            this.tabPageMake.UseVisualStyleBackColor = true;
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.Controls.Add(this.panel2);
            this.tabPageSetup.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Size = new System.Drawing.Size(418, 249);
            this.tabPageSetup.TabIndex = 3;
            this.tabPageSetup.Text = "设置";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 244);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "结束脚本";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "开始脚本";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(0, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 1);
            this.label12.TabIndex = 10;
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "快捷键设置";
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.txtCalI);
            this.tabPageTest.Controls.Add(this.txtCalR);
            this.tabPageTest.Controls.Add(this.btnCal);
            this.tabPageTest.Controls.Add(this.button1);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(418, 249);
            this.tabPageTest.TabIndex = 4;
            this.tabPageTest.Text = "测试";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // txtCalI
            // 
            this.txtCalI.Location = new System.Drawing.Point(335, 135);
            this.txtCalI.Name = "txtCalI";
            this.txtCalI.Size = new System.Drawing.Size(75, 21);
            this.txtCalI.TabIndex = 3;
            // 
            // txtCalR
            // 
            this.txtCalR.Location = new System.Drawing.Point(335, 162);
            this.txtCalR.Name = "txtCalR";
            this.txtCalR.Size = new System.Drawing.Size(75, 21);
            this.txtCalR.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(335, 189);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "计算测试";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(140, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 64);
            this.listBox1.TabIndex = 18;
            // 
            // FormHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 275);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHelper_FormClosed);
            this.Load += new System.EventHandler(this.FormHelper_Load);
            this.panelMapCo.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtLoopAmount)).EndInit();
            this.tabPageScript.ResumeLayout(false);
            this.tabPageScript.PerformLayout();
            this.tabPageSetup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageTest.ResumeLayout(false);
            this.tabPageTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMapCo;
        private System.Windows.Forms.Label labMapCo;
        private System.Windows.Forms.Timer tmrCore;
        private System.Windows.Forms.Label labMapCoInfo;
        private System.Windows.Forms.Timer tmrKeyEvent;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageScript;
        private System.Windows.Forms.TabPage tabPageMake;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCalI;
        private System.Windows.Forms.TextBox txtCalR;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListView listViewFileText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxQuestList;
        private System.Windows.Forms.Button btnQuestToRunList;
        private System.Windows.Forms.Button btnQuestDeleteEvent;
        private System.Windows.Forms.Button btnQuestSave;
        private System.Windows.Forms.Button btnQuestNew;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnQuestAddEvent;
        private System.Windows.Forms.ColumnHeader listFTEventName;
        private System.Windows.Forms.ColumnHeader listFTEventValue;
        private System.Windows.Forms.ColumnHeader listFTEventTag;
        private System.Windows.Forms.Label labRTEvent;
        private System.Windows.Forms.ListBox listBoxRTQuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimeSetting;
        private System.Windows.Forms.Label labSelectedQuestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSeparatorLine1;
        private System.Windows.Forms.Label labSeparatorLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxFormTopUp;
        private System.Windows.Forms.Label labCompleteTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerRunTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.NumericUpDown numTxtLoopAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxScripts;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerListDelay;
        private System.Windows.Forms.CheckBox checkBoxEndTime;
        private System.Windows.Forms.CheckBox checkBoxStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

