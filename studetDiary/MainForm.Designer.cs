namespace studetDiary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddAssignment = new Button();
            label1 = new Label();
            listBoxAssignments = new ListBox();
            buttonDelete = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // buttonAddAssignment
            // 
            buttonAddAssignment.Font = new Font("Segoe UI", 10F);
            buttonAddAssignment.Location = new Point(627, 368);
            buttonAddAssignment.Name = "buttonAddAssignment";
            buttonAddAssignment.Size = new Size(131, 44);
            buttonAddAssignment.TabIndex = 0;
            buttonAddAssignment.Text = "Додати завдання";
            buttonAddAssignment.UseVisualStyleBackColor = true;
            buttonAddAssignment.Click += buttonAddAssignment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(302, 24);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 1;
            label1.Text = "Щоденник студента";
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.ItemHeight = 15;
            listBoxAssignments.Location = new Point(26, 75);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(551, 289);
            listBoxAssignments.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(26, 380);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(134, 380);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxAssignments);
            Controls.Add(label1);
            Controls.Add(buttonAddAssignment);
            Name = "MainForm";
            Text = "Щоденник студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddAssignment;
        private Label label1;
        private ListBox listBoxAssignments;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}
