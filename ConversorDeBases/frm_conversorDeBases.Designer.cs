namespace ConversorDeBases
{
    partial class frm_conversorDeBases
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_resultado = new TextBox();
            rbt_decimalNum = new RadioButton();
            txt_num = new TextBox();
            panel_baseNumero = new Panel();
            rbt_binarioNum = new RadioButton();
            rbt_hexaNum = new RadioButton();
            btn_calculadora = new Button();
            ltx_passo = new ListBox();
            lbl_baseNum = new Label();
            lbl_baseFinal = new Label();
            panel_baseFinal = new Panel();
            rbt_binarioFinal = new RadioButton();
            rbt_hexaFinal = new RadioButton();
            rbt_decimalFinal = new RadioButton();
            btn_converter = new Button();
            panel_baseNumero.SuspendLayout();
            panel_baseFinal.SuspendLayout();
            SuspendLayout();
            // 
            // txt_resultado
            // 
            txt_resultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(346, 25);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(439, 39);
            txt_resultado.TabIndex = 0;
            // 
            // rbt_decimalNum
            // 
            rbt_decimalNum.AutoSize = true;
            rbt_decimalNum.Checked = true;
            rbt_decimalNum.Location = new Point(13, 10);
            rbt_decimalNum.Name = "rbt_decimalNum";
            rbt_decimalNum.Size = new Size(68, 19);
            rbt_decimalNum.TabIndex = 0;
            rbt_decimalNum.TabStop = true;
            rbt_decimalNum.Text = "Decimal";
            rbt_decimalNum.UseVisualStyleBackColor = true;
            // 
            // txt_num
            // 
            txt_num.Location = new Point(16, 115);
            txt_num.Name = "txt_num";
            txt_num.PlaceholderText = "Número";
            txt_num.Size = new Size(303, 23);
            txt_num.TabIndex = 5;
            // 
            // panel_baseNumero
            // 
            panel_baseNumero.Controls.Add(rbt_binarioNum);
            panel_baseNumero.Controls.Add(rbt_hexaNum);
            panel_baseNumero.Controls.Add(rbt_decimalNum);
            panel_baseNumero.Location = new Point(16, 70);
            panel_baseNumero.Name = "panel_baseNumero";
            panel_baseNumero.Size = new Size(303, 39);
            panel_baseNumero.TabIndex = 4;
            // 
            // rbt_binarioNum
            // 
            rbt_binarioNum.AutoSize = true;
            rbt_binarioNum.Location = new Point(107, 10);
            rbt_binarioNum.Name = "rbt_binarioNum";
            rbt_binarioNum.Size = new Size(62, 19);
            rbt_binarioNum.TabIndex = 2;
            rbt_binarioNum.Text = "Binário";
            rbt_binarioNum.UseVisualStyleBackColor = true;
            // 
            // rbt_hexaNum
            // 
            rbt_hexaNum.AutoSize = true;
            rbt_hexaNum.Location = new Point(195, 10);
            rbt_hexaNum.Name = "rbt_hexaNum";
            rbt_hexaNum.Size = new Size(94, 19);
            rbt_hexaNum.TabIndex = 1;
            rbt_hexaNum.Text = "Hexadecimal";
            rbt_hexaNum.UseVisualStyleBackColor = true;
            // 
            // btn_calculadora
            // 
            btn_calculadora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_calculadora.Location = new Point(12, 400);
            btn_calculadora.Name = "btn_calculadora";
            btn_calculadora.Size = new Size(303, 26);
            btn_calculadora.TabIndex = 10;
            btn_calculadora.Text = "Calculadora";
            btn_calculadora.UseVisualStyleBackColor = true;
            btn_calculadora.Click += btn_calculadora_Click;
            // 
            // ltx_passo
            // 
            ltx_passo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ltx_passo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltx_passo.FormattingEnabled = true;
            ltx_passo.HorizontalScrollbar = true;
            ltx_passo.ItemHeight = 32;
            ltx_passo.Location = new Point(346, 70);
            ltx_passo.Name = "ltx_passo";
            ltx_passo.SelectionMode = SelectionMode.None;
            ltx_passo.Size = new Size(439, 356);
            ltx_passo.TabIndex = 12;
            // 
            // lbl_baseNum
            // 
            lbl_baseNum.AutoSize = true;
            lbl_baseNum.Location = new Point(16, 49);
            lbl_baseNum.Name = "lbl_baseNum";
            lbl_baseNum.Size = new Size(147, 15);
            lbl_baseNum.TabIndex = 14;
            lbl_baseNum.Text = "Converter número da base";
            // 
            // lbl_baseFinal
            // 
            lbl_baseFinal.AutoSize = true;
            lbl_baseFinal.Location = new Point(16, 141);
            lbl_baseFinal.Name = "lbl_baseFinal";
            lbl_baseFinal.Size = new Size(112, 15);
            lbl_baseFinal.TabIndex = 15;
            lbl_baseFinal.Text = "Converter para base";
            // 
            // panel_baseFinal
            // 
            panel_baseFinal.Controls.Add(rbt_binarioFinal);
            panel_baseFinal.Controls.Add(rbt_hexaFinal);
            panel_baseFinal.Controls.Add(rbt_decimalFinal);
            panel_baseFinal.Location = new Point(16, 159);
            panel_baseFinal.Name = "panel_baseFinal";
            panel_baseFinal.Size = new Size(303, 39);
            panel_baseFinal.TabIndex = 5;
            // 
            // rbt_binarioFinal
            // 
            rbt_binarioFinal.AutoSize = true;
            rbt_binarioFinal.Location = new Point(107, 10);
            rbt_binarioFinal.Name = "rbt_binarioFinal";
            rbt_binarioFinal.Size = new Size(62, 19);
            rbt_binarioFinal.TabIndex = 2;
            rbt_binarioFinal.Text = "Binário";
            rbt_binarioFinal.UseVisualStyleBackColor = true;
            // 
            // rbt_hexaFinal
            // 
            rbt_hexaFinal.AutoSize = true;
            rbt_hexaFinal.Location = new Point(195, 10);
            rbt_hexaFinal.Name = "rbt_hexaFinal";
            rbt_hexaFinal.Size = new Size(94, 19);
            rbt_hexaFinal.TabIndex = 1;
            rbt_hexaFinal.Text = "Hexadecimal";
            rbt_hexaFinal.UseVisualStyleBackColor = true;
            // 
            // rbt_decimalFinal
            // 
            rbt_decimalFinal.AutoSize = true;
            rbt_decimalFinal.Checked = true;
            rbt_decimalFinal.Location = new Point(13, 10);
            rbt_decimalFinal.Name = "rbt_decimalFinal";
            rbt_decimalFinal.Size = new Size(68, 19);
            rbt_decimalFinal.TabIndex = 0;
            rbt_decimalFinal.TabStop = true;
            rbt_decimalFinal.Text = "Decimal";
            rbt_decimalFinal.UseVisualStyleBackColor = true;
            // 
            // btn_converter
            // 
            btn_converter.Location = new Point(16, 204);
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new Size(303, 26);
            btn_converter.TabIndex = 16;
            btn_converter.Text = "Converter";
            btn_converter.UseVisualStyleBackColor = true;
            btn_converter.Click += btn_converter_Click;
            // 
            // frm_conversorDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_baseFinal);
            Controls.Add(btn_converter);
            Controls.Add(lbl_baseFinal);
            Controls.Add(lbl_baseNum);
            Controls.Add(btn_calculadora);
            Controls.Add(panel_baseNumero);
            Controls.Add(txt_num);
            Controls.Add(txt_resultado);
            Controls.Add(ltx_passo);
            MinimumSize = new Size(816, 489);
            Name = "frm_conversorDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor De Bases";
            panel_baseNumero.ResumeLayout(false);
            panel_baseNumero.PerformLayout();
            panel_baseFinal.ResumeLayout(false);
            panel_baseFinal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_resultado;
        private RadioButton rbt_decimalNum;
        private TextBox txt_num;
        private Panel panel_baseNumero;
        private RadioButton rbt_hexaNum;
        private Button btn_calculadora;
        private ListBox ltx_passo;
        private RadioButton rbt_binarioNum;
        private Label lbl_baseNum;
        private Label lbl_baseFinal;
        private Panel panel_baseFinal;
        private RadioButton rbt_binarioFinal;
        private RadioButton rbt_hexaFinal;
        private RadioButton rbt_decimalFinal;
        private Button btn_converter;
    }
}
