using System.Runtime.InteropServices.ObjectiveC;

namespace Echeverry_project_Fall
{
    public partial class Form1 : Form
    {
        private VideoGame myGame;
        private string selectedPlatform = "Xbox";

        private string fileName = "transactions.txt";
        private string configFileName = "";
        
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
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select Configuration File";
            openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                configFileName = openDialog.FileName;
                StreamReader inputFile = null;

                try
                {
                    inputFile = new StreamReader(configFileName);
                    string line = "";
                    int count = 0;

                    do
                    {
                        line = inputFile.ReadLine();

                        if (line != null)
                        {
                            double rate = double.Parse(line);

                            if (count == 0)
                            {
                                VideoGame.xboxTaxRate = rate;
                            }
                            else if (count == 1)
                            {
                                VideoGame.playstationTaxRate = rate;
                            }
                            else if (count == 2)
                            {
                                VideoGame.pcTaxRate = rate;
                            }
                            count++;
                         
                        }
                    } while (line != null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading configuration file: " + ex.Message,
                                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (inputFile != null)
                    {
                        inputFile.Close();
                    }
                }
            }
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
            lstOut.Items.Add("-----------------------------------------");
            
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
