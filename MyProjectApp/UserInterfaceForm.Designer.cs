namespace MyProjectApp
{
    partial class UserInterfaceForm
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
            this.reminderDataGridView = new System.Windows.Forms.DataGridView();
            this.createReminderButton = new System.Windows.Forms.Button();
            this.editReminderButton = new System.Windows.Forms.Button();
            this.deleteReminderButton = new System.Windows.Forms.Button();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reminderDataGridView
            // 
            this.reminderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reminderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateColumn,
            this.nameColumn,
            this.endDateColumn,
            this.descriptionColumn,
            this.tasksColumn});
            this.reminderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.reminderDataGridView.Name = "reminderDataGridView";
            this.reminderDataGridView.Size = new System.Drawing.Size(631, 426);
            this.reminderDataGridView.TabIndex = 0;
            // 
            // createReminderButton
            // 
            this.createReminderButton.Location = new System.Drawing.Point(649, 12);
            this.createReminderButton.Name = "createReminderButton";
            this.createReminderButton.Size = new System.Drawing.Size(139, 23);
            this.createReminderButton.TabIndex = 1;
            this.createReminderButton.Text = "Создать событие";
            this.createReminderButton.UseVisualStyleBackColor = true;
            this.createReminderButton.Click += new System.EventHandler(this.createReminderButton_Click);
            // 
            // editReminderButton
            // 
            this.editReminderButton.Location = new System.Drawing.Point(649, 54);
            this.editReminderButton.Name = "editReminderButton";
            this.editReminderButton.Size = new System.Drawing.Size(139, 23);
            this.editReminderButton.TabIndex = 2;
            this.editReminderButton.Text = "Редактировать событие";
            this.editReminderButton.UseVisualStyleBackColor = true;
            // 
            // deleteReminderButton
            // 
            this.deleteReminderButton.Location = new System.Drawing.Point(649, 94);
            this.deleteReminderButton.Name = "deleteReminderButton";
            this.deleteReminderButton.Size = new System.Drawing.Size(139, 23);
            this.deleteReminderButton.TabIndex = 3;
            this.deleteReminderButton.Text = "Удалить событие";
            this.deleteReminderButton.UseVisualStyleBackColor = true;
            // 
            // startDateColumn
            // 
            this.startDateColumn.HeaderText = "Дата начала события";
            this.startDateColumn.Name = "startDateColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя события";
            this.nameColumn.Name = "nameColumn";
            // 
            // endDateColumn
            // 
            this.endDateColumn.HeaderText = "Дата окончания события";
            this.endDateColumn.Name = "endDateColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Описание события";
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // tasksColumn
            // 
            this.tasksColumn.HeaderText = "Задачи";
            this.tasksColumn.Name = "tasksColumn";
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteReminderButton);
            this.Controls.Add(this.editReminderButton);
            this.Controls.Add(this.createReminderButton);
            this.Controls.Add(this.reminderDataGridView);
            this.Name = "UserInterfaceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reminderDataGridView;
        private System.Windows.Forms.Button createReminderButton;
        private System.Windows.Forms.Button editReminderButton;
        private System.Windows.Forms.Button deleteReminderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasksColumn;
    }
}

