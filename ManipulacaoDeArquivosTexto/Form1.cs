using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManipulacaoDeArquivosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsTXT.Tables.Add("Table1");

            dsTXT.Tables["Table1"].Columns.Add("NF");
            dsTXT.Tables["Table1"].Columns[0].DataType = typeof(String);

            dsTXT.Tables["Table1"].Columns.Add("Emissao");
            dsTXT.Tables["Table1"].Columns[1].DataType = typeof(DateTime);

            dsTXT.Tables["Table1"].Columns.Add("Valor");
            dsTXT.Tables["Table1"].Columns[2].DataType = typeof(Decimal);

            dataGridView1.DataSource = dsTXT;
            dataGridView1.DataMember = "Table1";
        }

        private void btn_ler_txt_Click(object sender, EventArgs e)
        {
            string lido = "";
            string data = "";
            int linha = 0;
            decimal valItem = 0;
            object[] Valores = new object[3];

            openFileDialog1.Title = "Selecione o arquivo";
            openFileDialog1.Filter = "Text files (*.txt) |*.txt";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader arq = new StreamReader(openFileDialog1.FileName);

                    dsTXT.Tables["Table1"].Rows.Clear();

                    while ((lido = arq.ReadLine()) != null)
                    {
                        if (lido.Substring(0, 1) == "1")
                        {
                            textBox1.Text = lido.Substring(1, 14);
                            textBox2.Text = lido.Substring(15, 50);

                            data = lido.Substring(65, 2) + "/" +
                                   lido.Substring(67, 2) + "/" +
                                   lido.Substring(69, 4);

                            dateTimePicker1.Value = Convert.ToDateTime(data);
                        }
                        else if (lido.Substring(0, 1) == "2")
                        {
                            data = lido.Substring(7, 2) + "/" +
                                   lido.Substring(9, 2) + "/" +
                                   lido.Substring(11, 4);

                            valItem = Convert.ToDecimal(lido.Substring(15, 10)) / 100;

                            Valores[0] = lido.Substring(1, 6);
                            Valores[1] = data;
                            Valores[2] = valItem.ToString("0.00");

                            dsTXT.Tables["Table1"].Rows.Add(Valores);
                        }
                    }

                    arq.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string gravar = "";
            int Linha;

            saveFileDialog1.FileName = "Artigo.txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter arqTXT = new StreamWriter(saveFileDialog1.FileName);

                    gravar = "1" + textBox1.Text + textBox2.Text.PadRight(50, ' ') + dateTimePicker1.Value.ToString("ddMMyyyy");
                    arqTXT.WriteLine(gravar);

                    for (Linha = 0; Linha < dsTXT.Tables["Table1"].Rows.Count; Linha++)
                    {
                        gravar = "2" + dsTXT.Tables["Table1"].Rows[Linha]["NF"].ToString().PadRight(6, ' ');

                        gravar += ((DateTime)dsTXT.Tables["Table1"].Rows[Linha]["Emissao"]).ToString("ddMMyyyy");

                        gravar += ((Decimal)dsTXT.Tables["Table1"].Rows[Linha]["Valor"] * 100).ToString("0000000000");

                        arqTXT.WriteLine(gravar);
                    }

                    arqTXT.Close();
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form f = (Form)sender;

            if (e.KeyCode == Keys.Return)
                SelectNextControl(f.ActiveControl, true, false, true, true);
        }
    }
}
