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
        public CreateReminderForm()
        {
            InitializeComponent();
        }

        private void CreateReminderForm_Load(object sender, EventArgs e)
        {

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
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите имя события");
            }
        }
    }
}
