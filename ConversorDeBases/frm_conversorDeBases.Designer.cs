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
            rbt_hexa_dec = new RadioButton();
            rbt_binario_dec = new RadioButton();
            txt_decimal = new TextBox();
            btn_converter_decimal = new Button();
            txt_passo = new TextBox();
            txt_resultado = new TextBox();
            rbt_decimal_bin = new RadioButton();
            txt_binario = new TextBox();
            panel_decimal = new Panel();
            panel_binario = new Panel();
            rbt_hexa_bin = new RadioButton();
            btn_converter_binario = new Button();
            panel_decimal.SuspendLayout();
            panel_binario.SuspendLayout();
            SuspendLayout();
            // 
            // rbt_hexa_dec
            // 
            rbt_hexa_dec.AutoSize = true;
            rbt_hexa_dec.Location = new Point(107, 10);
            rbt_hexa_dec.Name = "rbt_hexa_dec";
            rbt_hexa_dec.Size = new Size(94, 19);
            rbt_hexa_dec.TabIndex = 7;
            rbt_hexa_dec.Text = "Hexadecimal";
            rbt_hexa_dec.UseVisualStyleBackColor = true;
            // 
            // rbt_binario_dec
            // 
            rbt_binario_dec.AutoSize = true;
            rbt_binario_dec.Checked = true;
            rbt_binario_dec.Location = new Point(12, 10);
            rbt_binario_dec.Name = "rbt_binario_dec";
            rbt_binario_dec.Size = new Size(62, 19);
            rbt_binario_dec.TabIndex = 6;
            rbt_binario_dec.TabStop = true;
            rbt_binario_dec.Text = "Binário";
            rbt_binario_dec.UseVisualStyleBackColor = true;
            // 
            // txt_decimal
            // 
            txt_decimal.Location = new Point(23, 75);
            txt_decimal.Name = "txt_decimal";
            txt_decimal.PlaceholderText = "Base Decimal";
            txt_decimal.Size = new Size(212, 23);
            txt_decimal.TabIndex = 5;
            // 
            // btn_converter_decimal
            // 
            btn_converter_decimal.Location = new Point(23, 104);
            btn_converter_decimal.Name = "btn_converter_decimal";
            btn_converter_decimal.Size = new Size(212, 26);
            btn_converter_decimal.TabIndex = 8;
            btn_converter_decimal.Text = "Converter";
            btn_converter_decimal.UseVisualStyleBackColor = true;
            btn_converter_decimal.Click += btn_converter_decimal_Click;
            // 
            // txt_passo
            // 
            txt_passo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_passo.Location = new Point(6, 399);
            txt_passo.Name = "txt_passo";
            txt_passo.ReadOnly = true;
            txt_passo.Size = new Size(789, 39);
            txt_passo.TabIndex = 9;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(398, 214);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(212, 23);
            txt_resultado.TabIndex = 10;
            // 
            // rbt_decimal_bin
            // 
            rbt_decimal_bin.AutoSize = true;
            rbt_decimal_bin.Checked = true;
            rbt_decimal_bin.Location = new Point(13, 10);
            rbt_decimal_bin.Name = "rbt_decimal_bin";
            rbt_decimal_bin.Size = new Size(68, 19);
            rbt_decimal_bin.TabIndex = 12;
            rbt_decimal_bin.TabStop = true;
            rbt_decimal_bin.Text = "Decimal";
            rbt_decimal_bin.UseVisualStyleBackColor = true;
            // 
            // txt_binario
            // 
            txt_binario.Location = new Point(23, 199);
            txt_binario.Name = "txt_binario";
            txt_binario.PlaceholderText = "Base Binária";
            txt_binario.Size = new Size(212, 23);
            txt_binario.TabIndex = 11;
            // 
            // panel_decimal
            // 
            panel_decimal.Controls.Add(rbt_binario_dec);
            panel_decimal.Controls.Add(rbt_hexa_dec);
            panel_decimal.Location = new Point(23, 30);
            panel_decimal.Name = "panel_decimal";
            panel_decimal.Size = new Size(212, 39);
            panel_decimal.TabIndex = 13;
            // 
            // panel_binario
            // 
            panel_binario.Controls.Add(rbt_hexa_bin);
            panel_binario.Controls.Add(rbt_decimal_bin);
            panel_binario.Location = new Point(23, 154);
            panel_binario.Name = "panel_binario";
            panel_binario.Size = new Size(212, 39);
            panel_binario.TabIndex = 14;
            // 
            // rbt_hexa_bin
            // 
            rbt_hexa_bin.AutoSize = true;
            rbt_hexa_bin.Location = new Point(106, 10);
            rbt_hexa_bin.Name = "rbt_hexa_bin";
            rbt_hexa_bin.Size = new Size(94, 19);
            rbt_hexa_bin.TabIndex = 8;
            rbt_hexa_bin.Text = "Hexadecimal";
            rbt_hexa_bin.UseVisualStyleBackColor = true;
            // 
            // btn_converter_binario
            // 
            btn_converter_binario.Location = new Point(23, 228);
            btn_converter_binario.Name = "btn_converter_binario";
            btn_converter_binario.Size = new Size(212, 26);
            btn_converter_binario.TabIndex = 15;
            btn_converter_binario.Text = "Converter";
            btn_converter_binario.UseVisualStyleBackColor = true;
            btn_converter_binario.Click += btn_converter_binario_Click;
            // 
            // frm_conversorDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_converter_binario);
            Controls.Add(panel_binario);
            Controls.Add(panel_decimal);
            Controls.Add(txt_binario);
            Controls.Add(txt_resultado);
            Controls.Add(txt_passo);
            Controls.Add(btn_converter_decimal);
            Controls.Add(txt_decimal);
            Name = "frm_conversorDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor De Bases";
            panel_decimal.ResumeLayout(false);
            panel_decimal.PerformLayout();
            panel_binario.ResumeLayout(false);
            panel_binario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbt_hexa_dec;
        private RadioButton rbt_binario_dec;
        private TextBox txt_decimal;
        private Button btn_converter_decimal;
        private TextBox txt_passo;
        private TextBox txt_resultado;
        private RadioButton rbt_decimal_bin;
        private TextBox txt_binario;
        private Panel panel_decimal;
        private Panel panel_binario;
        private RadioButton rbt_hexa_bin;
        private Button btn_converter_binario;
    }
}
