using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeBases
{
    public partial class frm_calculadoraDeBases : Form
    {
        public frm_calculadoraDeBases()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            if (rbt_decimal.Checked)
            {
                int decimal_num1 = int.Parse(txt_num1.Text);
                int decimal_num2 = int.Parse(txt_num2.Text);

                txt_resultado.Text = (decimal_num1 + decimal_num2).ToString();
            }
            else if (rbt_binario.Checked)
            {
                int binario_num1 = Convert.ToInt32(txt_num1.Text, 2);
                int binario_num2 = Convert.ToInt32(txt_num2.Text, 2);

                txt_resultado.Text = Convert.ToString(binario_num1 + binario_num2, 2);
            }
            else if (rbt_hexa.Checked)
            {
                int hexa_num1 = Convert.ToInt32(txt_num1.Text, 16);
                int hexa_num2 = Convert.ToInt32(txt_num2.Text, 16);

                txt_resultado.Text = (hexa_num1 + hexa_num2).ToString("x").ToUpper();
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}