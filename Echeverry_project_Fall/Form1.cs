namespace Echeverry_project_Fall
{
    public partial class Form1 : Form
    {
        private VideoGame myGame;
        private string selectedPlatform = "Xbox";

        private string fileName = "transactions.txt";
        
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
            lstOut.Items.Clear();

            double price = 0.0;
            bool isPriceValid = double.TryParse(txtGamePrice.Text, out price);

            if (isPriceValid && price >= 0)
            {
                string name = txtGameName.Text;

                myGame = new VideoGame(name, price, selectedPlatform);

                myGame.CalculateTotals();

                DisplayAndSaveTransactionToFile();

            }
            else
            {
                lstOut.Items.Add("ERROR: Please enter a valid numeric price.");
            }
        }
         private void DisplayAndSaveTransactionToFile()
        {
            string[] lines = myGame.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                lstOut.Items.Add(line);
            }
            
            StreamWriter outputFile = new StreamWriter(fileName, true);
            outputFile.WriteLine("----- NEW TRANSACTION (" + DateTime.Now.ToString() + ") -----");
            outputFile.WriteLine(myGame.ToString());
            outputFile.WriteLine();
            outputFile.Close();
        }

        

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radXbox.Checked = true;
        }

        private void radXbox_CheckedChanged(object sender, EventArgs e)
        {
            if (radXbox.Checked)
            {
                selectedPlatform = VideoGame.XBOX_CHOICE;
            }
        }

        private void radPlayStation_CheckedChanged(object sender, EventArgs e)
        {
            if (radPlayStation.Checked)
            {
                selectedPlatform = VideoGame.PLAYSTATION_CHOICE;
            }
        }

        private void radPC_CheckedChanged(object sender, EventArgs e)
        {
            if (radPC.Checked)
            {
                selectedPlatform = VideoGame.PC_CHOICE;
            }
        }
    }
}
