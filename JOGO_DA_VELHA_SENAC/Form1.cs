using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGO_DA_VELHA_SENAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Xpontos = 0;
        int empates = 0;
        int rodadas = 0;
        int Opontos = 0;
        bool turno = true;
        bool jogo_final = false;    

        private void button2_Click(object sender, EventArgs e)
        {


            button2 = (Button)sender;
            if (button2.Text == "" && jogo_final == false)
            {
                if (turno)
                {
                    button2.Text = "x";
                    rodadas++;
                    turno = !turno;
                }
                else
                {
                    button2.Text = "o";
                    rodadas++;
                    turno = !turno;
                }
            }
        
        }
    }
}
