using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nameprog = "TP5, Вариант 14";
        string func = "x^(1/2)/log(y)";
        
        private void NumTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //Отображение полей ввода для нужного количество наборов
            GroupBox[] _NBGroupBox = new GroupBox[] { N1GroupBox, N2GroupBox, N3GroupBox, N4GroupBox, N5GroupBox };
            for (int i = 0; i <_NBGroupBox.Length; i++)
            {
                _NBGroupBox[i].Visible = false;
            }
            NumLabel.Text = NumTrackBar.Value.ToString();
            for(int i = 0; i < NumTrackBar.Value; i++)
            {
                _NBGroupBox[i].Visible = true;
            }
        }
        private static double Myfunc(double x, double y)
        {
            // возвращаем требуемую функцию
            return (Math.Sqrt(x) / Math.Log(y));
        }

        private void DataSet()
        {
            DateTime dateTime = DateTime.Now;
            string filename;
            string myProgram = @"myProgram.log";
            File.WriteAllText(myProgram, string.Empty); // предварительно очищаем файл
            StreamWriter myProgwriter = new StreamWriter(myProgram, true);
            myProgwriter.WriteLine("Название программы: " + nameprog);
            myProgwriter.WriteLine("Начало работы: " + dateTime);
            myProgwriter.WriteLine("Функция: " + func);
            string myErrors = @"myErrors.log";
            File.WriteAllText(myErrors, string.Empty); // предварительно очищаем файл
            StreamWriter myErrorswriter = new StreamWriter(myErrors, true);
            TextBox[,] tb = new TextBox[4, 5] { { Nx1TB, Nx2TB, Nx3TB, Nx4TB, Nx5TB },
                                                { Ny1TB, Ny2TB, Ny3TB, Ny4TB, Ny5TB },
                                                { Hy1TB, Hy2TB, Hy3TB, Hy4TB, Hy5TB },
                                                { Y01TB, Y02TB, Y03TB, Y04TB, Y05TB }};
            Random rand = new Random();
            MonitorListBox.Items.Clear();
            for (int z = 0; z < NumTrackBar.Value; z++)
            {
                filename = "G" + (z + 1) + ".dat"; // название файла с таблицой значений
                try
                {
                    double[] x = new double[Convert.ToInt32(tb[0, z].Text)];
                    double[] y = new double[Convert.ToInt32(tb[1, z].Text)];
                    //Задаем х
                    for (int i = 0; i < Convert.ToInt32(tb[0, z].Text); i++)
                    {
                        x[i] = rand.Next(0, 100) * 0.1;
                    }
                    //Задаем у
                    for (int i = 0; i < Convert.ToInt32(tb[1, z].Text); i++)
                    {
                        y[i] = Convert.ToDouble(tb[3, z].Text) + i * Convert.ToDouble(tb[2, z].Text);
                    }
                    File.WriteAllText(filename, string.Empty); // предварительно очищаем файл
                    using (StreamWriter funcWriter = new StreamWriter(filename, true))
                    {
                        funcWriter.WriteLine(func);
                        string frow = "y/x".PadRight(8);
                        string row = "";
                        int count = 0;
                        for (int i = 0; i < y.Length; i++)
                        {
                            row = (y[i]).ToString("##0.0##").PadRight(8);
                            for (int j = 0; j < x.Length; j++)
                            {
                                double xj = x[j]; // запоминаем значения переменных для их вывода
                                double yi = y[i]; // в лист или при ошибке
                                string res = "";
                                double fx = Myfunc(x[j], y[i]);
                                frow += (x[j]).ToString("##0.0####").PadRight(8);
                                if (double.IsNaN(fx) || double.IsInfinity(fx)) // функция не определена
                                {
                                    res = ("NaN").PadRight(7);
                                    myErrorswriter.WriteLine(filename);
                                    myErrorswriter.WriteLine(func);
                                    myErrorswriter.WriteLine("x = {0}, y = {1}", xj, yi);
                                    myErrorswriter.WriteLine("Неопределенное значение");
                                    myErrorswriter.WriteLine(" ");
                                }

                                else if (y[i] == 1) // условное исключение; значение переменной, при которой происходит деление на ноль
                                {
                                    res = ("NaN").PadRight(7);
                                    myErrorswriter.WriteLine(filename);
                                    myErrorswriter.WriteLine(func);
                                    myErrorswriter.WriteLine("x = {0}, y = {1}", xj, yi);
                                    myErrorswriter.WriteLine("Деление на ноль");
                                    myErrorswriter.WriteLine(" ");
                                }
                                else
                                {
                                    res = fx.ToString("#0.00").PadRight(7);
                                }
                                MonitorListBox.Items.Add("G" + (z+1) + "("+ xj + ";" + yi +") = " + res);
                                row += res + " ";
                                count++;
                            }
                            if (i == 0) { funcWriter.WriteLine(frow); }
                            funcWriter.WriteLine(row);
                        }
                        string counter = string.Format("Количество точек - {0}", count);
                        funcWriter.WriteLine(counter);
                        myProgwriter.WriteLine(filename);
                    }
                }
                catch (FormatException)
                {
                    myErrorswriter.WriteLine(filename);
                    myErrorswriter.WriteLine(func);
                    myErrorswriter.WriteLine("Nx = {0}, Ny = {1}, Hy = {2}, Y0 = {3}", tb[0, z].Text, tb[1, z].Text, tb[2, z].Text, tb[3, z].Text);
                    myErrorswriter.WriteLine("Неправильный формат");
                    myErrorswriter.WriteLine(" ");
                }
            }
            myProgwriter.Close();
            myErrorswriter.Close();
        }

        private void EquButton_Click(object sender, EventArgs e)
        {
            DataSet();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string temp, temp2;
            string myProgram = @"myProgram.log";
            using (StreamReader InfoReader = new StreamReader(myProgram))
            {
                int i = 0;
                while ((temp = InfoReader.ReadLine()) != null) // считываем файл с информацией о программе построчно
                {
                    if (i >= 3) // названия файлов хранятся с 4 строки
                    {
                        try
                        {
                            MonitorListBox.Items.Add(temp);
                            StreamReader DataReader = new StreamReader(temp);
                            List<string> lines = new List<string>();
                            while ((temp2 = DataReader.ReadLine()) != null)
                            {
                                lines.Add(temp2); // записываем всю информацию из файла построчно
                            }
                            DataReader.Close();
                            string head = lines[1]; // столбцы таблицы
                            string[] data = head.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            string[,] dataArr = new string[lines.Count - 1, data.Length + 1]; // создаем массив размером с таблицу
                            MonitorListBox.Items.Add(lines[0]);// наша функция
                            for (int z = 1; z < lines.Count - 1; z++)
                            {
                                string[] tempData = lines[z].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                for (int j = 0; j < tempData.Length; j++)
                                {
                                    if (tempData[j] == "NaN")
                                    {
                                        dataArr[z, j] = "NaN"; // если значение NaN, то оно и пишется
                                    }
                                    else
                                    {
                                        dataArr[z, j] = tempData[j];  // иначе нормальное значение
                                    }
                                }
                            }
                            for (int z = 2; z < dataArr.GetLength(0); z++)
                            {
                                for (int j = 1; j < dataArr.GetLength(1) - 1; j++)
                                {
                                    MonitorListBox.Items.Add("G" + (i - 2) + "(" + dataArr[1, j] + ";" + dataArr[z, 0] + ") = " + dataArr[z, j]);
                                }
                            }
                            MonitorListBox.Items.Add(lines[lines.Count-1]); //количество точек
                        }
                        catch (Exception) { MonitorListBox.Items.Add("Error"); }
                    }
                    i++;
                }
            }
        }
    }
}