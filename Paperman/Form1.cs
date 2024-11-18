using System.IO;

namespace Paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save dialog
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files (*.*)|*.*";
            saveFile.ShowDialog();

            //Create file
            File.Create(saveFile.FileName).Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Open dialog           
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            openFile.ShowDialog();

            //Remove file
            File.Delete(openFile.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Save dialog
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files (*.*)|*.*";
            saveFile.FileName = ".docx";
            saveFile.ShowDialog();

            //Create file
            File.Create(saveFile.FileName).Close();
        }
        string path = string.Empty;
        string content = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";
            openFile.ShowDialog();

            //Path read
            path = openFile.FileName;

            //Content read
            content = File.ReadAllText(path);


            //Write richtext
            richTextBox1.Text = content;
        }
    }
}
