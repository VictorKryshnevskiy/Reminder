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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderNameTextBox = new System.Windows.Forms.TextBox();
            this.reminderDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.com = new System.Windows.Forms.ComboBox();
            this.saveRemindButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDoReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.inProgressReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doneReminderTasksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата окончания события";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сделать";
            // 
            // reminderNameTextBox
            // 
            this.reminderNameTextBox.Location = new System.Drawing.Point(164, 53);
            this.reminderNameTextBox.Name = "reminderNameTextBox";
            this.reminderNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.reminderNameTextBox.TabIndex = 7;
            // 
            // reminderDescriptionTextBox
            // 
            this.reminderDescriptionTextBox.Location = new System.Drawing.Point(164, 133);
            this.reminderDescriptionTextBox.Name = "reminderDescriptionTextBox";
            this.reminderDescriptionTextBox.Size = new System.Drawing.Size(196, 20);
            this.reminderDescriptionTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Когда напомнить";
            // 
            // timeBeforeRemindComboBox
            // 
            this.com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com.FormattingEnabled = true;
            this.com.Location = new System.Drawing.Point(114, 188);
            this.com.Name = "timeBeforeRemindComboBox";
            this.com.Size = new System.Drawing.Size(121, 21);
            this.com.TabIndex = 11;
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
            this.startDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(164, 12);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 14;
            this.startDateTimePicker.Value = new System.DateTime(2020, 7, 15, 19, 49, 11, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(164, 93);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 15;
            this.endDateTimePicker.Value = new System.DateTime(2020, 7, 15, 19, 49, 50, 0);
            // 
            // toDoReminderTasksRichTextBox
            // 
            this.toDoReminderTasksRichTextBox.Location = new System.Drawing.Point(15, 342);
            this.toDoReminderTasksRichTextBox.Name = "toDoReminderTasksRichTextBox";
            this.toDoReminderTasksRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.toDoReminderTasksRichTextBox.TabIndex = 16;
            this.toDoReminderTasksRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Задачи";
            // 
            // timeBeforeRemindnumericUpDown
            // 
            this.num.Location = new System.Drawing.Point(114, 162);
            this.num.Name = "timeBeforeRemindnumericUpDown";
            this.num.Size = new System.Drawing.Size(120, 20);
            this.num.TabIndex = 19;
            // 
            // inProgressReminderTasksRichTextBox
            // 
            this.inProgressReminderTasksRichTextBox.Location = new System.Drawing.Point(183, 342);
            this.inProgressReminderTasksRichTextBox.Name = "inProgressReminderTasksRichTextBox";
            this.inProgressReminderTasksRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.inProgressReminderTasksRichTextBox.TabIndex = 20;
            this.inProgressReminderTasksRichTextBox.Text = "";
            // 
            // doneReminderTasksRichTextBox
            // 
            this.doneReminderTasksRichTextBox.Location = new System.Drawing.Point(353, 342);
            this.doneReminderTasksRichTextBox.Name = "doneReminderTasksRichTextBox";
            this.doneReminderTasksRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.doneReminderTasksRichTextBox.TabIndex = 21;
            this.doneReminderTasksRichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "В процессе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Сделано";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить напоминание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.com);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doneReminderTasksRichTextBox);
            this.Controls.Add(this.inProgressReminderTasksRichTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toDoReminderTasksRichTextBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.saveRemindButton);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com;
        private System.Windows.Forms.Button saveRemindButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.RichTextBox toDoReminderTasksRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.RichTextBox inProgressReminderTasksRichTextBox;
        private System.Windows.Forms.RichTextBox doneReminderTasksRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}