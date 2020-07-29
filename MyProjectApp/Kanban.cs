using ReminderClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyProjectApp
{
    public partial class Kanban : Form
    {
        public static Remind Remind;
        int itemIndex;
        ListBox listBox;
        public Kanban(Remind rem)
        {
            InitializeComponent();
            Remind = rem;
        }
        private void Kanban_Load(object sender, EventArgs e)
        {
            foreach (var task in Remind.TasksList)
            {
                if (task.Status == TaskStatus.ToDo)
                {
                    toDoListBox.Items.Add(task.Text);
                }
                if (task.Status == TaskStatus.InProgress)
                {
                    inProgressListBox.Items.Add(task.Text);
                }
                if (task.Status == TaskStatus.Done)
                {
                    doneListBox.Items.Add(task.Text);
                }
            }
            toDoListBox.DragDrop += ListBox_DragDrop;
            toDoListBox.DragOver += ListBox_DragOver;
            toDoListBox.MouseDown += ListBox_MouseDown;
            inProgressListBox.DragDrop += ListBox_DragDrop;
            inProgressListBox.DragOver += ListBox_DragOver;
            inProgressListBox.MouseDown += ListBox_MouseDown;
            doneListBox.DragDrop += ListBox_DragDrop;
            doneListBox.DragOver += ListBox_DragOver;
            doneListBox.MouseDown += ListBox_MouseDown;
            toDoListBox.AllowDrop = true;
            inProgressListBox.AllowDrop = true;
            doneListBox.AllowDrop = true;
        }
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            listBox = sender as ListBox;
            if (listBox.Items.Count == 0 || listBox.SelectedIndex == -1) return;
            itemIndex = listBox.SelectedIndex;
            DoDragDrop(listBox.SelectedItem.ToString(), DragDropEffects.All);
        }
        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lbx = sender as ListBox;
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                int index = lbx.IndexFromPoint(PointToClient(new Point(e.X, e.Y)));

                if (index == -1)
                    lbx.Items.Add((string)e.Data.GetData(DataFormats.StringFormat));
                else
                    lbx.Items.Insert(index, (string)e.Data.GetData(DataFormats.StringFormat));

                if (itemIndex != -1 && listBox != null) listBox.Items.RemoveAt(itemIndex);
            }
            RewriteTasks();
        }

        private void RewriteTasks()
        {
            Remind.TasksList = new List<RemindTask> { };
            foreach (var task in toDoListBox.Items)
            {
                Remind.TasksList.Add(new RemindTask(task.ToString(), TaskStatus.ToDo));
            }
            foreach (var task in inProgressListBox.Items)
            {
                Remind.TasksList.Add(new RemindTask(task.ToString(), TaskStatus.InProgress));
            }
            foreach (var task in doneListBox.Items)
            {
                Remind.TasksList.Add(new RemindTask(task.ToString(), TaskStatus.Done));
            }
        }

        private void Kanban_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileSystem.SaveRemind(Remind);
        }
    }
}
