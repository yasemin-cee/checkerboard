using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class DenemeFormu : Form
    {
        public DenemeFormu()
        {
            InitializeComponent();
        }

        private void DenemeFormu_Load(object sender, EventArgs e)
        {
            GenerateButtons();
            // button.Text = ("My Button");
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]);


                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }

                left = 0;
                top += 50;
            }
        }
    }
}
