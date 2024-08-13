namespace TPLaba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбранная дата - " + (dateTimePicker1.Value.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}