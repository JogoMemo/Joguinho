﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void verifica()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0;
        }

            

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //botões com as imagens que alternam no click
        #region ****botões***

        private void button4_Click(object sender, EventArgs e)
        {
            
            button4.BackgroundImage = Properties.Resources.boxe;
            
        }  

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.footbol;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.jogadorbas;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.judo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.nado;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = Properties.Resources.bolosoccer;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources.boxe;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackgroundImage = Properties.Resources.nado;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackgroundImage = Properties.Resources.rugby;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources.footbol;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackgroundImage = Properties.Resources.judo;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources.bolavolei;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources.jogadorbas;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackgroundImage = Properties.Resources.bolavolei;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources.bolosoccer;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.rugby;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.bolabask;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackgroundImage = Properties.Resources.bolabask;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackgroundImage = Properties.Resources.images;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackgroundImage = Properties.Resources.images;
        }

        #endregion


        //metodo para a jogada

        //public void Jogada()
        //{
        //    if (BackgroundImage != BackgroundImage)
        //        BackgroundImage = Properties.Resources.plano;
           

                
        
        //}







    }
}
