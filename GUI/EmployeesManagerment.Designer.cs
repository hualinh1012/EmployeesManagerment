namespace GUI
{
    partial class EmployeesManagerment
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.emplTab = new System.Windows.Forms.TabPage();
            this.departmentTab = new System.Windows.Forms.TabPage();
            this.projectTab = new System.Windows.Forms.TabPage();
            this.dayOffTab = new System.Windows.Forms.TabPage();
            this.violationTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.emplTab);
            this.tabControl1.Controls.Add(this.departmentTab);
            this.tabControl1.Controls.Add(this.projectTab);
            this.tabControl1.Controls.Add(this.violationTab);
            this.tabControl1.Controls.Add(this.dayOffTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // emplTab
            // 
            this.emplTab.Location = new System.Drawing.Point(4, 22);
            this.emplTab.Name = "emplTab";
            this.emplTab.Padding = new System.Windows.Forms.Padding(3);
            this.emplTab.Size = new System.Drawing.Size(766, 423);
            this.emplTab.TabIndex = 0;
            this.emplTab.Text = "Nhân viên";
            this.emplTab.UseVisualStyleBackColor = true;
            // 
            // departmentTab
            // 
            this.departmentTab.Location = new System.Drawing.Point(4, 22);
            this.departmentTab.Name = "departmentTab";
            this.departmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.departmentTab.Size = new System.Drawing.Size(735, 403);
            this.departmentTab.TabIndex = 1;
            this.departmentTab.Text = "Phòng ban";
            this.departmentTab.UseVisualStyleBackColor = true;
            // 
            // projectTab
            // 
            this.projectTab.Location = new System.Drawing.Point(4, 22);
            this.projectTab.Name = "projectTab";
            this.projectTab.Size = new System.Drawing.Size(735, 403);
            this.projectTab.TabIndex = 2;
            this.projectTab.Text = "Dự án";
            this.projectTab.UseVisualStyleBackColor = true;
            // 
            // dayOffTab
            // 
            this.dayOffTab.Location = new System.Drawing.Point(4, 22);
            this.dayOffTab.Name = "dayOffTab";
            this.dayOffTab.Size = new System.Drawing.Size(735, 403);
            this.dayOffTab.TabIndex = 3;
            this.dayOffTab.Text = "Nghỉ làm";
            this.dayOffTab.UseVisualStyleBackColor = true;
            // 
            // violationTab
            // 
            this.violationTab.Location = new System.Drawing.Point(4, 22);
            this.violationTab.Name = "violationTab";
            this.violationTab.Size = new System.Drawing.Size(735, 403);
            this.violationTab.TabIndex = 4;
            this.violationTab.Text = "Vi phạm";
            this.violationTab.UseVisualStyleBackColor = true;
            // 
            // EmployeesManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesManagerment";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.EmployeesManagerment_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage emplTab;
        private System.Windows.Forms.TabPage departmentTab;
        private System.Windows.Forms.TabPage projectTab;
        private System.Windows.Forms.TabPage violationTab;
        private System.Windows.Forms.TabPage dayOffTab;
    }
}

