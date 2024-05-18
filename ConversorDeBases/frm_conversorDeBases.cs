namespace ConversorDeBases
{
    public partial class frm_conversorDeBases : Form
    {
        public frm_conversorDeBases()
        {
            InitializeComponent();
        }

        public string ToSuperScript(int number)
        {
            const string SuperscriptDigits = "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = "";

            if (number < 0)
            {
                //Adds superscript minus
                superscript = ((char)0x207B).ToString();
                number *= -1;
            }

            superscript += new string(number.ToString()
                                            .Select(x => SuperscriptDigits[x - '0'])
                                            .ToArray()
                                      );

            return superscript;
        }

        private void btn_converter_decimal_Click(object sender, EventArgs e)
        {
            if (rbt_binario_dec.Checked) //decimal -> binario
            {
                int quoc = int.Parse(txt_decimal.Text); //quociente = numero passado pelo usuario
                string resto = "";
                string passo = $"({quoc}){(char)('₀' + 1)}{(char)('₀' + 0)} = "; //inicio do passo a passo

                while (quoc != 0) //enquanto o quociente não for 0, continuar a divisão
                {
                    resto = resto.Insert(0, (quoc % 2).ToString()); //resto é o digito mais a direita, incrementando ao resto
                    passo += $"({quoc} / 2  = {quoc / 2} Resto = {quoc % 2}), "; //adicionando ao passo a passo
                    quoc /= 2; //quociente divido por 2
                }

                passo += $"= ({resto}){(char)('₀' + 2)}"; //final do passo a passo é o resultado
                txt_resultado.Text = resto; //resultado final é o resto final
                txt_passo.Text = passo;
            }
            else if (rbt_hexa_dec.Checked) //decimal -> hexa
            {
                int quoc = int.Parse(txt_decimal.Text); //quociente = numero passado pelo usuario
                string resto = "";
                string passo = $"({quoc}){(char)('₀' + 1)}{(char)('₀' + 0)} = "; //inicio do passo a passo

                while (quoc != 0) //enquanto o quociente não for 0, continuar a divisão
                {
                    if (quoc % 16 >= 10) //se o resto for maior que 10, substituir pela letra correspondente em hexadecimal
                    {
                        switch (quoc % 16)
                        {
                            case 10:
                                resto = resto.Insert(0, "A"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = A), "; //adicionando ao passo a passo
                                break;

                            case 11:
                                resto = resto.Insert(0, "B"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = B), "; //adicionando ao passo a passo
                                break;

                            case 12:
                                resto = resto.Insert(0, "C"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = C), "; //adicionando ao passo a passo
                                break;

                            case 13:
                                resto = resto.Insert(0, "D"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = D), "; //adicionando ao passo a passo
                                break;

                            case 14:
                                resto = resto.Insert(0, "E"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = E), "; //adicionando ao passo a passo
                                break;

                            case 15:
                                resto = resto.Insert(0, "F"); //resto é o digito mais a direita, incrementando ao resto
                                passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16} = F), "; //adicionando ao passo a passo
                                break;
                        }
                    }
                    else
                    {
                        resto = resto.Insert(0, (quoc % 16).ToString()); //resto é o digito mais a direita
                        passo += $"({quoc} / 16 = {quoc / 16} Resto = {quoc % 16}), "; //adicionando ao passo a passo
                    }

                    quoc /= 16; //dividindo o quociente por 16
                }

                passo += $"= ({resto}){(char)('₀' + 1)}{(char)('₀' + 6)}"; //final do passo a passo é o resultado
                txt_resultado.Text = resto; //resultado é o resto final
                txt_passo.Text = passo;
            }
        }

        private void btn_converter_binario_Click(object sender, EventArgs e)
        {
            if (rbt_decimal_bin.Checked) //binario -> decimal
            {
                string binario = txt_binario.Text; //binario passado pelo usuario
                int resultado = 0;
                string passo = $"({binario}){(char)('₀' + 2)} = "; //inicio do passo a passo

                for (int i = 0; i < binario.Length; i++) //para cada bit do binário
                {
                    resultado += int.Parse(binario[i].ToString()) * (int)Math.Pow(2, binario.Length - 1 - i); //resultado = bit vezes 2 elevado a posição do bit
                    passo += $"{binario[i]}.2{ToSuperScript(binario.Length - 1 - i)} + "; //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                }

                passo += $"= ({resultado}){(char)('₀' + 1)}{(char)('₀' + 0)}"; //final do passo a passo
                txt_resultado.Text = resultado.ToString();
                txt_passo.Text = passo;
            }
            else if (rbt_hexa_bin.Checked) //binario -> hexa
            {
                string binario = txt_binario.Text; //binario passado pelo usuario
                string sub; //string para a divisão do binário em 4 bits
                int num; //numero retornado da conversão do binário para decimal
                string resultado = ""; //resultado em hexadecimal
                string passo = $"({binario}){(char)('₀' + 2)} = "; //inicio do passo a passo

                if (binario.Length % 4 != 0) //se nao for possivel dividir o binario em 4 bits, completar com 0 a esquerda
                {
                    int qtd = 4 - (binario.Length % 4);

                    for (int i = 0; i < qtd; i++)
                        binario = binario.Insert(0, "0");

                    passo += $"({binario}){(char)('₀' + 2)}. "; //mostrando no passo a passo o binario completado
                }

                for (int i = 0; i < binario.Length; i += 4)
                {
                    sub = binario.Substring(i, 4); //string binaria dividida em 4
                    num = 0;

                    passo += $"({sub}){(char)('₀' + 2)} = ";

                    for (int j = 0; j < sub.Length; j++)
                    {
                        num += int.Parse(sub[j].ToString()) * (int)Math.Pow(2, sub.Length - 1 - j); //convertendo cada bit do binario dividido para hexadecimal
                    }

                    if (num >= 10) //se o numero convertido for maior que 10, alterar pela letra correspondente em hexadecimal
                    {
                        switch (num)
                        {
                            case 10:
                                resultado += "A";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (A){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;

                            case 11:
                                resultado += "B";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (B){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;

                            case 12:
                                resultado += "C";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (C){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;

                            case 13:
                                resultado += "D";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (D){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;

                            case 14:
                                resultado += "E";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (E){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;

                            case 15:
                                resultado += "F";
                                passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)} = (F){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando a letra convertida do binario dividido
                                break;
                        }
                    }
                    else
                    {
                        resultado += num.ToString(); //adicionando o número convertido ao resultado final
                        passo += $"({num}){(char)('₀' + 1)}{(char)('₀' + 6)}. "; //mostrando o numero convertido do binario dividido
                    }
                }

                passo += $"= ({resultado}){(char)('₀' + 1)}{(char)('₀' + 6)}";
                txt_resultado.Text = resultado;
                txt_passo.Text = passo;
            }
        }

        private void btn_converter_hexa_Click(object sender, EventArgs e)
        {
            if (rbt_decimal_hexa.Checked) //hexa -> decimal
            {
                string hexa = txt_hexa.Text; //hexadecimal passado pelo usuário
                int resultado = 0; //resultado final
                string passo = $"({hexa}){(char)('₀' + 1)}{(char)('₀' + 6)} = "; //inicio do passo a passo

                for (int i = 0; i < hexa.Length; i++) //para cada bit do hexadecimal
                {
                    switch (hexa[i]) //caso o bit seja uma letra, adicionar ao resultado o número correspondente
                    {
                        case 'A':
                            resultado += 10 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"10.16{ToSuperScript(hexa.Length - 1 - i)} + "; //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                            break;

                        case 'B':
                            resultado += 11 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"11.16{ToSuperScript(hexa.Length - 1 - i)} + ";
                            break;

                        case 'C':
                            resultado += 12 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"12.16{ToSuperScript(hexa.Length - 1 - i)} + ";
                            break;

                        case 'D':
                            resultado += 13 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"13.16{ToSuperScript(hexa.Length - 1 - i)} + ";
                            break;

                        case 'E':
                            resultado += 14 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"14.16{ToSuperScript(hexa.Length - 1 - i)} + ";
                            break;

                        case 'F':
                            resultado += 15 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"15.16{ToSuperScript(hexa.Length - 1 - i)} + ";
                            break;

                        default:
                            resultado += int.Parse(hexa[i].ToString()) * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                            passo += $"{hexa[i]}.16{ToSuperScript(hexa.Length - 1 - i)} + "; //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                            break;
                    }
                }

                passo += $"= ({resultado}){(char)('₀' + 1)}{(char)('₀' + 0)}"; //fim do passo a passo

                txt_resultado.Text = resultado.ToString();
                txt_passo.Text = passo;
            }
            else if (rbt_binario_hexa.Checked) //hexa -> binario
            {

            }
        }
    }
}