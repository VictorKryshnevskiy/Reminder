using System;
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
        public UserInterfaceForm()
        {
            InitializeComponent();
        }
        private void createReminderButton_Click(object sender, EventArgs e)
        {
            //Hide();
            Form form = new CreateReminderForm();
            form.Show();
        }
        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            if (FileSystem.IsExist("Reminder.json"))
            {
                remindersList = FileSystem.GetRemind();
                foreach (var remind in remindersList)
                {
                    reminderDataGridView.Rows.Add(remind.StartRemindDate, remind.RemindName, remind.EndRemindDate,
                        remind.RemindDescription, remind.TasksList);
                }
            }
        }
        private void deleteReminderButton_Click(object sender, EventArgs e)
        {
            var indexToDelete = reminderDataGridView.CurrentRow.Index;
            var listElementToDelet = remindersList.FindIndex(x => x.RemindName == reminderDataGridView[nameColumn.Index, indexToDelete]
            .Value.ToString());
            remindersList.RemoveAt(listElementToDelet);
            reminderDataGridView.Rows.RemoveAt(indexToDelete);
            FileSystem.SaveRemind(remindersList);
        }
    }
}
