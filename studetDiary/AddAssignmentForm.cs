using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace studetDiary
{
    public partial class AddAssignmentForm : Form
    {
        public Assignment CreatedAssignment { get; private set; }
        private int assignmentId;

        public AddAssignmentForm(int nextId)
        {
            InitializeComponent();

            assignmentId = nextId;

            comboBoxStatus.Items.Add(AssignmentStatus.Planned);
            comboBoxStatus.Items.Add(AssignmentStatus.InProgress);
            comboBoxStatus.Items.Add(AssignmentStatus.Completed);
            comboBoxStatus.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Введіть назву завдання");
                return;
            }

            if (textBoxTitle.Text.Length < 3)
            {
                MessageBox.Show("Назва повинна містити мінімум 3 символи");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("Введіть опис");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                MessageBox.Show("Введіть предмет");
                return;
            }

            
            if (dateTimePickerDeadline.Value < DateTime.Now)
            {
                MessageBox.Show("Дедлайн не може бути в минулому");
                return;
            }

            
            Subject subject = new Subject(assignmentId, textBoxSubject.Text);

            CreatedAssignment = new Assignment(
                assignmentId,
                textBoxTitle.Text,
                textBoxDescription.Text,
                subject,
                dateTimePickerDeadline.Value,
                (AssignmentStatus)comboBoxStatus.SelectedItem
            );
            var context = new ValidationContext(CreatedAssignment);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(CreatedAssignment, context, results, true))
            {
                string errors = string.Join("\n", results.Select(r => r.ErrorMessage));
                MessageBox.Show(errors);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        public AddAssignmentForm(Assignment assignment)
        {
            InitializeComponent();

            assignmentId = assignment.Id;

            textBoxTitle.Text = assignment.Title;
            textBoxDescription.Text = assignment.Description;
            textBoxSubject.Text = assignment.Subject.Name;
            dateTimePickerDeadline.Value = assignment.Deadline;

            comboBoxStatus.Items.Add(AssignmentStatus.Planned);
            comboBoxStatus.Items.Add(AssignmentStatus.InProgress);
            comboBoxStatus.Items.Add(AssignmentStatus.Completed);

            comboBoxStatus.SelectedItem = assignment.Status;
        }
    }
}