namespace studetDiary
{
    public partial class MainForm : Form
    {
        public MainForm()
{
    InitializeComponent();

    Subject subject = new Subject(1, "Програмування");

    Assignment assignment = new Assignment(
        1,
        "Практична №2",
        "Реалізувати класи",
        subject,
        DateTime.Now.AddDays(5),
        AssignmentStatus.Planned
    );

    AssignmentManager manager = new AssignmentManager();
    manager.AddAssignment(assignment);

    MessageBox.Show(manager.Assignments[0].GetInfo());
}
    }
}
