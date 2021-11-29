﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool vezX = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            vezX = true;
            lblVez.Text = "X";

            botoesEnable(true,false);
        }

        private void botoesEnable(bool habCelulas,bool habXO)
        {
            btnC1L1.Enabled = habCelulas;
            btnC1L2.Enabled = habCelulas;
            btnC1L3.Enabled = habCelulas;
            btnC2L1.Enabled = habCelulas;
            btnC2L2.Enabled = habCelulas;
            btnC2L3.Enabled = habCelulas;
            btnC3L1.Enabled = habCelulas;
            btnC3L2.Enabled = habCelulas;
            btnC3L3.Enabled = habCelulas;

            btnX.Enabled = habXO;
            btnO.Enabled = habXO;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            vezX = false;
            lblVez.Text = "O";

            botoesEnable(true, false);
        }

        private void btnRecomeca_Click(object sender, EventArgs e)
        {
            recomecar();
        }

        private void recomecar()
        {
            botoesEnable(false, true);

            btnC1L1.Text = "";
            btnC1L2.Text = "";
            btnC1L3.Text = "";
            btnC2L1.Text = "";
            btnC2L2.Text = "";
            btnC2L3.Text = "";
            btnC3L1.Text = "";
            btnC3L2.Text = "";
            btnC3L3.Text = "";

            lblVez.Text = "";
            lblVencedor.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;
            btn.Enabled = false;


            if (vezX)
            {   
                lblVez.Text = "O";
            }
            else
            {
                lblVez.Text = "X";
            }

            vezX = !vezX;
        }
    }
}
