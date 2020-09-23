using System;
using ReminderClassLibrary;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace MyProjectApp
{
    public partial class CreateReminderForm : Form
    {
        public static bool SaveButtonClicked { get; private set; }
        public static Remind Remind { get; private set; }
        List<NumericUpDown> numericsUpDownList;
        List<ComboBox> comboBoxesList;
        List<Panel> panelsList;
        List<Button> buttonsToDeleteList;
        NumericUpDown numeric;
        ComboBox comboBox;
        Button buttonShow;
        Button deleteButton;
        int countButtons = 1;
        IRemindRepository repository;
        int notificationPanelsCount = 1;
        string button;
        public CreateReminderForm(Remind rem, string buttonName)
        {
            InitializeComponent();
            Remind = rem;
            button = buttonName;
        }
        private void CreateReminderForm_Load(object sender, EventArgs e)
        {
            repository = new RemindDataBaseRepository();
            SaveButtonClicked = false;
            FillComboBox(notificationComboBox);
            FillComboBox(cyclicalNotificationComboBox);
            panelsList = new List<Panel> { notificationPanel };
            numericsUpDownList = new List<NumericUpDown> { notificationNumeric };
            comboBoxesList = new List<ComboBox> { notificationComboBox };
            buttonsToDeleteList = new List<Button> { deleteNotificationbutton };
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
            if (Remind.Notifications != null)
            {
                for (int i = 0; i < Remind.Notifications.Count; i++)
                {
                    // по умолчанию на форме есть 1 panel
                    if (i == 0)
                    {
                        notificationNumeric.Value = Remind.Notifications[i].PeriodAmount;
                        notificationComboBox.SelectedValue = Remind.Notifications[i].Period;
                        continue;
                    }
                    if (notificationPanelsCount != Remind.Notifications.Count)
                    {
                        AddPanel();
                        numeric.Value = Remind.Notifications[i].PeriodAmount;
                        comboBox.SelectedValue = Remind.Notifications[i].Period;
                        buttonShow.Visible = false;
                    }
                }
            }
            if (Remind.TasksList != null)
            {
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
            if (Remind.CyclicalNotification != null)
            {
                startCyclicalNotification.Value = Remind.CyclicalNotification.Start;
                cyclicalNotificationNumeric.Value = Remind.CyclicalNotification.PeriodAmount;
                cyclicalNotificationComboBox.SelectedValue = Remind.CyclicalNotification.Period;
            }
        }
        private void saveRemindButton_Click(object sender, EventArgs e)
        {
            if (Validation.HasValidationErrors(Controls))
            {
                return;
            }
            try
            {
                Remind.StartDate = startDateTimePicker.Value;
            Remind.Name = reminderNameTextBox.Text;
            Remind.EndDate = endDateTimePicker.Value;
            Remind.Description = reminderDescriptionTextBox.Text;
            if (button == "save")
            {
                Remind.Notifications = new List<Notification> { };
                for (int i = 0; i < panelsList.Count; i++)
                {
                    if (comboBoxesList[i].Text != "")
                    {
                        Remind.Notifications.Add(new Notification((int)numericsUpDownList[i].Value,
                            (NotificationPeriod)comboBoxesList[i].SelectedValue));
                    }
                }
                SaveCyclicalNotification();
                var remindTasks = toDoReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x, TaskStatus.ToDo)).ToList();
                remindTasks.AddRange(inProgressReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x, TaskStatus.InProgress)).ToList());
                remindTasks.AddRange(doneReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x, TaskStatus.Done)).ToList());
                Remind.TasksList = new List<RemindTask>();
                foreach (var task in remindTasks)
                {
                    Remind.TasksList.Add(new RemindTask(task.Text, task.Status));
                }
                repository.Save(Remind);
            }
            if (button == "update")
            {
                for (int i = 0; i < comboBoxesList.Count; i++)
                {
                    if (comboBoxesList[i].Text != "")
                    {
                        if (Remind.Notifications.Count > i)
                        {
                            Remind.Notifications[i].Period = (NotificationPeriod)comboBoxesList[i].SelectedValue;
                            Remind.Notifications[i].PeriodAmount = (int)numericsUpDownList[i].Value;
                        }
                        else
                        {
                            if (Remind.Notifications.Count <= i)
                            {
                                Remind.Notifications.Add(new Notification((int)numericsUpDownList[i].Value,
                                    (NotificationPeriod)comboBoxesList[i].SelectedValue));
                            }
                        }
                    }
                    else
                    {
                        if (Remind.Notifications.Count > 0)
                        {
                            Remind.Notifications[i].Period = NotificationPeriod.None;
                        }
                    }
                }
                SaveCyclicalNotification();
                Remind.TasksList = toDoReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x)).ToList();
                Remind.TasksList.AddRange(inProgressReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new RemindTask(x, TaskStatus.InProgress)).ToList());
                Remind.TasksList.AddRange(doneReminderTasksRichTextBox.Text.Split(new string[] { "\n" }
                    , StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => new RemindTask(x, TaskStatus.Done)).ToList());
                repository.Update(Remind);
            }
            SaveButtonClicked = true;
            Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void SaveCyclicalNotification()
        {
            if (cyclicalNotificationComboBox.Text != "")
            {
                if (Remind.CyclicalNotification == null)
                { Remind.CyclicalNotification = new CyclicalNotifications(); }
                Remind.CyclicalNotification.Start = startCyclicalNotification.Value;
                Remind.CyclicalNotification.End = endDateTimePicker.Value;
                Remind.CyclicalNotification.PeriodAmount = (int)cyclicalNotificationNumeric.Value;
                Remind.CyclicalNotification.Period = (NotificationPeriod)cyclicalNotificationComboBox.SelectedValue;
                Remind.CyclicalNotification.CountDate = startCyclicalNotification.Value;
            }
            else
            {
                Remind.CyclicalNotification = null;
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
            FillComboBox(comboBox);
            buttonShow = new Button
            {
                Text = "Добавить напоминание",
                Size = NotificationButton.Size,
                BackColor = Color.Green
            };
            deleteButton = new Button
            {
                Text = "Удалить напоминание",
                Size = deleteNotificationbutton.Size,
                BackColor = Color.Red
            };
            buttonShow.Location = new Point(NotificationButton.Location.X, NotificationButton.Location.Y);
            numeric.Location = new Point(notificationNumeric.Location.X, notificationNumeric.Location.Y);
            comboBox.Location = new Point(notificationComboBox.Location.X, notificationComboBox.Location.Y);
            deleteButton.Location = new Point(deleteNotificationbutton.Location.X, deleteNotificationbutton.Location.Y);
            buttonShow.Click += new EventHandler(addNotificationbutton_Click);
            Controls.Add(panel);
            panel.Controls.Add(numeric);
            panel.Controls.Add(comboBox);
            panel.Controls.Add(buttonShow);
            panel.Controls.Add(deleteButton);
            panelsList.Add(panel);
            deleteButton.Click += new EventHandler(deleteButton_Click);
            numericsUpDownList.Add(numeric);
            comboBoxesList.Add(comboBox);
            buttonsToDeleteList.Add(deleteButton);
            countButtons++;
            if (countButtons >= 5)
            {
                buttonShow.Visible = false;
            }
            notificationPanelsCount++;
            notificationsTableLayoutPanel.Controls.Add(panel);
        }
        private void reminderNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (reminderNameTextBox.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(reminderNameTextBox, "Введите имя события");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(reminderNameTextBox, "");
        }
        private void deleteCyclicalNotificationbutton_Click(object sender, EventArgs e)
        {
            cyclicalNotificationNumeric.Value = default;
            cyclicalNotificationComboBox.SelectedValue = NotificationPeriod.None;
        }

        private void deleteNotificationbutton_Click(object sender, EventArgs e)
        {
            notificationNumeric.Value = default;
            notificationComboBox.SelectedValue = NotificationPeriod.None;

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var selectedPanel = button.Parent;
            for (int i = 0; i < selectedPanel.Controls.Count; i++)
            {
                if (selectedPanel.Controls[i] is ComboBox)
                {
                    selectedPanel.Controls[i].Text = "";
                }
                if (selectedPanel.Controls[i] is NumericUpDown)
                {
                    selectedPanel.Controls[i].Text = "0";
                }
            }
            var panelIndex = panelsList.IndexOf((Panel)selectedPanel);
            notificationsTableLayoutPanel.Controls.RemoveAt(panelIndex);
            panelsList.RemoveAt(panelIndex);
            countButtons--;
            notificationPanelsCount--;
            NotificationButton.Visible = true;
        }
        private void FillComboBox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = Enum.GetValues(typeof(NotificationPeriod)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            })
             .OrderBy(item => item.value)
             .ToList();
        }
    }
}

