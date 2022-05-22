using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        bool vez = true, fim=false;
        string[] lista = new string[9];
        int cont = 0, Xpontos, Opontos, empates;

        public Form1()
        {
            InitializeComponent();
        }

      

            private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //independente do botao que clico em que atribui o evento button1_click

            if (btn.Text == "" && fim==false)
            {
                if (vez == true)
                {
                    btn.Text = "X";
                    vez = false;
                    lista[btn.TabIndex] = "X";
                    verify(1);
                }
                else
                {
                    btn.Text = "O";
                    vez = true;
                    lista[btn.TabIndex] = "O";
                    verify(2);
                }
            }
            
            
        }

        public void vencedor(int player)
        {   
            if(fim == false) {
                if (player == 1)
                {
                    Xpontos++;
                    label2.Text = "Pontos X: " + Xpontos;
                }
                else
                {
                    Opontos++;
                    label3.Text = "Pontos O: " + Opontos;
                }
            }
            
        }
        public void verify(int v)
        {   //aqui ele verifica qual foi o ultimo a jogar para fazer a devida checagem
            string time = "";
            if(v == 1)
            {
                time = "X";
            }
            else { time = "O"; } 

            for (int h = 0; h < 7; h += 3) //qual linha eu ganhei, aqui ele verifica a linha usado como base a primeira coluna
            {
                if(time == lista[h])
                {
                    if(time == lista[h + 1] && time == lista[h+2])
                    {   

                        vencedor(v);
                        
                        label1.Text = time + " Venceu!";
                        fim = true;
                        if(h == 0)
                        {
                            button1.BackColor = Color.LimeGreen;
                            button2.BackColor = Color.LimeGreen;
                            button3.BackColor = Color.LimeGreen;
                        }
                        else if(h == 3)
                        {
                            button4.BackColor = Color.LimeGreen;
                            button5.BackColor = Color.LimeGreen;
                            button6.BackColor = Color.LimeGreen;
                        }
                        else if(h == 6)
                        {
                            button7.BackColor = Color.LimeGreen;
                            button8.BackColor = Color.LimeGreen;
                            button9.BackColor = Color.LimeGreen;
                        }
                    }
                    
                }
            }
            for(int ver = 0; ver < 3; ver++)
            {
                if (time == lista[ver])
                {
                    if (time == lista[ver + 3] && time == lista[ver + 6])
                    {

                        vencedor(v);

                        label1.Text = time + " Venceu!";
                        fim = true;
                        if (ver == 0)
                        {
                            button1.BackColor = Color.LimeGreen;
                            button4.BackColor = Color.LimeGreen;
                            button7.BackColor = Color.LimeGreen;
                        }
                        else if (ver == 1)
                        {
                            button2.BackColor = Color.LimeGreen;
                            button5.BackColor = Color.LimeGreen;
                            button8.BackColor = Color.LimeGreen;
                        }
                        else if (ver== 2)
                        {
                            button3.BackColor = Color.LimeGreen;
                            button6.BackColor = Color.LimeGreen;
                            button9.BackColor = Color.LimeGreen;
                        }
                    }

                }

            }

            if(time == lista[0] && time == lista[4] && time == lista[8])
            {

                vencedor(v);

                label1.Text = time + " Venceu!";
                fim = true;
                button1.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button9.BackColor = Color.LimeGreen;
            }
            else if(time == lista[2] && time == lista[4] && time == lista[6])
            {

                vencedor(v);

                label1.Text = time + " Venceu!";
                fim = true;
                button3.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button7.BackColor = Color.LimeGreen;
            }

            cont++;

            if(cont == 9 && fim == false)
            {
                fim = true;
                label1.Text = "Empate";
                empates++;
                label4.Text = "Empate: " + empates;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            label1.Text = "";
            cont = 0;
            fim = false;
            vez = true;
            for(int i = 0; i < lista.Length; i++)
            {
                lista[i] = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
