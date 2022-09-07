namespace DateiSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSchreiben_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("aus.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtInput.Text);
            sw.Close();
        }
    }
}