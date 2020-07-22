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
            timeBeforeRemindtextBox.Text = (Remind.EndRemindDate - Remind.DateToRemind).ToString();
            //timeBeforeRemindComboBox = ;
            foreach (var task in Remind.TasksList)
            {
                reminderTasksRichTextBox.Text += task.TaskText + '\n';
                checkedListBox1.Items.Add(task.TaskText, task.CheckStatus);
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
                Remind.DateToRemind = CountDate(Convert.ToInt32(timeBeforeRemindtextBox.Text),timeBeforeRemindComboBox.Text);
                Remind.TasksList = reminderTasksRichTextBox.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(x => new RemindsTask(x)).ToList();
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
            { return Remind.DateToRemind; }
        }
    }
}
