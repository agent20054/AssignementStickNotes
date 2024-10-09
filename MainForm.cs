/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;*/
using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;

namespace AssignementStickNotes
{
    public partial class MainForm : Form
    {
        private assignmentPromptForm newForm;
        private sbyte lastHoveredIndex = -1;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);

            if (!File.Exists("assignments.txt"))
            {
                File.Create("assignments.txt").Close();
            }
            else
            {
                string[] lines = File.ReadAllLines("assignments.txt");

                // Add each line as an item to the ListView
                foreach (string line in lines)
                {
                    assignmentListView.Items.Add(line);
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private void NewAssignmentButton_Click(object sender, EventArgs e)
        {
            if (newForm == null || newForm.IsDisposed) // Check if the form is already created or disposed
            {
                newForm = new assignmentPromptForm();  // Only create a new form if it's not open
                newForm.Show();
                newForm.newAssignmentCreated += onAssignmentCreated;
            }
            else
            {
                newForm.BringToFront(); // Bring the existing form to the front if it's already open
            }
        }

        private void onAssignmentCreated()
        {
            Assignment newAssignment = newForm.getNewAssignment();
            assignmentListView.Items.Add("• " + newAssignment.getCourseCode() + ": " + 
                                            newAssignment.getAssignment() + ", Due date: " + 
                                            newAssignment.getDueDate());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;

            // Create an array of strings with the text of each item
            string[] items = assignmentListView.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray();

            // Write all lines to a file
            File.WriteAllLines("assignments.txt", items);
        }

        private void assignmentListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = assignmentListView.GetItemAt(e.X, e.Y);

            if (selectedItem != null)
            {
                assignmentListView.Items.Remove(selectedItem);
            }
        }

        private void assignmentListView_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the index of the item under the mouse pointer
            ListViewItem item = assignmentListView.GetItemAt(e.X, e.Y);

            if (assignmentListView.Items.Count > 0)
            {
                if (item != null)
                {
                    sbyte currentHoveredIndex = (sbyte)item.Index;

                    // Change the font of the previous item back to normal if it exists
                    if (lastHoveredIndex != -1 && lastHoveredIndex != currentHoveredIndex)
                    {
                        assignmentListView.Items[lastHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Bold);
                    }

                    // Set the last hovered index
                    lastHoveredIndex = currentHoveredIndex;

                    // Change the font of the currently hovered item to Strikethrough
                    assignmentListView.Items[currentHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Strikeout | FontStyle.Bold);
                }
                else
                {
                    // If no item is currently being hovered, revert the last hovered item's font
                    if (lastHoveredIndex != -1)
                    {
                        assignmentListView.Items[lastHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Bold);
                        lastHoveredIndex = -1; // Reset the last hovered index
                    }
                }
            }
            else
            {
                lastHoveredIndex = -1;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            notifyIcon1.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            notifyIcon1.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Assignment
    {
        String courseCode;
        String assignmentName;
        DateTime dueDate;

        public Assignment(String courseCodeIn, String assignmentNameIn, DateTime dateIn)
        {
            courseCode = courseCodeIn;
            assignmentName = assignmentNameIn;
            dueDate = dateIn;
        }

        public String getCourseCode()
        {
            return courseCode;
        }

        public String getAssignment()
        {
            return assignmentName;
        }

        public String getDueDate()
        {
            String dueDateString = dueDate.ToString("MMM. dd");
            return dueDateString;
        }
    }
}
