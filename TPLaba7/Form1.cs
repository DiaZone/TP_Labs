
namespace TP_Laba7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(fileDATA))
            {
                MessageBox.Show("Файл DATA.txt не найден", "Ошибка");
                ReadFromFileButton.Enabled = false;
            }
        }
        string fileDATA = @"DATA.txt";
        Dictionary<string, string> Summ = new Dictionary<string, string>();
        Dictionary<string, List<string>> Photos = new Dictionary<string, List<string>>();


        private void LoadPhotoButton_Click(object sender, EventArgs e)
        {
            var source = string.Empty;
            if (OpenPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                source = OpenPhotoDialog.FileName;
            }
            PhotoListBox.Items.Add(source);

            CheckErrors();
        }

        private void PhotoListBox_Click(object sender, EventArgs e)
        {
            try
            {
                PhotoPictureBox.Load(PhotoListBox.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Необходимо выбрать фотографию");
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            NameComboBox.Items.Add(NameComboBox.Text);
            Summ.Add(NameComboBox.Text, SumTextBox.Text);
            foreach (string z in PhotoListBox.Items)
            {
                result.Add(z);
            }
            Photos.Add(NameComboBox.Text, result);
            NameComboBox.Text = "";
            SumTextBox.Text = "";
            PhotoListBox.Items.Clear();
            SafeToFileButton.Enabled = true;
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhotoListBox.Items.Clear();
            SumTextBox.Text = Summ[NameComboBox.Text].ToString();
            foreach (string z in Photos[NameComboBox.Text])
            {
                PhotoListBox.Items.Add(z);
            }
            /*string filenames = Photos[NameComboBox.Text].ToString();
            string[] files = filenames.Split(new char[] { ' ' });
            for (int i = 0; i < files.Length; i++)
            {
                PhotoListBox.Items.Add(files[i]);
            }*/
        }

        private void SafeToFileButton_Click(object sender, EventArgs e)
        {
            String ResultString = String.Empty;
            foreach (String S in PhotoListBox.Items)
            {
                ResultString += S + " ";
            }
            if (NameComboBox.Text != "")
            {

                string source = NameComboBox.Text + " " + SumTextBox.Text + " " + ResultString;
                //foreach (var key in Summ.Keys)
                //{
                /*string source = key.ToString() + " " + Summ[key];
                foreach (string z in Photos[key])
                {
                    source += " " + z;
                }*/
                if (!checkBox1.Checked)
                {
                    using (StreamWriter writer = new StreamWriter(fileDATA, true))
                    {
                        writer.WriteLine(source);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(fileDATA))
                    {
                        writer.WriteLine(source);
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать ФИО");
            }
                //source = String.Empty;
            //}
            NameComboBox.Text = "";
            SumTextBox.Text = "";
            PhotoListBox.Items.Clear();
            PhotoPictureBox.Image = null;
            ReadFromFileButton.Enabled = true;
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            NameComboBox.Items.Clear();
            Summ.Clear();
            Photos.Clear();
            PhotoPictureBox.Image = null;
            int count = 0;
            using (StreamReader reader = new StreamReader(fileDATA))
            {
                try
                {
                    while (!reader.EndOfStream)
                    {
                        List<string> result = new List<string>();
                        string source = reader.ReadLine();
                        string[] temp = source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string FIO = "";
                        for (int i = 0; i <= 2; i++)
                        {
                            FIO += temp[i] + " ";
                        }
                        NameComboBox.Items.Add(FIO);
                        Summ.Add(FIO, temp[3]);
                        for (int i = 4; i < temp.Length; i++)
                        {
                            result.Add(temp[i]);
                        }
                        Photos.Add(FIO, result);
                        count++;
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Ошибка в файле. Проверьте на дубликат или перезапишите файл с нуля.", "Ошибка");
                }
            }
            CountLabel.Text = count.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameComboBox.Items.Clear();
            Summ.Clear();
            Photos.Clear();
            NameComboBox.Text = String.Empty;
            SumTextBox.Text = String.Empty;
            PhotoListBox.Items.Clear();
            PhotoPictureBox.Image = null;
            CountLabel.Text = 0.ToString();
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckErrors();
        }

        private void NameComboBox_TextChanged(object sender, EventArgs e)
        {
            CheckErrors();
        }

        private void CheckErrors()
        {
            if ((NameComboBox.Text == String.Empty) || (SumTextBox.Text == String.Empty) || (PhotoListBox.Items.Count == 0) || !double.TryParse(SumTextBox.Text, out var num))
            {
                AcceptButton.Enabled = false;
            }
            else
            {
                AcceptButton.Enabled = true;
            }
        }
    }
}