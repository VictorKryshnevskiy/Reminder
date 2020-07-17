﻿using System;
using ReminderClassLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectApp
{
    public partial class UserInterfaceForm : Form
    {
        List<Remind> remindersList;
        public event EventHandler<RemindEventArgs> RemindEdition;
        UserInterfaceForm form;
        public UserInterfaceForm()
        {
            InitializeComponent();
        }
        private void createReminderButton_Click(object sender, EventArgs e)
        {
            Form form = new CreateReminderForm(this);
            form.Show();
            Visible = false;
        }
        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            form = new UserInterfaceForm();
            if (FileSystem.IsExist("Reminder.json"))
            {
                WriteRemindsToGrid();
            }
        }
        private void deleteReminderButton_Click(object sender, EventArgs e)
        {
            var indexToDelete = reminderDataGridView.CurrentRow.Index;
            var listElementToDelete = FindIndexInArray(indexToDelete);
            remindersList.RemoveAt(listElementToDelete);
            reminderDataGridView.Rows.RemoveAt(indexToDelete);
            FileSystem.SaveRemind(remindersList);
        }
        private void editReminderButton_Click(object sender, EventArgs e)
        {
            var indexToEdit = reminderDataGridView.CurrentRow.Index;
            var listElementToEdit = FindIndexInArray(indexToEdit);
            var remindToEdit = remindersList.ElementAt(listElementToEdit);
            Form form = new CreateReminderForm(this);
            form.Show(this);
            Visible = false;
            RemindEdition.Invoke(this, new RemindEventArgs(remindToEdit));
            form.Visible = false;
            form.ShowDialog();
            if (CreateReminderForm.SaveButtonClicked)
            {
                remindersList.RemoveAt(listElementToEdit);
                reminderDataGridView.Rows.RemoveAt(indexToEdit);
                FileSystem.SaveRemind(remindersList);
                reminderDataGridView.Rows.Clear();
                WriteRemindsToGrid();
            }
        }
        private void UserInterfaceForm_VisibleChanged(object sender, EventArgs e)
        {
            reminderDataGridView.Rows.Clear();
            WriteRemindsToGrid();
        }
        private int FindIndexInArray(int indexInTable)
        {
            return remindersList.FindIndex(x => x.RemindName == reminderDataGridView[nameColumn.Index, indexInTable]
            .Value.ToString());
        }
        private void WriteRemindsToGrid()
        {
            remindersList = FileSystem.GetRemind();
            foreach (var remind in remindersList)
            {
                reminderDataGridView.Rows.Add(remind.StartRemindDate, remind.RemindName, remind.EndRemindDate,
                    remind.RemindDescription, remind.TasksList);
            }
        }
    }
}
