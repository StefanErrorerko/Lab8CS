namespace Lab8CS
{
    public partial class Form1 : Form
    {
        private FileArray _fileArray;
        public Form1()
        {
            InitializeComponent();
            _fileArray = new FileArray();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxArrayGiven.Text = String.Empty;
            textBoxArrayExecuted.Text = String.Empty;
        }

        private void buttonSeek_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            textBoxFileName.Text = openFileDialog1.FileName;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            var fileName = textBoxFileName.Text;
            try
            {
                _fileArray.ReadArray(fileName);
                _fileArray.Show(textBoxArrayGiven);
            }
            catch(Exception ex)
            {
                textBoxFileName.Text = (ex.Message);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            _fileArray.DoSomething();
            _fileArray.Show(textBoxArrayExecuted);

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                _fileArray.WriteArray(openFileDialog1.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}