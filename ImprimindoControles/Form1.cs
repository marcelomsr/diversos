using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImprimindoControles
{
    public partial class Form1 : Form
    {
        float resolucao_tela = 96.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void desenha_formulario(Graphics graf, int coordX, int coordY)
        {
            graf.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);

            foreach (Control control in Form1.ActiveForm.Controls)
            {
                int control_type = control.GetType().ToString().LastIndexOf(".") + 1;

                string str_type = control.GetType().ToString().Substring(control_type);

                switch(str_type)
                {
                    case "Button":
                        Button b = (Button)control;
                        ControlPaint.DrawButton(graf, b.Left, b.Top, b.Width, b.Height, ButtonState.Normal);

                        graf.DrawString(b.Text, b.Font, new SolidBrush(b.ForeColor), b.Left + b.Width / 2 - graf.MeasureString(b.Text, b.Font).Width / 2,
                            b.Top + b.Height / 2 - graf.MeasureString("a", b.Font).Height / 2, new StringFormat());
                        break;
                    
                    case "TextBox":
                        TextBox t = (TextBox)control;
                        ControlPaint.DrawButton(graf, t.Left, t.Top, t.Width, t.Height, ButtonState.Pushed);

                        graf.FillRectangle(new SolidBrush(t.BackColor), t.Left + 1, t.Top + 1, t.Width + 2, t.Height - 2);

                        graf.DrawString(t.Text, t.Font, new SolidBrush(t.ForeColor), t.Left + 2, 
                            t.Top + t.Height / 2 - graf.MeasureString("a", t.Font).Height / 2, new StringFormat());
                        break;
                }
            }
        }

        private void prt_document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrinterResolution resolucao = e.PageSettings.PrinterResolution;
            desenha_formulario(e.Graphics, resolucao.X, resolucao.Y);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            resolucao_tela = e.Graphics.DpiX;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            prt_prv_dialog.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            prt_document.Print();
        }
    }
}
