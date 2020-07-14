using System;
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
            Close();
        }
    }
}
