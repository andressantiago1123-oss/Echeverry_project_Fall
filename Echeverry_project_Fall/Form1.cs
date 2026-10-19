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
            VideoGame myGame = new VideoGame();

            myGame.GameName = txtGameName.Text;
            myGame.GamePrice = double.Parse(txtGamePrice.Text);

            myGame.CalculateTotals();

            lstOut.Items.Clear();

            string[] lines = myGame.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                lstOut.Items.Add(line);
            }
        

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
