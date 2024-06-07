namespace ConversorDeBases
{
    partial class frm_calculadoraDeBases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_num1 = new TextBox();
            panel_rbts = new Panel();
            rbt_hexa = new RadioButton();
            rbt_binario = new RadioButton();
            rbt_decimal = new RadioButton();
            txt_num2 = new TextBox();
            txt_resultado = new TextBox();
            btn_voltar = new Button();
            btn_calcular = new Button();
            cbx_operacao = new ComboBox();
            lbl_base = new Label();
            panel_rbts.SuspendLayout();
            SuspendLayout();
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(20, 190);
            txt_num1.Name = "txt_num1";
            txt_num1.PlaceholderText = "Número 1";
            txt_num1.Size = new Size(349, 23);
            txt_num1.TabIndex = 20;
            // 
            // panel_rbts
            // 
            panel_rbts.Controls.Add(rbt_hexa);
            panel_rbts.Controls.Add(rbt_binario);
            panel_rbts.Controls.Add(rbt_decimal);
            panel_rbts.Location = new Point(20, 145);
            panel_rbts.Name = "panel_rbts";
            panel_rbts.Size = new Size(349, 39);
            panel_rbts.TabIndex = 19;
            // 
            // rbt_hexa
            // 
            rbt_hexa.AutoSize = true;
            rbt_hexa.Location = new Point(239, 10);
            rbt_hexa.Name = "rbt_hexa";
            rbt_hexa.Size = new Size(94, 19);
            rbt_hexa.TabIndex = 22;
            rbt_hexa.Text = "Hexadecimal";
            rbt_hexa.UseVisualStyleBackColor = true;
            // 
            // rbt_binario
            // 
            rbt_binario.AutoSize = true;
            rbt_binario.Location = new Point(130, 10);
            rbt_binario.Name = "rbt_binario";
            rbt_binario.Size = new Size(62, 19);
            rbt_binario.TabIndex = 18;
            rbt_binario.Text = "Binário";
            rbt_binario.UseVisualStyleBackColor = true;
            // 
            // rbt_decimal
            // 
            rbt_decimal.AutoSize = true;
            rbt_decimal.Checked = true;
            rbt_decimal.Location = new Point(15, 10);
            rbt_decimal.Name = "rbt_decimal";
            rbt_decimal.Size = new Size(68, 19);
            rbt_decimal.TabIndex = 17;
            rbt_decimal.TabStop = true;
            rbt_decimal.Text = "Decimal";
            rbt_decimal.UseVisualStyleBackColor = true;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(20, 219);
            txt_num2.Name = "txt_num2";
            txt_num2.PlaceholderText = "Número 2";
            txt_num2.Size = new Size(349, 23);
            txt_num2.TabIndex = 22;
            // 
            // txt_resultado
            // 
            txt_resultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_resultado.Location = new Point(432, 200);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(349, 39);
            txt_resultado.TabIndex = 25;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(20, 280);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(349, 26);
            btn_voltar.TabIndex = 26;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(20, 248);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(349, 26);
            btn_calcular.TabIndex = 27;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // cbx_operacao
            // 
            cbx_operacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_operacao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbx_operacao.FormattingEnabled = true;
            cbx_operacao.Items.AddRange(new object[] { "+", "-", "*" });
            cbx_operacao.Location = new Point(376, 199);
            cbx_operacao.Name = "cbx_operacao";
            cbx_operacao.Size = new Size(50, 40);
            cbx_operacao.TabIndex = 28;
            // 
            // lbl_base
            // 
            lbl_base.AutoSize = true;
            lbl_base.Location = new Point(20, 127);
            lbl_base.Name = "lbl_base";
            lbl_base.Size = new Size(128, 15);
            lbl_base.TabIndex = 29;
            lbl_base.Text = "O número está na base";
            // 
            // frm_calculadoraDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_base);
            Controls.Add(cbx_operacao);
            Controls.Add(btn_calcular);
            Controls.Add(btn_voltar);
            Controls.Add(txt_resultado);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(panel_rbts);
            MinimumSize = new Size(816, 489);
            Name = "frm_calculadoraDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Bases";
            Load += frm_calculadoraDeBases_Load;
            panel_rbts.ResumeLayout(false);
            panel_rbts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_num1;
        private Panel panel_rbts;
        private RadioButton rbt_binario;
        private RadioButton rbt_decimal;
        private RadioButton rbt_hexa;
        private TextBox txt_num2;
        private TextBox txt_resultado;
        private Button btn_voltar;
        private Button btn_calcular;
        private ComboBox cbx_operacao;
        private Label lbl_base;
    }
}