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
            labelPONTOS.Text = "";
            labelOPONTOS.Text = "";
            labelEMPATES.Text = "";
        }

        int Xpontos = 0;
        int empates = 0;
        int rodadas = 0;
        int Opontos = 0;
        bool turno = true;
        bool jogo_final = false;
        string[] texto = new string[9];
        private int playerqueganhou;
        int xplayer = 0;
        int oplayer = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            button2 = (Button)sender;
            int ButtonIndex = button2.TabIndex;

            if (button2.Text == "" && jogo_final == false)
            {
                if (turno)
                {
                    button2.Text = "X";
                    texto[ButtonIndex] = button2.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(1);
                }

                else
                {
                    button2.Text = "O";
                    texto[ButtonIndex] = button2.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(2);
                }

            }
        }
        void vencedor(int playerqueganhou)
        {

            jogo_final = true;
            if (playerqueganhou == 1)
            {
                xplayer++;
                labelPONTOS.Text = Convert.ToString(xplayer);
                MessageBox.Show("Jogador X ganhou!");
                turno = true;
            }
            else
            {
                Opontos++;
                labelOPONTOS.Text = Convert.ToString(oplayer);
                MessageBox.Show("Jogador O ganhou!");
                turno = false;
            }

        }
        void checagem(int checagemplayer)
        {
            string suporte;
            if (checagemplayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }
            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        vencedor(checagemplayer);
                        return;
                    }


                }
            }
            for (int vertical = 0; vertical < 3; vertical ++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        vencedor(checagemplayer);
                        return;
                    }


                }
            }

            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    vencedor(checagemplayer);
                    return;
                }
            }
            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    vencedor(checagemplayer);
                    return;
                }
            }
            if (rodadas ==9 && jogo_final == false)
            {
                empates++;
                labelEMPATES.Text = Convert.ToString(empates);
                MessageBox.Show("Empate");
                jogo_final = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text= "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            rodadas = 0;
            jogo_final=false;

           for (int i =0; i<9; i++)
            {
                texto[i] = "";
            }
        }
    }

}
