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

namespace ConversorDeBases
{
    public partial class frm_calculadoraDeBases : Form
    {
        public frm_calculadoraDeBases()
        {
            InitializeComponent();
        }

        string regexDecimal = @"^[0-9]\d*$";
        string regexBinario = @"^[0-1]*$";
        string regexHexa = @"^[A-Fa-f0-9]*$";

        private void frm_calculadoraDeBases_Load(object sender, EventArgs e)
        {
            cbx_operacao.SelectedIndex = 0;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton rbt_selecionado = panel_rbts.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); //colocando na variavel rbt_selecionado o radio button selecionado no form

                switch (rbt_selecionado.Text) //base selecionada pelo usuário
                {
                    case "Decimal": //base decimal
                        if (!Regex.IsMatch(txt_num1.Text, regexDecimal))  //verifica se os números passados estão em decimal, caso contrário exibe erro na tela
                        {
                            txt_num1.Focus();
                            throw new Exception("Número 1 não está no formato decimal! Digite apenas números positivos");
                        }
                        else if (!Regex.IsMatch(txt_num2.Text, regexDecimal))
                        {
                            txt_num2.Focus();
                            throw new Exception("Número 2 não está no formato decimal! Digite apenas números positivos");
                        }

                        int decimal_num1 = int.Parse(txt_num1.Text); //números passados pelo usuário nas variaveis
                        int decimal_num2 = int.Parse(txt_num2.Text);

                        switch (cbx_operacao.SelectedItem) //operação escolhida pelo usuário
                        {
                            case "+":
                                txt_resultado.Text = (decimal_num1 + decimal_num2).ToString(); //cálculo e exibição na tela
                                break;

                            case "-":
                                if (decimal_num1 < decimal_num2) //caso o número 2 seja maior que o número 1, exibe erro na tela (o programa não precisa fazer esta operação)
                                    MessageBox.Show("O programa não suporta esta operação! O Número 2 é maior que o Número 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    txt_resultado.Text = (decimal_num1 - decimal_num2).ToString();
                                break;

                            case "*":
                                txt_resultado.Text = (decimal_num1 * decimal_num2).ToString();
                                break;
                        }
                        break;

                    case "Binário": //base binária
                        if (!Regex.IsMatch(txt_num1.Text, regexBinario)) //verifica se os números passados estão em binário, caso contrário exibe erro na tela
                        {
                            txt_num1.Focus();
                            throw new Exception("Número 1 não está no formato binário! Digite apenas 0 e 1");
                        }
                        else if (!Regex.IsMatch(txt_num2.Text, regexBinario))
                        {
                            txt_num2.Focus();
                            throw new Exception("Número 2 não está no formato binário! Digite apenas 0 e 1");
                        }

                        int binario_num1 = Convert.ToInt32(txt_num1.Text, 2); //conversão dos números passados pelo usuário para binário
                        int binario_num2 = Convert.ToInt32(txt_num2.Text, 2);
                        string resultado, binarioNorm;

                        switch (cbx_operacao.SelectedItem) //operação escolhida pelo usuário
                        {
                            case "+":
                                resultado = Convert.ToString(binario_num1 + binario_num2, 2); //cálculo
                                while(resultado.Length % 4 != 0)
                                    resultado = "0" + resultado; //completando o binário incompleto com 0 a esquerda

                                binarioNorm = "";
                                for (int i = 0; i < resultado.Length; i += 4)
                                    binarioNorm += resultado.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                binarioNorm = binarioNorm.TrimEnd(); //removendo o espaço final do binário formatado
                                txt_resultado.Text = binarioNorm; //exibição na tela
                                break;

                            case "-":
                                if (binario_num1 < binario_num2) //caso o número 2 seja maior que o número 1, exibe erro na tela (o programa não precisa fazer esta operação)
                                    MessageBox.Show("O programa não suporta esta operação! O Número 2 é maior que o Número 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    resultado = Convert.ToString(binario_num1 - binario_num2, 2); //cálculo

                                    while (resultado.Length % 4 != 0)
                                        resultado = "0" + resultado; //completando o binário incompleto com 0 a esquerda

                                    binarioNorm = "";
                                    for (int i = 0; i < resultado.Length; i += 4)
                                        binarioNorm += resultado.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                    binarioNorm = binarioNorm.TrimEnd(); //removendo o espaço final do binário formatado
                                    txt_resultado.Text = binarioNorm; //exibição na tela
                                }
                                break;

                            case "*":
                                resultado = Convert.ToString(binario_num1 * binario_num2, 2); //cálculo

                                while (resultado.Length % 4 != 0)
                                    resultado = "0" + resultado; //completando o binário incompleto com 0 a esquerda

                                binarioNorm = "";
                                for (int i = 0; i < resultado.Length; i += 4)
                                    binarioNorm += resultado.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                binarioNorm = binarioNorm.TrimEnd(); //removendo o espaço final do binário formatado
                                txt_resultado.Text = binarioNorm; //exibição na tela
                                break;
                        }
                        break;

                    case "Hexadecimal": //base hexadecimal
                        if (!Regex.IsMatch(txt_num1.Text, regexHexa)) //verifica se os números passados estão em hexadecimal, caso contrário exibe erro na tela
                        {
                            txt_num1.Focus();
                            throw new Exception("Número 1 não está no formato hexadecimal! Digite apenas as letras A, B, C, D, E e F");
                        }
                        else if (!Regex.IsMatch(txt_num2.Text, regexHexa))
                        {
                            txt_num2.Focus();
                            throw new Exception("Número 2 não está no formato hexadecimal! Digite apenas as letras A, B, C, D, E e F");
                        }

                        int hexa_num1 = Convert.ToInt32(txt_num1.Text.ToLower(), 16); //conversão dos números passados pelo usuário para hexadecimal
                        int hexa_num2 = Convert.ToInt32(txt_num2.Text.ToLower(), 16);

                        switch (cbx_operacao.SelectedItem) //operação escolhida pelo usuário
                        {
                            case "+":
                                txt_resultado.Text = (hexa_num1 + hexa_num2).ToString("x").ToUpper(); //cálculo e exibição na tela
                                break;

                            case "-":
                                if (hexa_num1 < hexa_num2) //caso o número 2 seja maior que o número 1, exibe erro na tela (o programa não precisa fazer esta operação)
                                    MessageBox.Show("O programa não suporta esta operação! O Número 2 é maior que o Número 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    txt_resultado.Text = (hexa_num1 - hexa_num2).ToString("x").ToUpper();
                                break;

                            case "*":
                                txt_resultado.Text = (hexa_num1 * hexa_num2).ToString("x").ToUpper();
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}