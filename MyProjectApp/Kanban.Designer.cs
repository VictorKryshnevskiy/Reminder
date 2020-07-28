namespace MyProjectApp
{
    partial class Kanban
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
            this.doneListBox = new System.Windows.Forms.ListBox();
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.inProgressListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doneListBox
            // 
            this.doneListBox.FormattingEnabled = true;
            this.doneListBox.Location = new System.Drawing.Point(466, 108);
            this.doneListBox.Name = "doneListBox";
            this.doneListBox.Size = new System.Drawing.Size(173, 121);
            this.doneListBox.TabIndex = 2;
            // 
            // toDoListBox
            // 
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.Location = new System.Drawing.Point(29, 108);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(173, 121);
            this.toDoListBox.TabIndex = 3;
            // 
            // inProgressListBox
            // 
            this.inProgressListBox.FormattingEnabled = true;
            this.inProgressListBox.Location = new System.Drawing.Point(246, 108);
            this.inProgressListBox.Name = "inProgressListBox";
            this.inProgressListBox.Size = new System.Drawing.Size(173, 121);
            this.inProgressListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сделать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "В процессе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сделано";
            // 
            // Kanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inProgressListBox);
            this.Controls.Add(this.toDoListBox);
            this.Controls.Add(this.doneListBox);
            this.Name = "Kanban";
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.Kanban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox doneListBox;
        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.ListBox inProgressListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}