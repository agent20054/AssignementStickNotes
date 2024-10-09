
namespace AssignementStickNotes
{
    partial class assignmentPromptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseCodeBox = new System.Windows.Forms.TextBox();
            this.assignmentNameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.assignmentNameLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.CreateAssignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter_FXH", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Assignment";
            // 
            // courseCodeBox
            // 
            this.courseCodeBox.ForeColor = System.Drawing.Color.DarkGray;
            this.courseCodeBox.Location = new System.Drawing.Point(159, 77);
            this.courseCodeBox.Name = "courseCodeBox";
            this.courseCodeBox.Size = new System.Drawing.Size(207, 20);
            this.courseCodeBox.TabIndex = 1;
            this.courseCodeBox.Text = "CS1073";
            this.courseCodeBox.Enter += new System.EventHandler(this.courseCodeBox_Enter);
            this.courseCodeBox.Leave += new System.EventHandler(this.courseCodeBox_Leave);
            // 
            // assignmentNameBox
            // 
            this.assignmentNameBox.ForeColor = System.Drawing.Color.DarkGray;
            this.assignmentNameBox.Location = new System.Drawing.Point(159, 161);
            this.assignmentNameBox.Name = "assignmentNameBox";
            this.assignmentNameBox.Size = new System.Drawing.Size(207, 20);
            this.assignmentNameBox.TabIndex = 1;
            this.assignmentNameBox.Text = "Media Critique";
            this.assignmentNameBox.Enter += new System.EventHandler(this.assignmentNameBox_Enter);
            this.assignmentNameBox.Leave += new System.EventHandler(this.assignmentNameBox_Leave);
            // 
            // dateBox
            // 
            this.dateBox.ForeColor = System.Drawing.Color.DarkGray;
            this.dateBox.Location = new System.Drawing.Point(159, 243);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(207, 20);
            this.dateBox.TabIndex = 1;
            this.dateBox.Text = "2024/10/04";
            this.dateBox.Enter += new System.EventHandler(this.dateBox_Enter);
            this.dateBox.Leave += new System.EventHandler(this.dateBox_Leave);
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Location = new System.Drawing.Point(20, 84);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(74, 13);
            this.courseCodeLabel.TabIndex = 2;
            this.courseCodeLabel.Text = "Course Code :";
            // 
            // assignmentNameLabel
            // 
            this.assignmentNameLabel.AutoSize = true;
            this.assignmentNameLabel.Location = new System.Drawing.Point(20, 168);
            this.assignmentNameLabel.Name = "assignmentNameLabel";
            this.assignmentNameLabel.Size = new System.Drawing.Size(95, 13);
            this.assignmentNameLabel.TabIndex = 2;
            this.assignmentNameLabel.Text = "Assignment Name:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(20, 246);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.dueDateLabel.TabIndex = 2;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(361, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 22);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CreateAssignment
            // 
            this.CreateAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.CreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAssignment.Font = new System.Drawing.Font("Inter_FXH", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssignment.Location = new System.Drawing.Point(61, 305);
            this.CreateAssignment.Name = "CreateAssignment";
            this.CreateAssignment.Size = new System.Drawing.Size(260, 47);
            this.CreateAssignment.TabIndex = 6;
            this.CreateAssignment.Text = "Create Assignment";
            this.CreateAssignment.UseVisualStyleBackColor = false;
            this.CreateAssignment.Click += new System.EventHandler(this.CreateAssignment_Click);
            // 
            // assignmentPromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.CreateAssignment);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.assignmentNameLabel);
            this.Controls.Add(this.courseCodeLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.assignmentNameBox);
            this.Controls.Add(this.courseCodeBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assignmentPromptForm";
            this.Text = "assignmentPromptForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.assignmentPromptForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseCodeBox;
        private System.Windows.Forms.TextBox assignmentNameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label assignmentNameLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button CreateAssignment;
    }
}