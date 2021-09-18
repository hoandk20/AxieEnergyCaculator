using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxieCalculator
{
    public partial class Axie : Form
    {
        int card = 0;
        int En = 0;
        public Axie()
        {
            InitializeComponent();
        }

        void show()
        {
            lbcard.Text = "Card: " + card;
            lbE.Text = "Energy" + En;
        }
        private void btnAddCard_Click(object sender, EventArgs e)
        {
            card += 1;
            show();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            card += 3;
            En += 2; show();
        }

        private void btnMinusCard_Click(object sender, EventArgs e)
        {
            card -=1; show();
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            En += 1; show();
        }

        private void btnMinusE_Click(object sender, EventArgs e)
        {
            En -= 1; show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            En = 3;
            card = 6; show();
        }
    }
}
