using System;
using ReminderClassLibrary;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyProjectApp
{
    public partial class CreateReminderForm : Form
    {
        public static bool SaveButtonClicked { get; private set; }
        public static Remind Remind { get; private set; }
        List<NumericUpDown> numericUpDownList;
        List<ComboBox> comboBoxList;
        int countButtons = 1;
        public CreateReminderForm(Remind rem)
        {
            InitializeComponent();
            Remind = rem;
        }
        private void CreateReminderForm_Load(object sender, EventArgs e)
        {
            SaveButtonClicked = false;
            com.Items
                .AddRange(new object[] { NotificationPeriod.Minutes, NotificationPeriod.Hours, NotificationPeriod.Days });
            numericUpDownList = new List<NumericUpDown> { num };
            comboBoxList = new List<ComboBox> { com };
            if (Remind.Name != default)
            {
                RemindsPropertiesLoad();
            }
            
        }
        private void RemindsPropertiesLoad()
        {
            startDateTimePicker.Value = Remind.StartDate;
            reminderNameTextBox.Text = Remind.Name;
            endDateTimePicker.Value = Remind.EndDate;
            reminderDescriptionTextBox.Text = Remind.Description;
            foreach (var dateToRimind in Remind.DateToRimind)
            {
                num.Value = dateToRimind.PeriodAmount;
                com.Text = dateToRimind.Period;
                button1_Click(button1, default);
            }
            foreach (var task in Remind.TasksList)
            {
                if (task.Status == TaskStatus.ToDo)
                {
                    toDoReminderTasksRichTextBox.Text += task.Text + '\n';
                }
                if (task.Status == TaskStatus.InProgress)
                {
                    inProgressReminderTasksRichTextBox.Text += task.Text + '\n';
                }
                if (task.Status == TaskStatus.Done)
                {
                    doneReminderTasksRichTextBox.Text += task.Text + '\n';
                }
            }
        }
        private void saveRemindButton_Click(object sender, EventArgs e)
        {
            if (reminderNameTextBox.Text != "")
            {
                Remind.StartDate = startDateTimePicker.Value;
                Remind.Name = reminderNameTextBox.Text;
                Remind.EndDate = endDateTimePicker.Value;
                Remind.Description = reminderDescriptionTextBox.Text;
                Remind.DateToRimind = new List<Notification> { new Notification(Convert.ToInt32(num.Value)
                    , com.Text) };
                for (int i = 0; i < comboBoxList.Count; i++)
                {
                    if (comboBoxList[i].Text != "")
                    {
                        Remind.DateToRimind.Add(new Notification((int)numericUpDownList[i].Value, comboBoxList[i].Text));
                    }
                }
                Remind.TasksList = toDoReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x)).ToList();
                Remind.TasksList.AddRange(inProgressReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x, TaskStatus.InProgress)).ToList());
                Remind.TasksList.AddRange(doneReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                , StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => new RemindTask(x, TaskStatus.Done)).ToList());
                FileSystem.SaveRemind(Remind);
                SaveButtonClicked = true;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите имя события");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Visible = false;
            var num = new NumericUpDown();
            var com = new ComboBox();
            com.DropDownStyle = ComboBoxStyle.DropDownList;
            com.Items.AddRange(new object[] { NotificationPeriod.Minutes, NotificationPeriod.Hours, NotificationPeriod.Days });
            Button buttonShow = new Button
            {
                Text = "Добавить напоминание",
                Width = num.Width
            };
            buttonShow.Location = new Point(button.Location.X + button.Width + 10, button.Location.Y);
            num.Location = new Point(buttonShow.Location.X + this.num.Width + 10,
                this.num.Location.Y);
            com.Location = new Point(buttonShow.Location.X + this.com.Width + 10,
                this.com.Location.Y);
            buttonShow.Click += new EventHandler(button1_Click);
            Controls.Add(num);
            Controls.Add(com);
            Controls.Add(buttonShow);
            numericUpDownList.Add(num);
            comboBoxList.Add(com);
            countButtons++;
            if (countButtons >= 5)
            {
                buttonShow.Visible = false;
            }
        }
    }
}

