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
        int minutodescanso = 5;
        int segundodescanso = 2;



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
            
            button4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button5.Hide();
            textBox3.Hide();
            label2.Hide();
            button6.Hide();
            textBox4.Hide();
            label3.Hide();


            label4.Hide();


            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();

            label5.Hide();
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
            if(text1 == 1 && botao4 ==1 | text2 == 1 && botao5 == 1)
            {
                textBox1.Hide();
                button4.Hide();
                textBox2.Hide();
                button5.Hide();
            }
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
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();

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
            label4.Text = "Tempo trabalhando " + minuto.ToString() + " minutos.";
            label5.Text = segundo.ToString();
            segundo--;
            
            if (segundo == 0)
            {
                minuto--;
                segundo = 1;
              
               
            }
            if (minuto == 0)
            {
                 
                 timer1.Stop();
                 MessageBox.Show("Hora de descansar!");
                timer2.Start();
            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            segundodescanso--;

            if (segundodescanso == 0)
            {
                minutodescanso--;
            }
            if (minutodescanso == 0)
            {
                timer2.Stop();
                MessageBox.Show("Teste");

            }
        }
    }
}
