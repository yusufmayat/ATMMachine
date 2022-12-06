using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Frm_Login : Form
    {
        public static Frm_Login instance;
        string placeHolder;
        string input;
        public string pin = "4960";
        int NumOfInputs;
        char delete;

        public Frm_Login()
        {
            InitializeComponent();
            instance = this;
            lbl_KeyInput.Text = "Please type using the keys displayed";
        }


        private void Key_Click(object sender, EventArgs e)
        {
            if (sender == btn_Delete)
            {
                if (input == null) 
                {
                    lbl_KeyInput.Text = "Please type using the keys displayed";
                
                }
                else if (input.Length == 0)
                {
                    lbl_KeyInput.Text = "Please type using the keys displayed";
                }
                else
                {
                    input = input.Substring(0, input.Length - 1);
                    NumOfInputs--;
                    lbl_KeyInput.Text = input;
                }
            }
            else if (sender == btn_Enter)
            {
                if (input == null)
                {
                    lbl_KeyInput.Text = "Please enter 4 digits";
                    input = null;
                    NumOfInputs = 0;

                }
                else if (input.Length < 4)
                {
                    lbl_KeyInput.Text = "Please enter 4 digits";
                    input = null;
                    NumOfInputs = 0;
                }
                else if (input == pin)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    instance.Hide();
                }
            }
            else if (sender == btn_Clear)
            {
                input = null;
                NumOfInputs = 0;
                lbl_KeyInput.Text = input;
            }
            else if (NumOfInputs >= 4)
            {
                lbl_KeyInput.Text = "Incorrect, please try again";
            }
            else
            {
                Button place = (Button)sender;
                placeHolder = place.Text;
                NumOfInputs++;
                input = input + placeHolder;
                lbl_KeyInput.Text = input;
            }

        }
    }
}
