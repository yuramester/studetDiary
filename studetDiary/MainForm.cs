using System;
using System.Windows.Forms;

namespace studetDiary
{
    public partial class MainForm : Form
    {
        private AssignmentRepository repo = new AssignmentRepository();
        private int nextId = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshAssignments()
        {
            listBoxAssignments.Items.Clear();

            foreach (var assignment in repo.GetAll())
            {
                listBoxAssignments.Items.Add(assignment.GetInfo());
            }
        }

        private void buttonAddAssignment_Click(object sender, EventArgs e)
        {
            AddAssignmentForm form = new AddAssignmentForm(nextId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.Add(form.CreatedAssignment);
                nextId++;
                RefreshAssignments();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAssignments.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть завдання");
                return;
            }

            repo.Remove(listBoxAssignments.SelectedIndex + 1);

            RefreshAssignments();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxAssignments.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть завдання");
                return;
            }

            int index = listBoxAssignments.SelectedIndex;

            var assignment = repo.GetAll()[index];

            AddAssignmentForm form = new AddAssignmentForm(assignment);

            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.Remove(assignment.Id);
                repo.Add(form.CreatedAssignment);

                RefreshAssignments();
            }
        }
    }
}