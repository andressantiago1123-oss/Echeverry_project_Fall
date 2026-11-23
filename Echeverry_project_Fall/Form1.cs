using System.Runtime.InteropServices.ObjectiveC;

namespace Echeverry_project_Fall
{
    public partial class Form1 : Form
    {
        private VideoGame myGame;
        private string selectedPlatform = "Xbox";

        private string fileName = "transactions.txt";
        private string configFileName = "config.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radXbox.Checked = true;
            ReadConfigFile();
        }

        private void ReadConfigFile()
        {
            StreamReader inputFile = null;
            bool fileSuccess = false;

            do
            {
                try
                {
                    inputFile = new StreamReader(configFileName);

                    VideoGame.xboxTaxRate = double.Parse(inputFile.ReadLine());
                    VideoGame.playstationTaxRate = double.Parse(inputFile.ReadLine());
                    VideoGame.pcTaxRate = double.Parse(inputFile.ReadLine());

                    fileSuccess = true;
                }
                catch (Exception ex)
                {
                    lstOut.Items.Add("Error reading configuration file: " + ex.Message);

                    if (openFileDialog1.ShowDialog() = DialogResult.OK)
                    {
                        configFileName = openFileDialog1.FileName;
                    }
                    else
                    {
                        fileSuccess = true;
                    }
                }
                finally
                {
                    if (inputFile != null)
                    {
                        inputFile.Close();
                    }
                }
            } while (fileSuccess == false);
        }

      
   
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtGameName.Clear();
            txtGamePrice.Clear();
            lstOut.Items.Clear();

            radXbox.Checked = true;
            txtGameName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           

            double price = 0.0;
            bool isPriceValid = double.TryParse(txtGamePrice.Text, out price);

            if (isPriceValid && price >= 0)
            {
                string name = txtGameName.Text;

                myGame = new VideoGame(name, price, selectedPlatform);

                DisplayAndSaveTransactionToFile();

            }
            else
            {
                lstOut.Items.Add("ERROR: Please enter a valid numeric price.");
            }
        }
         private void DisplayAndSaveTransactionToFile()
        {
            string output = myGame.ToString();
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                lstOut.Items.Add(line);
            }
            lstOut.Items.Add("-----------------------------------------");
            
            StreamWriter outputFile = new StreamWriter(fileName, true);
            outputFile.WriteLine("----- NEW TRANSACTION (" + DateTime.Now.ToString() + ") -----");
            outputFile.WriteLine(output);
            outputFile.WriteLine();
            outputFile.Close();
        }

        

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
