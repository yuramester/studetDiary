namespace studetDiary
{
    partial class AddAssignmentForm
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
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxDescription = new TextBox();
            textBoxSubject = new TextBox();
            textBoxTitle = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(345, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "завдання";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 285);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "статус ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 218);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 150);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "предмет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 89);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 5;
            label5.Text = "опис";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(33, 107);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(100, 23);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(33, 168);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(100, 23);
            textBoxSubject.TabIndex = 7;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(33, 46);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(33, 236);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(200, 23);
            dateTimePickerDeadline.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(33, 303);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 10;
            // 
            // AddAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Name = "AddAssignmentForm";
            Text = "AddAssignmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxDescription;
        private TextBox textBoxSubject;
        private TextBox textBoxTitle;
        private DateTimePicker dateTimePickerDeadline;
        private ComboBox comboBoxStatus;
    }
}