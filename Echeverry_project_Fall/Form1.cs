namespace Echeverry_project_Fall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTextInput.Clear();
            txtNumericInput.Clear();
            lstOut.Items.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string GameName;
            double GamePrice;
            double salesTax;
            double finalTotal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
