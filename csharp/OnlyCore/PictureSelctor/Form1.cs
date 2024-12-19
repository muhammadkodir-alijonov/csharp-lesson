namespace PictureSelctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                textBox1.Text = path;
                pictureBox1.Image = Image.FromFile(path);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}