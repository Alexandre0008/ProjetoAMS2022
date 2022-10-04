using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_REVISAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos encerrando o programa para voce ^-^" , "Encerrando");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jair Bolsonario  : 4699 votos   ");
            MessageBox.Show("Lula             : 1909 votos   ");
            MessageBox.Show("Ciro Gomes       : 7700 votos   ");
            MessageBox.Show("André Janones    : 1909 votos   ");
            MessageBox.Show("Simone  Tabet    : 12699 votos  ");

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text =="" || textBox2.Text =="") 
            {
                MessageBox.Show("Preencha os dados que estão faltando ", " ERRO");

               
                Application.Restart();
            }
            else if (RDB_J.Checked == true || textBox1.Text=="" || textBox2.Text =="" )
            {
                MessageBox.Show("Voce votou para Jair Bolsonaro  " , " Voto efetuado com sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (RDB_An.Checked == true || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Voce votou para André Janones ", " Voto efetuado com sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (RDB_CIRO.Checked == true || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Voce votou para Ciro Gomes  ", " Voto efetuado com sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (RDB_LUIZ.Checked == true || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Voce votou para Lula ", " Voto efetuado com sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else if (RDB_SIMO.Checked == true || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Voce votou para Simone Tebet  ", " Voto efetuado com sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

            }
            else if (RDB_VOTO.Checked == true || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Voce votou em branco ", " Voto efetuado com sucesso");
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
