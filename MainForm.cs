/*
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;*/
using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AssignementStickNotes
{
    public partial class MainForm : Form
    {
        private assignmentPromptForm assignmentPrompt;

        private int lastHoveredIndex = -1;
        private bool itemRemoving = false; // Flag to track if an item is being removed

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private List<Assignment> assignmentsList = new List<Assignment>();

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);

            assignmentsList = LoadAssignment();

            foreach (Assignment assignment in assignmentsList)
            {
                assignmentListView.Items.Add($"• {assignment.getCourseCode()}: {assignment.getAssignment()}, Due date: {assignment.getDueDate():MMM. dd}");
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
            if (assignmentPrompt == null || assignmentPrompt.IsDisposed) // Check if the form is already created or disposed
            {
                assignmentPrompt = new assignmentPromptForm();  // Only create a new form if it's not open
                assignmentPrompt.Show();
                assignmentPrompt.newAssignmentCreated += onAssignmentCreated;
            }
            else
            {
                assignmentPrompt.BringToFront(); // Bring the existing form to the front if it's already open
            }
        }

        private void onAssignmentCreated()
        {
            Assignment newAssignment = assignmentPrompt.getNewAssignment();
            assignmentsList.Add(newAssignment);

            assignmentListView.Items.Add($"• {newAssignment.getCourseCode()}: {newAssignment.getAssignment()}, Due date: {newAssignment.getDueDate():MMM. dd}");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SaveAssignment(assignmentsList);

            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "";

            foreach (Assignment assignment in assignmentsList)
            {
                if (notifyIcon1.Text.Length >= 64)
                {
                    notifyIcon1.Text += ($"\n{assignment.getCourseCode()}: {assignment.getAssignment()}");
                }
            }
        }

        private void assignmentListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = assignmentListView.GetItemAt(e.X, e.Y);

            if (selectedItem != null)
            {
                itemRemoving = true; // Set the flag to indicate removal
                lastHoveredIndex = -1; // Reset lastHoveredIndex to prevent future invalid access
                assignmentListView.Items.Remove(selectedItem);
                Console.WriteLine(selectedItem.Index);
                assignmentsList.Remove(assignmentsList[selectedItem.Index + 1]); // Index starts at -1 for some reason with the listView so we add one to start at 0
            }
        }

        private void SaveAssignment(List<Assignment> assignments)
        {
            string jsonString = JsonConvert.SerializeObject(assignments, Formatting.Indented);
            File.WriteAllText("assignments.json", jsonString);
        }

        private List<Assignment> LoadAssignment()
        {
            if (File.Exists("assignments.json"))
            {
                // Read JSON string from the file
                string jsonString = File.ReadAllText("assignments.json");

                // Deserialize JSON string back into a List<Assignment>
                return JsonConvert.DeserializeObject<List<Assignment>>(jsonString);
            }
            return new List<Assignment>(); // Return an empty list if the file doesn't exist
        }

        private void assignmentListView_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the index of the item under the mouse pointer
            ListViewItem item = assignmentListView.GetItemAt(e.X, e.Y);

            if (assignmentListView.Items.Count > 0)
            {
                if (item != null)
                {
                    int currentHoveredIndex = item.Index;

                    // If an item is being removed, ignore font changes
                    if (!itemRemoving)
                    {
                        // Change the font of the previous item back to normal if it exists
                        if (lastHoveredIndex != -1 && lastHoveredIndex != currentHoveredIndex)
                        {
                            // Check if lastHoveredIndex is still valid before accessing it
                            if (lastHoveredIndex < assignmentListView.Items.Count)
                            {
                                assignmentListView.Items[lastHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Bold);
                            }
                        }

                        // Set the last hovered index
                        lastHoveredIndex = currentHoveredIndex;

                        // Change the font of the currently hovered item to Strikethrough
                        assignmentListView.Items[currentHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Strikeout | FontStyle.Bold);
                    }
                }
                else
                {
                    // If no item is currently being hovered, revert the last hovered item's font
                    if (lastHoveredIndex != -1)
                    {
                        // Check if lastHoveredIndex is still valid before accessing it
                        if (lastHoveredIndex < assignmentListView.Items.Count)
                        {
                            assignmentListView.Items[lastHoveredIndex].Font = new Font(assignmentListView.Font.FontFamily, assignmentListView.Font.Size, FontStyle.Bold);
                        }
                        lastHoveredIndex = -1; // Reset the last hovered index
                    }
                }
            }

            // Reset itemRemoving flag after the mouse move event
            itemRemoving = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            notifyIcon1.Visible = false;
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            currentAssignments.Items.Clear();
            currentAssignments.Items.Add("Current Assignments: ");
            foreach (Assignment assignment in assignmentsList)
            {
                currentAssignments.Items.Add($"\n{assignment.getCourseCode()}: {assignment.getAssignment()}");
            }
            currentAssignments.Show(Control.MousePosition);
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
        [JsonProperty]
        private String courseCode;
        [JsonProperty]
        private String assignmentName;
        [JsonProperty]
        private DateTime dueDate;

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

        public DateTime getDueDate()
        {
            return (dueDate);
        }
    }
}
