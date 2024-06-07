using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ConversorDeBases
{
    public partial class frm_conversorDeBases : Form
    {
        public frm_conversorDeBases()
        {
            InitializeComponent();
        }

        string regexDecimal = @"^[0-9]\d*$";
        string regexBinario = @"^[0-1]*$";
        string regexHexa = @"^[A-Fa-f0-9]*$";

        private void Limpar()
        {
            ltx_passo.Items.Clear();
            txt_resultado.Clear();
            txt_num.Focus();
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

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Limpar();
            txt_num.Clear();
            frm_calculadoraDeBases frm_calculadoraBases = new frm_calculadoraDeBases();
            frm_calculadoraBases.ShowDialog();
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            Limpar(); //limpando o passo a passo

            try
            {
                RadioButton rbt_baseNumero = panel_baseNumero.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); //inserindo na variável o radio button selecionado - base do número inserido
                RadioButton rbt_baseFinal = panel_baseFinal.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); //inserindo na variável o radio button selecionado - base desejada para conversão

                switch (rbt_baseNumero.Text) //base do número inserido pelo usuário
                {
                    case "Decimal": //base decimal
                        if (!Regex.IsMatch(txt_num.Text, regexDecimal)) //se o número não estiver na base decimal, exibir um erro
                            throw new Exception("O número informado não está na base decimal!"); //erro

                        switch (rbt_baseFinal.Text) //base desejada para conversão
                        {
                            case "Decimal": //decimal -> decimal
                                throw new Exception("O número já está na base decimal!"); //erro se tentar converter o número em decimal para decimal

                            case "Binário": //decimal -> binário

                                int quoc = int.Parse(txt_num.Text); //quociente = numero passado pelo usuario
                                string resto = "";
                                ltx_passo.Items.Add($"({quoc}){(char)('₀' + 1)}{(char)('₀' + 0)} = "); //inicio do passo a passo

                                if (quoc != 0) //se o quociente for 0, o resto vai ser 0
                                {
                                    while (quoc != 0) //enquanto o quociente não for 0, continuar a divisão
                                    {
                                        resto = resto.Insert(0, (quoc % 2).ToString()); //resto é o digito mais a direita, incrementando ao resto
                                        ltx_passo.Items.Add($"{quoc} / 2  = {quoc / 2}, Resto = {quoc % 2}"); //adicionando ao passo a passo
                                        quoc /= 2; //quociente divido por 2
                                    }
                                }
                                else
                                    resto = "0";

                                //normalizando o número binário
                                while (resto.Length % 4 != 0)
                                    resto = "0" + resto; //completando o binário incompleto com 0 a esquerda

                                string resultadoString = "";
                                for (int i = 0; i < resto.Length; i += 4)
                                    resultadoString += resto.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                resultadoString = resultadoString.TrimEnd(); //removendo o espaço do final do resultado

                                ltx_passo.Items.Add($"= ({resultadoString}){(char)('₀' + 2)}"); //final do passo a passo é o resultado
                                txt_resultado.Text = resultadoString; //exibindo o resultado de forma destacada

                            break;

                            case "Hexadecimal": //decimal -> hexa

                                quoc = int.Parse(txt_num.Text); //quociente = numero passado pelo usuario
                                resto = "";
                                ltx_passo.Items.Add($"({quoc}){(char)('₀' + 1)}{(char)('₀' + 0)} = "); //inicio do passo a passo

                                if (quoc != 0) //se o quociente for 0, o resto vai ser 0
                                {
                                    while (quoc != 0) //enquanto o quociente não for 0, continuar a divisão
                                    {
                                        switch (quoc % 16) //caso o quociente for maior que 9, inserir a letra correspondente em hexa
                                        {
                                            case 10:
                                                resto = resto.Insert(0, "A"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> A"); //adicionando ao passo a passo
                                                break;

                                            case 11:
                                                resto = resto.Insert(0, "B"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> B"); //adicionando ao passo a passo
                                                break;

                                            case 12:
                                                resto = resto.Insert(0, "C"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> C"); //adicionando ao passo a passo
                                                break;

                                            case 13:
                                                resto = resto.Insert(0, "D"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> D"); //adicionando ao passo a passo
                                                break;

                                            case 14:
                                                resto = resto.Insert(0, "E"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> E"); //adicionando ao passo a passo
                                                break;

                                            case 15:
                                                resto = resto.Insert(0, "F"); //resto é o digito mais a direita, incrementando ao resto
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16} -> F"); //adicionando ao passo a passo
                                                break;

                                            default:
                                                resto = resto.Insert(0, (quoc % 16).ToString()); //resto é o digito mais a direita
                                                ltx_passo.Items.Add($"{quoc} / 16 = {quoc / 16}, Resto = {quoc % 16}"); //adicionando ao passo a passo
                                                break;
                                        }

                                        quoc /= 16; //dividindo o quociente por 16
                                    }
                                }
                                else
                                    resto = "0";

                                ltx_passo.Items.Add($"= ({resto}){(char)('₀' + 1)}{(char)('₀' + 6)}"); //final do passo a passo exibindo o resultado
                                txt_resultado.Text = resto; //exibindo o resultado de forma destacada

                            break;
                        }
                    break;

                    case "Binário": //base binária
                        string binario = txt_num.Text.Replace(" ", "").Trim(); //binario passado pelo usuario, removendo os espaços em branco

                        if (txt_num.Text == string.Empty || !Regex.IsMatch(binario, regexBinario)) //se o número não estiver na base binária ou vazio, exibir um erro
                            throw new Exception("O número informado não está na base binária!"); //erro

                        switch (rbt_baseFinal.Text) //base desejada para conversão
                        {
                            case "Decimal": //binário -> decimal

                                string binarioEx = binario; //binario para exibição
                                string soma = ""; //string da soma feita para ser exibida no final
                                int resultadoInt = 0; //resultado final
                                int calcFor; //cálculo do binário para decimal

                                //normalizando o número binário
                                while (binarioEx.Length % 4 != 0)
                                    binarioEx = "0" + binarioEx; //completando o binário incompleto com 0 a esquerda

                                string binarioNormalizado = "";
                                for (int i = 0; i < binarioEx.Length; i += 4)
                                    binarioNormalizado += binarioEx.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                binarioNormalizado = binarioNormalizado.TrimEnd(); //removendo o espaço do final do resultado

                                ltx_passo.Items.Add($"({binarioNormalizado}){(char)('₀' + 2)} = "); //inicio do passo a passo

                                while (binario.StartsWith("0"))
                                    binario = binario.Substring(1); //removendo os 0 a esquerda que são desnecessários para a conversão

                                for (int i = 0; i < binario.Length; i++) //para cada bit do binário
                                {
                                    calcFor = int.Parse(binario[i].ToString()) * (int)Math.Pow(2, binario.Length - 1 - i); //resultado = bit vezes 2 elevado a posição do bit
                                    ltx_passo.Items.Add($"{binario[i]}.2{ToSuperScript(binario.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                    resultadoInt += calcFor; //somando ao resultado o cálculo realizado acima
                                    if (calcFor != 0) //se o resultado da conta for diferente de 0, exibir na soma
                                    {
                                        if (soma == "") //se for o primeiro número a ser exibido na soma, remover o +
                                            soma += $"{calcFor}";
                                        else
                                            soma += $" + {calcFor}";
                                    }
                                }

                                ltx_passo.Items.Add($"{soma} = ({resultadoInt}){(char)('₀' + 1)}{(char)('₀' + 0)}"); //final do passo a passo exibindo o resultado
                                txt_resultado.Text = resultadoInt.ToString(); //mostrando o resultado final de forma destacada

                            break;

                            case "Binário": //binário -> binário
                                throw new Exception("O número já está na base binária!"); //erro se tentar converter o número em binário para binário

                            case "Hexadecimal": //binário -> hexa

                                string sub; //string para a divisão do binário em 4 bits
                                int num; //numero retornado da conversão do binário para decimal
                                string resultadoString = ""; //resultado em hexadecimal

                                //normalizando o número binário
                                while (binario.Length % 4 != 0)
                                    binario = "0" + binario; //completando o binário incompleto com 0 a esquerda

                                binarioEx = binario; //binario para a exibição é o binário ja com 0 a esquerda
                                binarioNormalizado = "";
                                for (int i = 0; i < binarioEx.Length; i += 4)
                                    binarioNormalizado += binarioEx.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                binarioNormalizado = binarioNormalizado.TrimEnd(); //removendo o espaço do final do resultado

                                ltx_passo.Items.Add($"({binarioNormalizado}){(char)('₀' + 2)} = "); //inicio do passo a passo

                                for (int i = 0; i < binario.Length; i += 4)
                                {
                                    sub = binario.Substring(i, 4); //string binaria dividida em 4

                                    if (sub != "0000") //se o binário for 0, não entra na conta
                                    {
                                        num = 0;
                                        soma = ""; //string da soma feita para ser exibida no final

                                        if (sub != binario) //se o binário passado tiver apenas 4 bits, remover do passo a passo a divisão do binário
                                            ltx_passo.Items.Add($"({sub}){(char)('₀' + 2)} = ");

                                        for (int j = 0; j < sub.Length; j++) //para cada bit do binario dividido
                                        {
                                            calcFor = int.Parse(sub[j].ToString()) * (int)Math.Pow(2, sub.Length - 1 - j); //convertendo cada bit do binario dividido para hexadecimal
                                            ltx_passo.Items.Add($"{sub[j]}.2{ToSuperScript(sub.Length - 1 - j)} = {calcFor}"); //inserindo no passo a passo a conta acima
                                            num += calcFor; //somando o resultado da conta do bit atual a soma total
                                            if (calcFor != 0) //se o resultado da conta for diferente de 0, exibir na soma
                                            {
                                                if (soma == "") //se for o primeiro número a ser exibido na soma, remover o +
                                                    soma += $"{calcFor}";
                                                else
                                                    soma += $" + {calcFor}";
                                            }
                                        }

                                        switch (num) //caso o resultado da conversão seja maior que 10, mostrar a letra correspondente em hexa no passo a passo
                                        {
                                            case 10:
                                                resultadoString += "A";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (A){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            case 11:
                                                resultadoString += "B";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (B){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            case 12:
                                                resultadoString += "C";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (C){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            case 13:
                                                resultadoString += "D";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (D){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            case 14:
                                                resultadoString += "E";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (E){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            case 15:
                                                resultadoString += "F";
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)} -> (F){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando a letra convertida do binario dividido
                                                break;

                                            default:
                                                resultadoString += num.ToString(); //adicionando o número convertido ao resultado final
                                                ltx_passo.Items.Add($"{soma} = ({num}){(char)('₀' + 1)}{(char)('₀' + 6)}"); //mostrando o numero convertido do binario dividido
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        ltx_passo.Items.Add($"({sub}){(char)('₀' + 2)} = (0){(char)('₀' + 1)}{(char)('₀' + 6)}"); //adicionando o número 0 ao passo a passo sem a realização da conta e ao resultado
                                        resultadoString += "0";
                                    }
                                }

                                ltx_passo.Items.Add($"= ({resultadoString}){(char)('₀' + 1)}{(char)('₀' + 6)}"); //final do passo a passo com o resultado
                                txt_resultado.Text = resultadoString; //exibindo o resultado final de forma destacada

                            break;
                        }
                    break;

                    case "Hexadecimal": //base hexa
                        if (txt_num.Text == string.Empty || !Regex.IsMatch(txt_num.Text, regexHexa)) //se o número não estiver na base decimal, exibir um erro
                            throw new Exception("O número informado não está na base hexadecimal!");

                        switch (rbt_baseFinal.Text) //base desejada para conversão
                        {
                            case "Decimal": //hexa -> decimal

                                string hexa = txt_num.Text.ToUpper(); //hexadecimal passado pelo usuário, com as letras maiúsculas
                                string soma = ""; //string da soma dos números convertidos do hexa
                                int resultadoInt = 0; //resultado final
                                int calcFor; //calculo do hexa para decimal
                                ltx_passo.Items.Add($"({hexa}){(char)('₀' + 1)}{(char)('₀' + 6)} ="); //inicio do passo a passo

                                for (int i = 0; i < hexa.Length; i++) //para cada bit do hexadecimal
                                {
                                    switch (hexa[i]) //caso o bit seja uma letra, adicionar ao resultado o número correspondente
                                    {
                                        case 'A':
                                            calcFor = 10 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"A.16{ToSuperScript(hexa.Length - 1 - i)} -> 10.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case 'B':
                                            calcFor = 11 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"B.16{ToSuperScript(hexa.Length - 1 - i)} -> 11.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case 'C':
                                            calcFor = 12 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"C.16{ToSuperScript(hexa.Length - 1 - i)} -> 12.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case 'D':
                                            calcFor = 13 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"D.16{ToSuperScript(hexa.Length - 1 - i)} -> 13.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case 'E':
                                            calcFor = 14 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"E.16{ToSuperScript(hexa.Length - 1 - i)} -> 14.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case 'F':
                                            calcFor = 15 * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"F.16{ToSuperScript(hexa.Length - 1 - i)} -> 15.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;

                                        case '0': //se o bit do hexa for 0, não exibir o cálculo
                                            calcFor = 0;
                                            break;

                                        default:
                                            calcFor = int.Parse(hexa[i].ToString()) * (int)Math.Pow(16, hexa.Length - 1 - i); //resultado = bit vezes 16 elevado a posição do bit
                                            ltx_passo.Items.Add($"{hexa[i]}.16{ToSuperScript(hexa.Length - 1 - i)} = {calcFor}"); //passo a passo demonstrando a operação acima, utilizando a função ToSuperScript para adicionar o char do número elevado
                                            resultadoInt += calcFor; //adicionando ao resultado final a conta do bit atual do hexa
                                            break;
                                    }

                                    if (calcFor != 0) //se o resultado da conta for diferente de 0, exibir na soma
                                    {
                                        if (soma == "") //se for o primeiro número a ser exibido na soma, remover o +
                                            soma += $"{calcFor}";
                                        else
                                            soma += $" + {calcFor}";
                                    }
                                }

                                ltx_passo.Items.Add($"{soma} = ({resultadoInt}){(char)('₀' + 1)}{(char)('₀' + 0)}"); //fim do passo a passo
                                txt_resultado.Text = resultadoInt.ToString(); //exibindo o resultado final destacado

                            break;

                            case "Binário": //hexa -> binário

                                hexa = txt_num.Text.ToUpper(); //hexadecimal passado pelo usuário, com as letras maiúsculas
                                string resultadoString = ""; //resultado final
                                string binarioNorm; //binário formatado para exibição
                                ltx_passo.Items.Add($"({hexa}){(char)('₀' + 1)}{(char)('₀' + 6)} = "); //inicio do passo a passo

                                for (int i = 0; i < hexa.Length; i++) //para cada bit em hexadecimal
                                {
                                    int quoc;
                                    string resto = "";

                                    switch (hexa[i]) //caso o bit em hexa seja uma letra, resultado sera o binario correspondente a letra
                                    {
                                        case 'A':
                                            resultadoString += "1010"; //10 em binario
                                            quoc = 10;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 10 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case 'B':
                                            resultadoString += "1011"; //11 em binario
                                            quoc = 11;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 11 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case 'C':
                                            resultadoString += "1100"; //12 em binario
                                            quoc = 12;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 12 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case 'D':
                                            resultadoString += "1101"; //13 em binario
                                            quoc = 13;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 13 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case 'E':
                                            resultadoString += "1110"; //14 em binario
                                            quoc = 14;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 14 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case 'F':
                                            resultadoString += "1111"; //15 em binario
                                            quoc = 15;
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} -> 15 ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;

                                        case '0': //caso o bit em hexa for 0, inserir direto no resultado, sem fazer o calculo
                                            quoc = 0;
                                            resto += "0";
                                            resultadoString += "0000";
                                            break;

                                        default:
                                            //convertendo de hexa para binario
                                            quoc = int.Parse(hexa[i].ToString());
                                            binarioNorm = Convert.ToString(Convert.ToInt32(hexa[i].ToString(), 16), 2); //convertendo hexa em binário
                                                                                                                        //normalizando o número binário
                                            while (binarioNorm.Length % 4 != 0)
                                                binarioNorm = "0" + binarioNorm; //completando o binário incompleto com 0 a esquerda
                                            resultadoString += binarioNorm; //adicionando o binário completo ao resultado
                                            ltx_passo.Items.Add($"({hexa[i]}){(char)('₀' + 1)}{(char)('₀' + 6)} ="); //mostrando no passo a passo a conversão de cada bit para binario
                                            break;
                                    }

                                    while (quoc != 0) //enquanto o quociente não for 0, continuar a divisão
                                    {
                                        resto = resto.Insert(0, (quoc % 2).ToString()); //resto é o digito mais a direita, incrementando ao resto
                                        ltx_passo.Items.Add($"{quoc} / 2  = {quoc / 2}, Resto = {quoc % 2}"); //adicionando ao passo a passo
                                        quoc /= 2; //quociente divido por 2
                                    }

                                    while (resto.Length % 4 != 0)
                                        resto = "0" + resto; //completando o resto incompleto com 0 a esquerda

                                    ltx_passo.Items.Add($"= ({resto}){(char)('₀' + 2)}"); //final do passo a passo exibindo o resultado do bit em hexa convertido
                                }

                                binarioNorm = "";
                                for (int i = 0; i < resultadoString.Length; i += 4)
                                    binarioNorm += resultadoString.Substring(i, 4) + " "; //separando o binário de 4 em 4 bits

                                binarioNorm = binarioNorm.TrimEnd(); //removendo o espaço final do binário formatado
                                ltx_passo.Items.Add($"= ({binarioNorm}){(char)('₀' + 2)}"); //fim do passo a passo exibindo o resultado
                                txt_resultado.Text = binarioNorm; //exibindo o resultado final de forma destacada

                            break;

                            case "Hexadecimal": //hexa -> hexa
                                throw new Exception("O número já está na base hexadecimal!"); //erro se tentar converter o número em hexadecimal para hexadecimal
                        }
                    break;
                }
            }
            catch (Exception ex)
            {
                Limpar();
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
            }
        }
    }
}