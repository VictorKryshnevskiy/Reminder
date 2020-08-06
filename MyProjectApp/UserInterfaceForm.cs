using System;
using ReminderClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace MyProjectApp
{
    public partial class UserInterfaceForm : Form
    {
        PopupNotifier popup;
        List<Remind> remindersList;
        RemindRepository repository;
        public UserInterfaceForm()
        {
            InitializeComponent();
        }
        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            repository = new RemindRepository();
            if (FileSystem.IsExist("Reminder.json"))
            {
                WriteRemindsToGrid();
            }
        }
        private void Remind_RemindDateEnd(object sender, RemindEventArgs e)
        {
            popup = new PopupNotifier
            {
                Image = Properties.Resources.pictureReminder,
                ImageSize = new System.Drawing.Size(100, 100),
                TitleText = e.Remind.Name,
                ContentText = "Look at this remind! Its outdated!"
            };
            popup.Popup();
        }
        private void createReminderButton_Click(object sender, EventArgs e)
        {
            Form form = new CreateReminderForm(new Remind(default));
            form.ShowDialog();
            UpdateGrid();
        }
        private void deleteReminderButton_Click(object sender, EventArgs e)
        {
            var indexToDelete = reminderDataGridView.CurrentRow.Index;
            if (indexToDelete < remindersList.Count)
            {
                var listElementToDelete = FindIndexInArray(indexToDelete);
                remindersList.RemoveAt(listElementToDelete);
                reminderDataGridView.Rows.RemoveAt(indexToDelete);
                repository.Save(remindersList);
            }
            else { MessageBox.Show("Пожалуйста, выберите строку корректно"); }
        }
        private void editReminderButton_Click(object sender, EventArgs e)
        {
            var indexToEdit = reminderDataGridView.CurrentRow.Index;
            if (indexToEdit < remindersList.Count)
            {
                var listElementToEdit = FindIndexInArray(indexToEdit);
                var remindToEdit = remindersList.ElementAt(listElementToEdit);
                Form form = new CreateReminderForm(remindToEdit);
                form.ShowDialog();
                if (CreateReminderForm.SaveButtonClicked)
                {
                    remindersList.RemoveAt(listElementToEdit);
                    reminderDataGridView.Rows.RemoveAt(indexToEdit);
                    remindersList.Insert(listElementToEdit, CreateReminderForm.Remind);
                    repository.Save(remindersList);
                    UpdateGrid();
                }
            }
            else { MessageBox.Show("Пожалуйста, выберите строку корректно"); }
        }
        private int FindIndexInArray(int indexInTable)
        {
            return remindersList.FindIndex(x => x.GetGuid.ToString() == reminderDataGridView[guidColumn.Index, indexInTable]
            .Value.ToString());
        }
        private void WriteRemindsToGrid()
        {
            remindersList = repository.GetRemind();
            foreach (var remind in remindersList)
            {
                reminderDataGridView.Rows.Add(remind.StartDate, remind.Name, remind.EndDate,
                    remind.Description, remind.GetGuid);
                remind.RemindDateEnd += Remind_RemindDateEnd;
            }
        }
        private void UpdateGrid()
        {
            reminderDataGridView.Rows.Clear();
            WriteRemindsToGrid();
        }
        private void reminderDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < remindersList.Count)
            {
                var remindIndex = FindIndexInArray(e.RowIndex);
                var form = new Kanban(remindersList[remindIndex]);
                form.ShowDialog();
                remindersList.RemoveAt(remindIndex);
                reminderDataGridView.Rows.RemoveAt(e.RowIndex);
                remindersList.Insert(remindIndex, Kanban.Remind);
                repository.Save(remindersList);
                UpdateGrid();
            }
        }
    }
}
