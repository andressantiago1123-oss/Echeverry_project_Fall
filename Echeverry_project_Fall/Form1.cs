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
            txtGameName.Clear();
            txtGamePrice.Clear();
            lstOut.Items.Clear();

            txtGameName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string GameName; 
            double GamePrice;
            double taxAmount;
            double totalAmount;

            GameName = txtGameName.Text;
            GamePrice = double.Parse(txtGamePrice.Text);

            taxAmount = GamePrice * 0.08;
            totalAmount = GamePrice + taxAmount;

            lstOut.Items.Add("Game: " + GameName + "| Price: " + GamePrice.ToString("C") + " | Tax: " + taxAmount.ToString("C") + " | Total: " + totalAmount.ToString("C"));

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
