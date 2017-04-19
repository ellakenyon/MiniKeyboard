using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {


        bool mode = true; //if true then in multi press mode else false in prediction mode.
        ListBox GlobalListbox = new ListBox();
        int intMyListIndex = 0;
        bool first_visit = true;
        string Str_KeyStrokes;


        public Form1()
        {
            InitializeComponent();
        }

        private void ModeBtn_Click(object sender, EventArgs e)
        {
            // Switches between Multi-Press and Prediction mode.
            if (ModeStatus.Text == "Multi-Press")
            {
                ModeStatus.Text = "Prediction";

            }
            else if (ModeStatus.Text == "Prediction")
            {
                ModeStatus.Text = "Multi-Press";
            }

        }

        private void No8Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    GlobalListbox.Items.AddRange(No8.Items);                  
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void RepeatLetterTimer_Tick(object sender, EventArgs e)
        {
            RepeatLetterTimer.Enabled = false;

            Builder.AppendText(GlobalListbox.Items[intMyListIndex].ToString());
            intMyListIndex = -1;
            //Switch case


            
          
        }

        private void SpaceBtn_Click(object sender, EventArgs e)
        {
            
                //Adds a space and then clears the Builder text box.
                NotePadTextBox.Text = NotePadTextBox.Text + " " + Builder.Text;
                Builder.Text = string.Empty;
            
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            
                //Moves letters in builder text box to the large Notepad text box.
                NotePadTextBox.AppendText(Environment.NewLine);
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the application.
            base.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displays an Open File Dialog.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //If user clicks OK, then it opens.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Cursor = new Cursor(openFileDialog1.OpenFile());
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears the Notepad Textbox.
            NotePadTextBox.Text = String.Empty;
        }

        private void No9Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No9.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No7Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No7.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No6Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No6.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No5Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No5.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No4Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No4.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No3Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No3.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        private void No2Btn_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                if (first_visit == true)
                {
                    GlobalListbox.Items.Clear();
                    //Clear global listbox, then add the button's listbox.
                    GlobalListbox.Items.AddRange(No2.Items);
                }
                // My multi press code goes in here

                RepeatLetterTimer.Enabled = false;
                intMyListIndex++;

                RepeatLetterTimer.Enabled = true;
                // For loop to transfer list info from listbox to global variable.

            }
            else
            {
                // My prediction code goes in here
            }
        }

        
    }
}