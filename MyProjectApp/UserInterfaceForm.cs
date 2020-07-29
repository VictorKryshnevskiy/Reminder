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
        public UserInterfaceForm()
        {
            InitializeComponent();
        }
        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            if (FileSystem.IsExist("Reminder.json"))
            {
                WriteRemindsToGrid();
            }
            PopupLoad();
        }

        private void PopupLoad()
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.pictureReminder;
            popup.ImageSize = new System.Drawing.Size(100, 100);
            popup.TitleText = "Reminder";
            popup.ContentText = "Look at this remind!";

        }

        private void createReminderButton_Click(object sender, EventArgs e)
        {
            Form form = new CreateReminderForm(new Remind());
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
                FileSystem.SaveRemind(remindersList);
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
                    FileSystem.SaveRemind(remindersList);
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
            remindersList = FileSystem.GetRemind();
            foreach (var remind in remindersList)
            {
                reminderDataGridView.Rows.Add(remind.StartDate, remind.Name, remind.EndDate,
                    remind.Description, remind.GetGuid);
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
                FileSystem.SaveRemind(remindersList);
                UpdateGrid();
            }
          
        }

        private void sendNotificationButton_Click(object sender, EventArgs e)
        {
            popup.Popup();
        }
    }
}
