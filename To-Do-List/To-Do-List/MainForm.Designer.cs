
namespace To_Do_List
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calendarOperatorPanel = new System.Windows.Forms.Panel();
            this.prevDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.leftSideMenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.mainFormImageList = new System.Windows.Forms.ImageList(this.components);
            this.calendarOperatorPanel.SuspendLayout();
            this.leftSideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarOperatorPanel
            // 
            this.calendarOperatorPanel.BackColor = System.Drawing.Color.IndianRed;
            this.calendarOperatorPanel.Controls.Add(this.prevDayButton);
            this.calendarOperatorPanel.Controls.Add(this.nextDayButton);
            this.calendarOperatorPanel.Controls.Add(this.DateLabel);
            this.calendarOperatorPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarOperatorPanel.Name = "calendarOperatorPanel";
            this.calendarOperatorPanel.Size = new System.Drawing.Size(245, 95);
            this.calendarOperatorPanel.TabIndex = 0;
            // 
            // prevDayButton
            // 
            this.prevDayButton.FlatAppearance.BorderSize = 0;
            this.prevDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevDayButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prevDayButton.ForeColor = System.Drawing.Color.White;
            this.prevDayButton.Location = new System.Drawing.Point(24, 21);
            this.prevDayButton.Name = "prevDayButton";
            this.prevDayButton.Size = new System.Drawing.Size(37, 36);
            this.prevDayButton.TabIndex = 2;
            this.prevDayButton.Text = "<";
            this.prevDayButton.UseVisualStyleBackColor = true;
            // 
            // nextDayButton
            // 
            this.nextDayButton.FlatAppearance.BorderSize = 0;
            this.nextDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextDayButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextDayButton.ForeColor = System.Drawing.Color.White;
            this.nextDayButton.Location = new System.Drawing.Point(182, 21);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(37, 36);
            this.nextDayButton.TabIndex = 1;
            this.nextDayButton.Text = ">";
            this.nextDayButton.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(67, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(109, 48);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "21.05";
            // 
            // leftSideMenuPanel
            // 
            this.leftSideMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftSideMenuPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.leftSideMenuPanel.Controls.Add(this.button1);
            this.leftSideMenuPanel.Controls.Add(this.newTaskButton);
            this.leftSideMenuPanel.Location = new System.Drawing.Point(0, 101);
            this.leftSideMenuPanel.Name = "leftSideMenuPanel";
            this.leftSideMenuPanel.Size = new System.Drawing.Size(245, 465);
            this.leftSideMenuPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newTaskButton
            // 
            this.newTaskButton.FlatAppearance.BorderSize = 0;
            this.newTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTaskButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newTaskButton.ForeColor = System.Drawing.Color.White;
            this.newTaskButton.Location = new System.Drawing.Point(0, 10);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(245, 57);
            this.newTaskButton.TabIndex = 0;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            // 
            // tasksPanel
            // 
            this.tasksPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tasksPanel.Location = new System.Drawing.Point(251, 0);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(733, 566);
            this.tasksPanel.TabIndex = 2;
            // 
            // mainFormImageList
            // 
            this.mainFormImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainFormImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainFormImageList.ImageStream")));
            this.mainFormImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainFormImageList.Images.SetKeyName(0, "RightArrowIcon.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 558);
            this.Controls.Add(this.tasksPanel);
            this.Controls.Add(this.leftSideMenuPanel);
            this.Controls.Add(this.calendarOperatorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.calendarOperatorPanel.ResumeLayout(false);
            this.calendarOperatorPanel.PerformLayout();
            this.leftSideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel calendarOperatorPanel;
        private System.Windows.Forms.Panel leftSideMenuPanel;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.Button prevDayButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ImageList mainFormImageList;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Button button1;
    }
}

