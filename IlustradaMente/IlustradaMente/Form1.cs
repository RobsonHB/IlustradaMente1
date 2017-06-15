using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlustradaMente
{

    public partial class Form1 : Form
    {
        int text1 = 0;
        int botao4 = 0;
        int text2 = 0;
        int botao5 = 0;
        int minuto = 25;
        int segundo = 1;
        int relogio = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1 = 1;
            botao4 = 1;

            textBox1.Show();
            button4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "A Técnica Pomodoro é um método de gerenciamento de tempo desenvolvido por Francesco Cirillo no final dos anos 1980. A técnica consiste na utilização de um cronômetro para dividir o trabalho em períodos de 25 minutos, separados por breves intervalos.";
            textBox2.Text = "A Técnica Pomodoro é um método de gerenciamento de tempo. A técnica foi desenvolvida no final dos anos 80 por Francesco Cirillo, que procurava uma maneira de aumentar sua produtividade nos estudos. Na prática, a Técnica Pomodoro consiste em trabalhar por blocos de tempo, chamados de pomodoro. Cada pomodoro tem 25 minutos, durante os quais você tem que trabalhar em uma única tarefa, sem interrupções. No fim de cada pomodoro, você deve fazer uma pausa de 5 minutos. A cada quatro pomodori (plural de pomodoro), você deve fazer uma pausa maior, de 30 minutos.";
            button4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button5.Hide();
            textBox3.Hide();
            label2.Hide();
            button6.Hide();
            textBox4.Hide();
            label3.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();

            label4.Hide();


            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Hide();
            button4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            button5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text2 = 1;
            botao5 = 1;

            textBox2.Show();
            button5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (text1 == 1 && botao4 == 1 | text2 == 1 && botao5 == 1)
            {
                textBox1.Hide();
                button4.Hide();
                textBox2.Hide();
                button5.Hide();
            }
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox3.Show();
            label2.Show();
            button6.Show();
            textBox4.Show();
            label3.Show();


            button1.Hide();
            button2.Hide();
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();

            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button7.Hide();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();

            button8.Hide();
            button9.Hide();
            button10.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox4.Hide();
            label3.Hide();
            textBox3.Hide();
            label2.Hide();
            button6.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Show();
            timer1.Start();
        }

    
    private void timer1_Tick(object sender, EventArgs e)
    {
        timer1.Start();
        label4.Text = "Tempo de trabalho restante: " + minuto.ToString() + " minutos.";
        relogio = 1;

            if (relogio == 1)
            {
                segundo--;
                if (segundo == 0)
                {
                    minuto--;
                    segundo = 1;
                }
                if (minuto == 0)
                {
                    segundo = 1;
                    segundo--;
                  
                    timer1.Enabled = false;
                    MessageBox.Show("Hora de descansar! Descanse por 5 minutos e comece o proximo Pomodoro");
                    minuto = 25;
                    segundo = 1;
                    label4.Text = "Tempo de trabalho restante: " + minuto.ToString() + " minutos.";

                }
            }
            
    }

    
        private void button8_Click(object sender, EventArgs e)
        {
            label4.Show();
            timer1.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Show();
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Show();
            timer1.Start();
        }
    }
}
