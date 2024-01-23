using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class PorcentagemWindow : Form
    {
        private double[] porcentagemJuro;
        private double[] porcentagemDesconto;
        public PorcentagemWindow()
        {
            GetPorcentagens();
            InitializeComponent();
            SetAllTextBox();

            labelModificacao.Text = Properties.Settings.Default["ultima"].ToString();
        }

        private void GetPorcentagens()
        {
            porcentagemJuro = new double[11];
            porcentagemDesconto = new double[2];
            for (int i = 2; i <= 12; i++) {
                porcentagemJuro[i-2] = (double)Properties.Settings.Default[$"x{i}"];
                Console.WriteLine(porcentagemJuro[i - 2]);
            }
            porcentagemDesconto[0] = (double)Properties.Settings.Default["debito"];
            porcentagemDesconto[1] = (double)Properties.Settings.Default[$"pix"];

        }

        private void SetAllTextBox()
        {
            textBox2.Text =     porcentagemJuro[0].ToString();
            textBox3.Text =     porcentagemJuro[1].ToString();
            textBox4.Text =     porcentagemJuro[2].ToString();
            textBox5.Text =     porcentagemJuro[3].ToString();
            textBox6.Text =     porcentagemJuro[4].ToString();
            textBox7.Text =     porcentagemJuro[5].ToString();
            textBox8.Text =     porcentagemJuro[6].ToString();
            textBox9.Text =     porcentagemJuro[7].ToString();
            textBox10.Text =    porcentagemJuro[8].ToString();
            textBox11.Text =    porcentagemJuro[9].ToString();
            textBox12.Text =    porcentagemJuro[10].ToString();
            textBoxDebito.Text = porcentagemDesconto[0].ToString();
            textBoxPix.Text =   porcentagemDesconto[1].ToString();
        }
        private void buttonSalva_Click(object sender, EventArgs e)
        {
            porcentagemJuro[0] = Double.Parse(textBox2.Text);
            porcentagemJuro[1] = Double.Parse(textBox3.Text);
            porcentagemJuro[2] = Double.Parse(textBox4.Text);
            porcentagemJuro[4] = Double.Parse(textBox6.Text);
            porcentagemJuro[3] = Double.Parse(textBox5.Text);
            porcentagemJuro[5] = Double.Parse(textBox7.Text);
            porcentagemJuro[6] = Double.Parse(textBox8.Text);
            porcentagemJuro[7] = Double.Parse(textBox9.Text);
            porcentagemJuro[8] = Double.Parse(textBox10.Text);
            porcentagemJuro[9] = Double.Parse(textBox11.Text);
            porcentagemJuro[10] = Double.Parse(textBox12.Text);
            porcentagemDesconto[0] = Double.Parse(textBoxDebito.Text);
            porcentagemDesconto[1] = Double.Parse(textBoxPix.Text);

            for (int i = 2; i <= 12; i++)
            {
                Properties.Settings.Default[$"x{i}"] = porcentagemJuro[i - 2];
            }
            Properties.Settings.Default["debito"]  = porcentagemDesconto[0];
            Properties.Settings.Default[$"pix"] = porcentagemDesconto[1];
            Properties.Settings.Default["ultima"] = DateTime.Now;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
