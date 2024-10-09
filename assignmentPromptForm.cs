/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;*/
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AssignementStickNotes
{
    public partial class assignmentPromptForm : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private Assignment newAssignment;

        public event Action newAssignmentCreated;

        public assignmentPromptForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(assignmentPromptForm_MouseDown);
        }

        

        private void courseCodeBox_Enter(object sender, EventArgs e)
        {
            if (courseCodeBox.Text == "CS1073")
            {
                courseCodeBox.Text = "";
                courseCodeBox.ForeColor = Color.Black;
            }
        }

        private void assignmentNameBox_Enter(object sender, EventArgs e)
        {
            if (assignmentNameBox.Text == "Media Critique")
            {
                assignmentNameBox.Text = "";
                assignmentNameBox.ForeColor = Color.Black;
            }
        }

        private void dateBox_Enter(object sender, EventArgs e)
        {
            if (dateBox.Text == "2024/10/04")
            {
                dateBox.Text = "";
                dateBox.ForeColor = Color.Black;
            }
        }



        private void courseCodeBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseCodeBox.Text))
            {
                courseCodeBox.Text = "CS1073";
                courseCodeBox.ForeColor = Color.DarkGray;
            }
        }

        private void assignmentNameBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assignmentNameBox.Text))
            {
                assignmentNameBox.Text = "Media Critique";
                assignmentNameBox.ForeColor = Color.DarkGray;
            }
        }

        private void dateBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateBox.Text))
            {
                dateBox.Text = "2024/10/04";
                dateBox.ForeColor = Color.DarkGray;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAssignment_Click(object sender, EventArgs e)
        {
            String courseCodeIn = courseCodeBox.Text;
            String assignmentNameIn = assignmentNameBox.Text;

            DateTime dueDateIn = DateTime.Parse(dateBox.Text);

            newAssignment = new Assignment(courseCodeIn, assignmentNameIn, dueDateIn);

            newAssignmentCreated?.Invoke();
            this.Close();
        }

        public Assignment getNewAssignment()
        {
            return newAssignment;
        }

        private void assignmentPromptForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
