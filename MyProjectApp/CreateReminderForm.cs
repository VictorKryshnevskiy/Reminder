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
        private CheckState checkState = 0;
        int checkStateIndex = 0;

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
            timeBeforeRemindnumericUpDown.Value = Remind.DateToRimind.TimeBeforeRemind;
            timeBeforeRemindComboBox.Text = Remind.DateToRimind.Period;
            foreach (var task in Remind.TasksList)
            {
                if (task.CheckStatus == CheckStatus.ToDo)
                {
                    toDoReminderTasksRichTextBox.Text += task.TaskText + '\n';
                }
                if (task.CheckStatus == CheckStatus.InProgress)
                {
                    inProgressReminderTasksRichTextBox.Text += task.TaskText + '\n';
                }
                if (task.CheckStatus == CheckStatus.Done)
                {
                    doneReminderTasksRichTextBox.Text += task.TaskText + '\n';
                }
            }
        }
        private void saveRemindButton_Click(object sender, EventArgs e)
        {
            if (reminderNameTextBox.Text != "")
            {
                Remind.StartRemindDate = startDateTimePicker.Value;
                Remind.RemindName = reminderNameTextBox.Text;
                Remind.EndRemindDate = endDateTimePicker.Value;
                Remind.RemindDescription = reminderDescriptionTextBox.Text;
                Remind.DateToRimind = new DateToRimind(Convert.ToInt32(timeBeforeRemindnumericUpDown.Value), timeBeforeRemindComboBox.Text);
                Remind.DateTimeToRemind =  CountDate(Convert.ToInt32(timeBeforeRemindnumericUpDown.Value), timeBeforeRemindComboBox.Text);
                Remind.TasksList = toDoReminderTasksRichTextBox.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindsTask(x)).ToList();
                Remind.TasksList.AddRange(inProgressReminderTasksRichTextBox.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindsTask(x,CheckStatus.InProgress)).ToList());
                Remind.TasksList.AddRange(doneReminderTasksRichTextBox.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => new RemindsTask(x,CheckStatus.Done)).ToList());

                FileSystem.SaveRemind(Remind);
                SaveButtonClicked = true;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите имя события");
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkStateIndex = e.Index;
            if (e.CurrentValue == 0)
            { checkState = (CheckState)2; }
            if (e.CurrentValue == (CheckState)2)
            { checkState = (CheckState)1; }
            if (e.CurrentValue == (CheckState)1)
            { checkState = 0; }
        }
        private DateTime CountDate(int timeBeforeRemind, string period)
        {
            
            if (period == "Дни")
            {
                return Remind.EndRemindDate.AddDays(-1 * timeBeforeRemind);
            }
            if (period == "Часы")
            {
                return Remind.EndRemindDate.AddHours(-1 * timeBeforeRemind);
            }
            if (period == "Минуты")
            {
                return Remind.EndRemindDate.AddMinutes(-1 * timeBeforeRemind);
            }
            else
            { return Remind.DateTimeToRemind; }
        }
    }
}

