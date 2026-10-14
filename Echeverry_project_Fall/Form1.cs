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
            string GameName = txtGameName.Text; 
            double GamePrice = double.Parse(txtGamePrice.Text);
            
            VideoGame myGame = new VideoGame(GameName, GamePrice);

            myGame.CalculateTotals();

            lstOut.Items.Add(myGame.ToString());

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
