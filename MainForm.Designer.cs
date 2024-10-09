
namespace AssignementStickNotes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAssignmentButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.assignmentListView = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIconStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Title.Font = new System.Drawing.Font("Inter_FXH", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter_FXH", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewAssignmentButton
            // 
            this.NewAssignmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.NewAssignmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewAssignmentButton.FlatAppearance.BorderSize = 3;
            this.NewAssignmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAssignmentButton.Font = new System.Drawing.Font("Inter_FXH", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAssignmentButton.Location = new System.Drawing.Point(348, 31);
            this.NewAssignmentButton.Name = "NewAssignmentButton";
            this.NewAssignmentButton.Size = new System.Drawing.Size(40, 41);
            this.NewAssignmentButton.TabIndex = 3;
            this.NewAssignmentButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NewAssignmentButton.UseVisualStyleBackColor = false;
            this.NewAssignmentButton.Click += new System.EventHandler(this.NewAssignmentButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(372, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 22);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // assignmentListView
            // 
            this.assignmentListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.assignmentListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.assignmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignmentListView.Font = new System.Drawing.Font("Inter_FXH", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentListView.HideSelection = false;
            this.assignmentListView.Location = new System.Drawing.Point(12, 97);
            this.assignmentListView.Name = "assignmentListView";
            this.assignmentListView.Size = new System.Drawing.Size(376, 294);
            this.assignmentListView.TabIndex = 7;
            this.assignmentListView.UseCompatibleStateImageBehavior = false;
            this.assignmentListView.View = System.Windows.Forms.View.List;
            this.assignmentListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.assignmentListView_MouseClick);
            this.assignmentListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.assignmentListView_MouseMove);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.TrayIconStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // TrayIconStrip
            // 
            this.TrayIconStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.TrayIconStrip.Name = "TrayIconStrip";
            this.TrayIconStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 403);
            this.ControlBox = false;
            this.Controls.Add(this.assignmentListView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.NewAssignmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TrayIconStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewAssignmentButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView assignmentListView;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip TrayIconStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

