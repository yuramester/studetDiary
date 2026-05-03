using System;
using System.Windows.Forms;
using System.Linq;

namespace studetDiary
{
    public partial class MainForm : Form
    {
        private AssignmentRepository repo = new AssignmentRepository();
        private int nextId = 1;

        public MainForm()
        {
            InitializeComponent();

            repo.LoadFromFile("data.json");
            RefreshAssignments();
            var list = repo.GetAll();
            if (list.Count > 0)
            {
                nextId = list.Max(a => a.Id) + 1;
            }

            RefreshAssignments();
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
                repo.SaveToFile("data.json");
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
            repo.SaveToFile("data.json");

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
                repo.SaveToFile("data.json");

                RefreshAssignments();
            }
        }
    }
}