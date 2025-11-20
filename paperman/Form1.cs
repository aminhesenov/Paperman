namespace paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Files (*.txt) | *.txt";
            op.ShowDialog();

            richTextBox1.Text = File.ReadAllText(op.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "All Files (*.*) | *.*";
            sd.FileName = "document";
            sd.ShowDialog();

            File.Create(sd.FileName).Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Files (*.*) | *.*";
            op.ShowDialog();

            DialogResult r = MessageBox.Show("Bu sənəd silinsinmi?", "Xəbərdarlıq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                File.Delete(op.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Files (*.txt) | *.txt";
            op.ShowDialog();

            File.WriteAllText(op.FileName, richTextBox1.Text);
        }
        int copy=0;
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog op= new SaveFileDialog();
            op.Filter = "All Files (*.*) | *.*";
            op.FileName = "document1";
            op.ShowDialog();
            copy++;
            File.Copy(op.FileName, op.FileName+"copy"+copy);
        }
    }
}
