using NucleusAPI;

namespace NucleusAPIExampleUI
{
    public partial class MainForm : Form
    {
        private Nucleus nucleus;

        public MainForm()
        {
            InitializeComponent();

            nucleus = new();
            nucleus.OnInjected += delegate
            {
                new Thread(() =>
                {
                    MessageBox.Show("Injected!", "Nucleus API Example UI");
                }).Start();
            };
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            nucleus.Execute(scriptEditor.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            scriptEditor.Clear();
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            nucleus.Inject();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            Text = "Nucleus API Example UI - " + (nucleus.IsInjected() ? "Injected" : "Not Injected");
        }
    }
}
