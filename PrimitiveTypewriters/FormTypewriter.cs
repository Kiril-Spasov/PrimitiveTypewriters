using System;
using System.IO;
using System.Windows.Forms;

namespace PrimitiveTypewriters
{
    public partial class FormTypewriter : Form
    {
        public FormTypewriter()
        {
            InitializeComponent();
        }

        private void BtnCheckCost_Click(object sender, EventArgs e)
        {
            string letters1 = "qwertyuiopasdfghjklzxcvbnm";

            int currentPos;
            int newPos;
            int totalCost;

            string line = "";
            string letter;

            string path = Application.StartupPath + @"\typewriter.txt";
            StreamReader streamReader = new StreamReader(path);

            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    totalCost = 0;
                    currentPos = 0;
                    newPos = 0;

                    for (int i = 0; i < line.Length; i++)
                    {
                        letter = line.Substring(i, 1);
                        newPos = letters1.IndexOf(letter);

                        if (newPos > currentPos)
                        {
                            totalCost += newPos - currentPos;
                        }
                        else if (newPos < currentPos)
                        {
                            totalCost += currentPos - newPos;
                        }

                        currentPos = newPos;
                    }

                    TxtResult.Text += totalCost + Environment.NewLine;        
                }
            }
        }
    }
}
