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
            double taxAmount;
            double totalAmount;

            GameName = txtTextInput.Text;
            GamePrice = double.Parse(txtNumericInput.Text);

            taxAmount = GamePrice * 0.08;
            totalAmount = GamePrice + taxAmount;


            lstOut.Items.Clear();
            lstOut.Items.Add("Game: " + GameName);
            lstOut.Items.Add("Price: " + GamePrice.ToString("C"));
            lstOut.Items.Add("Tax: " + taxAmount.ToString("C"));
            lstOut.Items.Add("Total: " + totalAmount.ToString("C"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
