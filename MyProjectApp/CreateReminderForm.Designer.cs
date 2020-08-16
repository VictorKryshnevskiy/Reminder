namespace MyProjectApp
{
    partial class CreateReminderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderNameTextBox = new System.Windows.Forms.TextBox();
            this.reminderDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.notificationComboBox = new System.Windows.Forms.ComboBox();
            this.saveRemindButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDoReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.notificationNumeric = new System.Windows.Forms.NumericUpDown();
            this.inProgressReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doneReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.deleteNotificationbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.startCyclicalNotification = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cyclicalNotificationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cyclicalNotificationComboBox = new System.Windows.Forms.ComboBox();
            this.deleteCyclicalNotificationbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationNumeric)).BeginInit();
            this.notificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclicalNotificationNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата начала события";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата окончания события";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сделать";
            // 
            // reminderNameTextBox
            // 
            this.reminderNameTextBox.Location = new System.Drawing.Point(164, 52);
            this.reminderNameTextBox.Name = "reminderNameTextBox";
            this.reminderNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.reminderNameTextBox.TabIndex = 7;
            this.reminderNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.reminderNameTextBox_Validating);
            // 
            // reminderDescriptionTextBox
            // 
            this.reminderDescriptionTextBox.Location = new System.Drawing.Point(164, 132);
            this.reminderDescriptionTextBox.Name = "reminderDescriptionTextBox";
            this.reminderDescriptionTextBox.Size = new System.Drawing.Size(196, 20);
            this.reminderDescriptionTextBox.TabIndex = 8;
            // 
            // notificationComboBox
            // 
            this.notificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notificationComboBox.FormattingEnabled = true;
            this.notificationComboBox.Location = new System.Drawing.Point(0, 26);
            this.notificationComboBox.Name = "notificationComboBox";
            this.notificationComboBox.Size = new System.Drawing.Size(121, 21);
            this.notificationComboBox.TabIndex = 11;
            // 
            // saveRemindButton
            // 
            this.saveRemindButton.Location = new System.Drawing.Point(654, 378);
            this.saveRemindButton.Name = "saveRemindButton";
            this.saveRemindButton.Size = new System.Drawing.Size(120, 23);
            this.saveRemindButton.TabIndex = 13;
            this.saveRemindButton.Text = "Сохранить событие";
            this.saveRemindButton.UseVisualStyleBackColor = true;
            this.saveRemindButton.Click += new System.EventHandler(this.saveRemindButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm:ss";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(164, 12);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 14;
            this.startDateTimePicker.Value = new System.DateTime(2020, 8, 15, 14, 54, 59, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm:ss";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(164, 92);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 15;
            this.endDateTimePicker.Value = new System.DateTime(2020, 8, 15, 14, 54, 41, 0);
            // 
            // toDoReminderTasksRichTextBox
            // 
            this.toDoReminderTasksRichTextBox.Location = new System.Drawing.Point(7, 378);
            this.toDoReminderTasksRichTextBox.Name = "toDoReminderTasksRichTextBox";
            this.toDoReminderTasksRichTextBox.Size = new System.Drawing.Size(140, 96);
            this.toDoReminderTasksRichTextBox.TabIndex = 16;
            this.toDoReminderTasksRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Задачи";
            // 
            // notificationNumeric
            // 
            this.notificationNumeric.Location = new System.Drawing.Point(0, 0);
            this.notificationNumeric.Name = "notificationNumeric";
            this.notificationNumeric.Size = new System.Drawing.Size(120, 20);
            this.notificationNumeric.TabIndex = 19;
            // 
            // inProgressReminderTasksRichTextBox
            // 
            this.inProgressReminderTasksRichTextBox.Location = new System.Drawing.Point(166, 378);
            this.inProgressReminderTasksRichTextBox.Name = "inProgressReminderTasksRichTextBox";
            this.inProgressReminderTasksRichTextBox.Size = new System.Drawing.Size(140, 96);
            this.inProgressReminderTasksRichTextBox.TabIndex = 20;
            this.inProgressReminderTasksRichTextBox.Text = "";
            // 
            // doneReminderTasksRichTextBox
            // 
            this.doneReminderTasksRichTextBox.Location = new System.Drawing.Point(325, 378);
            this.doneReminderTasksRichTextBox.Name = "doneReminderTasksRichTextBox";
            this.doneReminderTasksRichTextBox.Size = new System.Drawing.Size(140, 96);
            this.doneReminderTasksRichTextBox.TabIndex = 21;
            this.doneReminderTasksRichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "В процессе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Сделано";
            // 
            // NotificationButton
            // 
            this.NotificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NotificationButton.Location = new System.Drawing.Point(3, 56);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(89, 43);
            this.NotificationButton.TabIndex = 25;
            this.NotificationButton.Text = "Добавить напоминание";
            this.NotificationButton.UseVisualStyleBackColor = false;
            this.NotificationButton.Click += new System.EventHandler(this.addNotificationbutton_Click);
            // 
            // notificationPanel
            // 
            this.notificationPanel.Controls.Add(this.deleteNotificationbutton);
            this.notificationPanel.Controls.Add(this.notificationNumeric);
            this.notificationPanel.Controls.Add(this.NotificationButton);
            this.notificationPanel.Controls.Add(this.notificationComboBox);
            this.notificationPanel.Location = new System.Drawing.Point(15, 162);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(137, 142);
            this.notificationPanel.TabIndex = 26;
            // 
            // deleteNotificationbutton
            // 
            this.deleteNotificationbutton.BackColor = System.Drawing.Color.Red;
            this.deleteNotificationbutton.Location = new System.Drawing.Point(3, 99);
            this.deleteNotificationbutton.Name = "deleteNotificationbutton";
            this.deleteNotificationbutton.Size = new System.Drawing.Size(89, 43);
            this.deleteNotificationbutton.TabIndex = 36;
            this.deleteNotificationbutton.Text = "Удалить напоминание";
            this.deleteNotificationbutton.UseVisualStyleBackColor = false;
            this.deleteNotificationbutton.Click += new System.EventHandler(this.deleteNotificationbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // startCyclicalNotification
            // 
            this.startCyclicalNotification.CustomFormat = "MMMMdd, yyyy  |  HH:mm:ss";
            this.startCyclicalNotification.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startCyclicalNotification.Location = new System.Drawing.Point(562, 38);
            this.startCyclicalNotification.Name = "startCyclicalNotification";
            this.startCyclicalNotification.Size = new System.Drawing.Size(191, 20);
            this.startCyclicalNotification.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Начало периода цикличных напоминаний";
            // 
            // cyclicalNotificationNumeric
            // 
            this.cyclicalNotificationNumeric.Location = new System.Drawing.Point(562, 93);
            this.cyclicalNotificationNumeric.Name = "cyclicalNotificationNumeric";
            this.cyclicalNotificationNumeric.Size = new System.Drawing.Size(120, 20);
            this.cyclicalNotificationNumeric.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Частота напоминаний";
            // 
            // cyclicalNotificationComboBox
            // 
            this.cyclicalNotificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cyclicalNotificationComboBox.FormattingEnabled = true;
            this.cyclicalNotificationComboBox.Location = new System.Drawing.Point(562, 124);
            this.cyclicalNotificationComboBox.Name = "cyclicalNotificationComboBox";
            this.cyclicalNotificationComboBox.Size = new System.Drawing.Size(121, 21);
            this.cyclicalNotificationComboBox.TabIndex = 34;
            // 
            // deleteCyclicalNotificationbutton
            // 
            this.deleteCyclicalNotificationbutton.Location = new System.Drawing.Point(715, 92);
            this.deleteCyclicalNotificationbutton.Name = "deleteCyclicalNotificationbutton";
            this.deleteCyclicalNotificationbutton.Size = new System.Drawing.Size(83, 55);
            this.deleteCyclicalNotificationbutton.TabIndex = 35;
            this.deleteCyclicalNotificationbutton.Text = "Удалить напоминание";
            this.deleteCyclicalNotificationbutton.UseVisualStyleBackColor = true;
            this.deleteCyclicalNotificationbutton.Click += new System.EventHandler(this.deleteCyclicalNotificationbutton_Click);
            // 
            // CreateReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(817, 489);
            this.Controls.Add(this.deleteCyclicalNotificationbutton);
            this.Controls.Add(this.cyclicalNotificationComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cyclicalNotificationNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startCyclicalNotification);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doneReminderTasksRichTextBox);
            this.Controls.Add(this.inProgressReminderTasksRichTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toDoReminderTasksRichTextBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.saveRemindButton);
            this.Controls.Add(this.reminderDescriptionTextBox);
            this.Controls.Add(this.reminderNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateReminderForm";
            this.Text = "CreateReminderFor";
            this.Load += new System.EventHandler(this.CreateReminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notificationNumeric)).EndInit();
            this.notificationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclicalNotificationNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reminderNameTextBox;
        private System.Windows.Forms.TextBox reminderDescriptionTextBox;
        private System.Windows.Forms.ComboBox notificationComboBox;
        private System.Windows.Forms.Button saveRemindButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.RichTextBox toDoReminderTasksRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown notificationNumeric;
        private System.Windows.Forms.RichTextBox inProgressReminderTasksRichTextBox;
        private System.Windows.Forms.RichTextBox doneReminderTasksRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button NotificationButton;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cyclicalNotificationComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown cyclicalNotificationNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startCyclicalNotification;
        private System.Windows.Forms.Button deleteCyclicalNotificationbutton;
        private System.Windows.Forms.Button deleteNotificationbutton;
    }
}