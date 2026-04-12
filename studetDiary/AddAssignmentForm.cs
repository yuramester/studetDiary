using System;
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
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                string.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
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