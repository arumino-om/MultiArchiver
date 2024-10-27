namespace MultiArchiver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openArchiveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ArchiveForm();
            form.Show(this);
        }
    }
}