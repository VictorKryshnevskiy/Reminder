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
        public static bool SaveButtonClicked { get; private set; }
        public static Remind Remind { get; private set; }

        public CreateReminderForm(Remind rem)
        {
            InitializeComponent();
            Remind = rem;
        }
        private void CreateReminderForm_Load(object sender, EventArgs e)
        {
            SaveButtonClicked = false;
            if (Remind.RemindName != default)
            {
                RemindsPropertiesLoad();
            }
        }
        private void RemindsPropertiesLoad()
        {
            startDateTimePicker.Value = Remind.StartRemindDate;
            reminderNameTextBox.Text = Remind.RemindName;
            endDateTimePicker.Value = Remind.EndRemindDate;
            reminderDescriptionTextBox.Text = Remind.RemindDescription;
            reminderTasksRichTextBox.Text = Remind.TasksList;
        }
        private void saveRemindButton_Click(object sender, EventArgs e)
        {
            if (reminderNameTextBox.Text != "")
            {
                Remind.StartRemindDate = startDateTimePicker.Value;
                Remind.RemindName = reminderNameTextBox.Text;
                Remind.EndRemindDate = endDateTimePicker.Value;
                Remind.RemindDescription = reminderDescriptionTextBox.Text;
                Remind.TasksList = reminderTasksRichTextBox.Text;
                FileSystem.SaveRemind(Remind);
                SaveButtonClicked = true;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите имя события");
            }
        }
    }
}
