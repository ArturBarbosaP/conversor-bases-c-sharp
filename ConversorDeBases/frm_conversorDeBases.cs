namespace ConversorDeBases
{
    public partial class frm_conversorDeBases : Form
    {
        public frm_conversorDeBases()
        {
            InitializeComponent();
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
    }
}