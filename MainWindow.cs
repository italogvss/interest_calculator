using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemPorcento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPorcentagem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDinheiro = new System.Windows.Forms.Label();
            this.labelDebito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelParcela = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPorcento});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(442, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemPorcento
            // 
            this.menuItemPorcento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPorcentagem});
            this.menuItemPorcento.Name = "menuItemPorcento";
            this.menuItemPorcento.ShowShortcutKeys = false;
            this.menuItemPorcento.Size = new System.Drawing.Size(59, 20);
            this.menuItemPorcento.Text = "Opções";
            // 
            // menuItemPorcentagem
            // 
            this.menuItemPorcentagem.Name = "menuItemPorcentagem";
            this.menuItemPorcentagem.Size = new System.Drawing.Size(178, 22);
            this.menuItemPorcentagem.Text = "Editar Porcentagem";
            this.menuItemPorcentagem.Click += new System.EventHandler(this.menuItemPorcentagemItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preço:";
            // 
            // textValue
            // 
            this.textValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValue.Location = new System.Drawing.Point(60, 132);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(370, 24);
            this.textValue.TabIndex = 2;
            this.textValue.TextChanged += new System.EventHandler(this.textValue_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelDinheiro);
            this.groupBox1.Controls.Add(this.labelDebito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Vista";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dinheiro/Pìx:";
            // 
            // labelDinheiro
            // 
            this.labelDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDinheiro.AutoSize = true;
            this.labelDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinheiro.Location = new System.Drawing.Point(94, 55);
            this.labelDinheiro.Name = "labelDinheiro";
            this.labelDinheiro.Size = new System.Drawing.Size(51, 16);
            this.labelDinheiro.TabIndex = 8;
            this.labelDinheiro.Text = "R$ 00,0";
            // 
            // labelDebito
            // 
            this.labelDebito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDebito.AutoSize = true;
            this.labelDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebito.Location = new System.Drawing.Point(62, 23);
            this.labelDebito.Name = "labelDebito";
            this.labelDebito.Size = new System.Drawing.Size(51, 16);
            this.labelDebito.TabIndex = 7;
            this.labelDebito.Text = "R$ 00,0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Débito:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelParcela);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(226, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No Credito";
            // 
            // labelParcela
            // 
            this.labelParcela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParcela.AutoSize = true;
            this.labelParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcela.Location = new System.Drawing.Point(95, 80);
            this.labelParcela.Name = "labelParcela";
            this.labelParcela.Size = new System.Drawing.Size(51, 16);
            this.labelParcela.TabIndex = 10;
            this.labelParcela.Text = "R$ 00,0";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(54, 55);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(51, 16);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "R$ 00,0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parcelas de:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vezes:";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.comboBox.Location = new System.Drawing.Point(77, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "1x";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(442, 168);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Juros";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void textValue_TextChanged(object sender, EventArgs e)
        {
            String valuestr = Regex.Match(textValue.Text, @"\d+,?\d*").Value;
            double value = Double.Parse(valuestr == ""? "0": valuestr);
            String str;
            if (comboBox.SelectedItem == null)
                str = "1x";
            else
                str = comboBox.SelectedItem.ToString();
            String vezes = Regex.Match(str, @"\d+").Value;
            calcularValorAVista(value);
            calcularValorCredito(value, vezes);
        }

        private void calcularValorAVista(double value)
        {
            double debito = value - (value * (double)Properties.Settings.Default["debito"])/100;
            double dinheiro = value - (value *(double)Properties.Settings.Default["pix"]) / 100;
            labelDebito.Text = $"R$ {debito.ToString("N2")}";
            labelDinheiro.Text = $"R$ {dinheiro.ToString("N2")}";
        }

        private void calcularValorCredito(double value, String vezes)
        {
            String chave;
            int numvezes = 1;
            if(vezes != null)
            {
                chave = "x" + vezes;
                numvezes = int.Parse(vezes);
            }
            else
            {
                chave = "x1";
            }

            Console.WriteLine($"Chave: {chave} | Porcentagem: {Properties.Settings.Default[chave]}");
            double parcelas = (value * ((double)Properties.Settings.Default[chave] / 100) + value) / numvezes;
            double total = parcelas * numvezes;

            labelParcela.Text = $"R$ {parcelas.ToString("N2")}";
            labelTotal.Text = $"R$ {total.ToString("N2")}";
        }

        private void menuItemPorcentagemItem_Click(object sender, EventArgs e)
        {
            PorcentagemWindow pw = new PorcentagemWindow();
            pw.ShowDialog();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String valuestr = Regex.Match(textValue.Text, @"\d+,?\d*").Value;
            double value = Double.Parse(valuestr == "" ? "0" : valuestr);

            String str = comboBox.SelectedItem.ToString();
            String vezes = Regex.Match(str, @"\d+").Value;

            calcularValorCredito(value, vezes);
        }
    }
}
