namespace CSharp_WinF_L1
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void TextChange(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Нажали!")
            {
                (sender as Button).Text = "Next";

            }
            else
            {
                (sender as Button).Text = "Нажали!";
            }
            //txtTest1.Text += (sender as Button).Name + Environment.NewLine;
            if (chBox1.Checked)
            {
                txtTest1.Text += (sender as Button).Name + Environment.NewLine;
            }
            else
            {
                txtTest1.Text += (sender as Button).Text + Environment.NewLine;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void chBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        string fileName;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            { fileName = openFileDialog1.FileName; }
            txtTest1.Text += fileName + Environment.NewLine;
            StreamReader sr = new StreamReader(fileName);
            while(!sr.EndOfStream)
            {
                txtTest1.Text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
        }
    }
}
