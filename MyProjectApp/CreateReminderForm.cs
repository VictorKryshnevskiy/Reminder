using System;
using ReminderClassLibrary;
using System.Text.Json;
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
    public partial class CreateReminderForm : Form
    {
        public UserInterfaceForm Form { get; }
        public static bool SaveButtonClicked { get; private set; }

        public CreateReminderForm(UserInterfaceForm form)
        {
            InitializeComponent();
            Form = form;
            Form.RemindEdition += Form_RemindEdition;
        }

        private void CreateReminderForm_Load(object sender, EventArgs e)
        {
            SaveButtonClicked = false;
        }

        private void Form_RemindEdition(object sender, RemindEventArgs e)
        {
            startDateTimePicker.Value = e.Remind.StartRemindDate;
            reminderNameTextBox.Text = e.Remind.RemindName;
            endDateTimePicker.Value = e.Remind.EndRemindDate;
            reminderDescriptionTextBox.Text = e.Remind.RemindDescription;
            reminderTasksRichTextBox.Text = e.Remind.TasksList;
        }

        private void saveRemindButton_Click(object sender, EventArgs e)
        {
            if (reminderNameTextBox.Text != "")
            {
                var startDate = startDateTimePicker.Value;
                var name = reminderNameTextBox.Text;
                var endDate = endDateTimePicker.Value;
                var description = reminderDescriptionTextBox.Text;
                var tasks = reminderTasksRichTextBox.Text;
                var remind = new Remind(startDate, name, endDate, description, tasks);
                FileSystem.SaveRemind(remind);
                SaveButtonClicked = true;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите имя события");
            }
        }

        private void CreateReminderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Visible = true;
        }
    }
}
