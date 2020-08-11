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
        List<Panel> panelList;
        NumericUpDown numeric;
        ComboBox comboBox;
        Button buttonShow;
        int countButtons = 1;
        IRemindRepository repository;
        int notificationPanelsCount = 1;
        public CreateReminderForm(Remind rem)
        {
            InitializeComponent();
            Remind = rem;
        }
        private void CreateReminderForm_Load(object sender, EventArgs e)
        {
            repository = new RemindFileRepository();
            SaveButtonClicked = false;
            notificationComboBox.Items
                .AddRange(new object[] {NotificationPeriod.Minutes, NotificationPeriod.Hours, NotificationPeriod.Days, "" });
            panelList = new List<Panel> {notificationPanel};
            numericUpDownList = new List<NumericUpDown> { notificationNumeric };
            comboBoxList = new List<ComboBox> { notificationComboBox };
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
            for (int i = 0; i < Remind.Notifications.Count; i++)
            {
                // по умолчанию на форме есть 1 panel
                if (i == 0)
                {
                    notificationNumeric.Value = Remind.Notifications[i].PeriodAmount;
                    notificationComboBox.SelectedItem = Remind.Notifications[i].Period;
                    continue;
                }
                if (notificationPanelsCount != Remind.Notifications.Count)
                {
                    AddPanel(); 
                    numeric.Value = Remind.Notifications[i].PeriodAmount;
                    comboBox.SelectedItem = Remind.Notifications[i].Period;
                    buttonShow.Visible = false;
                }
                
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
            if (!Validation.hasValidationErrors(Controls))
            {
                Remind.StartDate = startDateTimePicker.Value;
                Remind.Name = reminderNameTextBox.Text;
                Remind.EndDate = endDateTimePicker.Value;
                Remind.Description = reminderDescriptionTextBox.Text;
                Remind.Notifications = new List<Notification> { };
                for (int i = 0; i < panelList.Count; i++)
                {
                    if (comboBoxList[i].Text != "")
                    {
                        Remind.Notifications.Add(new Notification((int)numericUpDownList[i].Value, (NotificationPeriod)comboBoxList[i].SelectedItem));
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
                repository.Save(Remind);
                SaveButtonClicked = true;
                Close();
            }
            else
            {
                return;
            }
        }
        private void addNotificationbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Visible = false;
            AddPanel();
        }

        private void AddPanel()
        {
            
            var panel = new Panel
            {
                Size = notificationPanel.Size
            };
            numeric = new NumericUpDown();
            comboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            comboBox.Items.AddRange(new object[] { NotificationPeriod.Minutes, NotificationPeriod.Hours, NotificationPeriod.Days, "" });
            buttonShow = new Button
            {
                Text = "Добавить напоминание",
                Size = NotificationButton.Size
            };
            buttonShow.Location = new Point(NotificationButton.Location.X, NotificationButton.Location.Y);
            panel.Location = new Point(notificationPanel.Location.X + panel.Width * notificationPanelsCount,
                notificationPanel.Location.Y);
            numeric.Location = new Point(notificationNumeric.Location.X, notificationNumeric.Location.Y);
            comboBox.Location = new Point(notificationComboBox.Location.X, notificationComboBox.Location.Y);
            buttonShow.Click += new EventHandler(addNotificationbutton_Click);
            Controls.Add(panel);
            panel.Controls.Add(numeric);
            panel.Controls.Add(comboBox);
            panel.Controls.Add(buttonShow);
            panelList.Add(panel);
            numericUpDownList.Add(numeric);
            comboBoxList.Add(comboBox);
            countButtons++;
            if (countButtons >= 5)
            {
                buttonShow.Visible = false;
            }
            notificationPanelsCount++;
        }

        private void reminderNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (reminderNameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(reminderNameTextBox, "Введите имя события");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(reminderNameTextBox, "");
        }
    }
}

