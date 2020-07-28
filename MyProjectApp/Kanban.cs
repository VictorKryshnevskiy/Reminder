using ReminderClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProjectApp
{
    public partial class Kanban : Form
    {
        Remind remind;
        int itemIndex;
        ListBox listBox;
        public Kanban(Remind rem)
        {
            InitializeComponent();
            remind = rem;
            toDoListBox.DragDrop += ListBox_DragDrop;
            toDoListBox.DragOver += ListBox_DragOver;
            toDoListBox.MouseDown += ListBox_MouseDown;
            inProgressListBox.DragDrop += ListBox_DragDrop;
            inProgressListBox.DragOver += ListBox_DragOver;
            inProgressListBox.MouseDown += ListBox_MouseDown;
            doneListBox.DragDrop += ListBox_DragDrop;
            doneListBox.DragOver += ListBox_DragOver;
            doneListBox.MouseDown += ListBox_MouseDown;
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Kanban_Load(object sender, EventArgs e)
        {
            foreach (var task in remind.TasksList)
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
        }
    }
}
