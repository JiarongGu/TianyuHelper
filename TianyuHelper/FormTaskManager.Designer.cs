using System.Windows.Forms;

namespace TianyuHelper
{
    partial class FormTaskManager
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
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnTaskId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTaskId,
            this.columnName,
            this.columnDetail});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.Location = new System.Drawing.Point(0, 0);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(300, 187);
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTasks_DoubleClick);
            // 
            // columnTaskId
            // 
            this.columnTaskId.Text = "编号";
            this.columnTaskId.Width = 47;
            // 
            // columnName
            // 
            this.columnName.Text = "进程";
            this.columnName.Width = 74;
            // 
            // columnDetail
            // 
            this.columnDetail.Text = "角色信息";
            this.columnDetail.Width = 175;
            // 
            // FormTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 187);
            this.Controls.Add(this.listViewTasks);
            this.Name = "FormTaskManager";
            this.Text = "FormTaskManager";
            this.Load += new System.EventHandler(this.FormTaskManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnTaskId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDetail;
    }
}