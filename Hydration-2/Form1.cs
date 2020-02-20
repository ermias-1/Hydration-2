using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydration_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numGlasses_ValueChanged(object sender, EventArgs e)
        {
            decimal glasses = numGlasses.Value;

            if (glasses >= 0 && glasses <= 1)
            {

                // Assigning the Backcolor and the Forecolor

                this.BackColor = Color.Brown;
                this.ForeColor = Color.White;


            }

            else if (glasses >= 2 && glasses <= 4)
            {
                // 

                this.BackColor = Color.Yellow;
                this.ForeColor = Color.Black;

            }
            else if (glasses >= 5 && glasses <= 8)
            {

                this.BackColor = Color.Green;
                this.ForeColor = Color.White;

            }

            else if (glasses >= 9 && glasses <= 15)
            {

                this.BackColor = Color.Blue;
                this.ForeColor = Color.White;

            }

            else
            {

                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
            }



            // Creating and Call a new method for the event, and use return value
            string hydrationStatus = GenerateFeedback(glasses);

            lblHydrationStatus.Text = hydrationStatus;


        }
        private string GenerateFeedback(decimal glasses)
        {
            if (glasses >= 0 && glasses <= 1)
            {
                return "Drink some water!";

            }
            else if (glasses >= 2 && glasses <= 4)
            {
                return "Good job!";


            }
            else if (glasses >= 5 && glasses <= 8)
            {
                return "Just right!";


            }
            else if (glasses >= 9 && glasses <= 15)
            {
                return "Awosome!";


            }
            else
            {
                return "Too much!";

            }

        }
    }
}
