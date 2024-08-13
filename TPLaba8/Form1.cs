namespace TPLaba8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string datafile = @"data.txt";



        private void GetDataButton_Click(object sender, EventArgs e)
        {
            SetItems();
        }

        private double[,] ReadFile()
        {
            DataListBox.Items.Clear();
            string temp;
            double[,] dataArr = {};
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader DataReader = new StreamReader(datafile))
                {
                    while ((temp = DataReader.ReadLine()) != null) // считываем файл с информацией о программе построчно
                    {
                        lines.Add(temp);
                    }
                }
                string[] data = lines[0].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dataArr = new double[lines.Count, data.Length]; // создаем массив размером с таблицу
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] tempData = lines[i].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < tempData.Length; j++)
                    {
                        dataArr[i, j] = Convert.ToDouble(tempData[j]);
                    }

                }
                int maximum = dataArr.GetLength(1);
                NumericUpDown.Maximum = maximum;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден", "Ошибка");
                Application.Exit();
            }
            return dataArr;
        }

        private void SetItems()
        {
            double[,] dataArr = ReadFile();
            int column = Convert.ToInt32(NumericUpDown.Value) - 1;
            for (int i = 0; i < dataArr.GetLength(0); i++)
            {
                DataListBox.Items.Add(dataArr[i, column]);
            }
        }

        private void Filter()
        {
            FilterTextBox.Text = "";
            IEnumerable<double> filterdata;
            IEnumerable<double> filter1data;
            IEnumerable<double> filter2data;
            double[] data = new double[DataListBox.Items.Count];
            for (int i = 0; i < DataListBox.Items.Count; i++)
            {
                data[i] = Convert.ToDouble(DataListBox.Items[i]);
            }
            if (CheckBox2.Checked)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    FilterTextBox.Text += data[i] + " ";
                }
            }

            if (!СheckBox1.Checked)
            {
                filterdata =
                    from datas in data
                    where datas != 0
                    select datas;
            }
            else
            {
                filterdata =
                    from datas in data
                    select datas;
            }

            if (RadioButton1_1.Checked)
            {
                filter1data =
                   from datas in filterdata
                   where datas % 1 == 0
                   select datas;
            }
            else
            {
                filter1data =
                   from datas in filterdata
                   where datas % 1 != 0
                   select datas;
            }

            if (RadioButton2_1.Checked)
            {
                filter2data =
                    from datas in filter1data
                    where datas >= 0
                    select datas;
            }
            else
            {
                filter2data =
                    from datas in filter1data
                    where datas <= 0
                    select datas;
            }
            foreach(var row in filter2data)
            {
                FilterTextBox.Text += row + " ";
            }
            if (FilterTextBox.Text == String.Empty)
            {
                FilterTextBox.Text = "Таких значений нет";
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                RadioButton1_1.Checked = false;
                RadioButton1_1.Enabled = false;
                RadioButton1_2.Checked = false;
                RadioButton1_2.Enabled = false;
                RadioButton2_1.Checked = false;
                RadioButton2_1.Enabled = false;
                RadioButton2_2.Checked = false;
                RadioButton2_2.Enabled = false;
                СheckBox1.Enabled = false;
            }
            else
            {
                RadioButton1_1.Enabled = true;
                RadioButton1_1.Checked = true;
                RadioButton1_2.Enabled = true;
                RadioButton2_1.Enabled = true;
                RadioButton2_1.Checked = true;
                RadioButton2_2.Enabled = true;
                СheckBox1.Enabled = true;
            }
        }

        private void RedButton1_Click(object sender, EventArgs e)
        {
            FilterTextBox.BackColor = Color.Red;
        }

        private void YellowButton1_Click(object sender, EventArgs e)
        {
            FilterTextBox.BackColor = Color.Yellow;
        }

        private void GreenButton1_Click(object sender, EventArgs e)
        {
            FilterTextBox.BackColor = Color.Green;
        }

        private void RedButton2_Click(object sender, EventArgs e)
        {
            FilterTextBox.ForeColor = Color.Red;
        }

        private void YellowButton2_Click(object sender, EventArgs e)
        {
            FilterTextBox.ForeColor = Color.Yellow;
        }

        private void GreenButton2_Click(object sender, EventArgs e)
        {
            FilterTextBox.ForeColor = Color.Green;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Filter();
        }

    }
}