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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
            this.reminderDataGridView = new System.Windows.Forms.DataGridView();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createReminderButton = new System.Windows.Forms.Button();
            this.editReminderButton = new System.Windows.Forms.Button();
            this.deleteReminderButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).BeginInit();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminderDataGridView
            // 
            this.reminderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reminderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateColumn,
            this.nameColumn,
            this.endDateColumn,
            this.descriptionColumn,
            this.guidColumn});
            this.reminderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.reminderDataGridView.Name = "reminderDataGridView";
            this.reminderDataGridView.ReadOnly = true;
            this.reminderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reminderDataGridView.Size = new System.Drawing.Size(677, 430);
            this.reminderDataGridView.TabIndex = 0;
            this.reminderDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reminderDataGridView_CellDoubleClick);
            // 
            // startDateColumn
            // 
            this.startDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.startDateColumn.HeaderText = "Дата начала события";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.ReadOnly = true;
            this.startDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startDateColumn.Width = 130;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nameColumn.HeaderText = "Имя события";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 92;
            // 
            // endDateColumn
            // 
            this.endDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.endDateColumn.HeaderText = "Дата окончания события";
            this.endDateColumn.Name = "endDateColumn";
            this.endDateColumn.ReadOnly = true;
            this.endDateColumn.Width = 107;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionColumn.HeaderText = "Описание события";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            // 
            // guidColumn
            // 
            this.guidColumn.HeaderText = "Guid";
            this.guidColumn.Name = "guidColumn";
            this.guidColumn.ReadOnly = true;
            this.guidColumn.Visible = false;
            // 
            // createReminderButton
            // 
            this.createReminderButton.Location = new System.Drawing.Point(3, 3);
            this.createReminderButton.Name = "createReminderButton";
            this.createReminderButton.Size = new System.Drawing.Size(94, 41);
            this.createReminderButton.TabIndex = 1;
            this.createReminderButton.Text = "Создать событие";
            this.createReminderButton.UseVisualStyleBackColor = true;
            this.createReminderButton.Click += new System.EventHandler(this.createReminderButton_Click);
            // 
            // editReminderButton
            // 
            this.editReminderButton.Location = new System.Drawing.Point(3, 58);
            this.editReminderButton.Name = "editReminderButton";
            this.editReminderButton.Size = new System.Drawing.Size(94, 39);
            this.editReminderButton.TabIndex = 2;
            this.editReminderButton.Text = "Редактировать событие";
            this.editReminderButton.UseVisualStyleBackColor = true;
            this.editReminderButton.Click += new System.EventHandler(this.editReminderButton_Click);
            // 
            // deleteReminderButton
            // 
            this.deleteReminderButton.Location = new System.Drawing.Point(3, 105);
            this.deleteReminderButton.Name = "deleteReminderButton";
            this.deleteReminderButton.Size = new System.Drawing.Size(92, 34);
            this.deleteReminderButton.TabIndex = 3;
            this.deleteReminderButton.Text = "Удалить событие";
            this.deleteReminderButton.UseVisualStyleBackColor = true;
            this.deleteReminderButton.Click += new System.EventHandler(this.deleteReminderButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Reminder";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.notifyIconContextMenuStrip.Name = "contextMenuStrip1";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Restore";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.Controls.Add(this.editReminderButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteReminderButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.createReminderButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(707, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 454);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reminderDataGridView);
            this.Name = "UserInterfaceForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterfaceForm_FormClosing);
            this.Load += new System.EventHandler(this.UserInterfaceForm_Load);
            this.Resize += new System.EventHandler(this.UserInterfaceForm_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).EndInit();
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn guidColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

