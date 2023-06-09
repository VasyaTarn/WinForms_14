namespace WinForms_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = Eng.FormName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = Uk.FormName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = Fr.FormName;
        }
    }
}