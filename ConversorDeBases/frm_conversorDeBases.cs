namespace ConversorDeBases
{
    public partial class frm_conversorDeBases : Form
    {
        public frm_conversorDeBases()
        {
            InitializeComponent();
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            if (rbt_binario.Checked) //decimal -> binario
            {
                int quoc = int.Parse(txt_decimal.Text);
                string resto = "";
                string resultado = $"({quoc}){(char)('₀' + 1)}{(char)('₀' + 0)} = ";

                while (quoc != 0)
                {
                    resto = resto.Insert(0, (quoc % 2).ToString());//inserir sempre na frente
                    resultado += $"({quoc} / 2  = {quoc / 2} Resto = {quoc % 2}), ";
                    quoc /= 2;
                }

                resultado += $" = ({resto}){(char)('₀' + 2)}";
                txt_resultado.Text = resultado;
            }
            else if (rbt_hexa.Checked) //decimal -> hexa
            {
                
            }
        }
    }
}