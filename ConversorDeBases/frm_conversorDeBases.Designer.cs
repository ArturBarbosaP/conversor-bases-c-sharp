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
            rbt_hexa = new RadioButton();
            rbt_binario = new RadioButton();
            txt_decimal = new TextBox();
            btn_converter = new Button();
            txt_resultado = new TextBox();
            SuspendLayout();
            // 
            // rbt_hexa
            // 
            rbt_hexa.AutoSize = true;
            rbt_hexa.Location = new Point(134, 25);
            rbt_hexa.Name = "rbt_hexa";
            rbt_hexa.Size = new Size(101, 19);
            rbt_hexa.TabIndex = 7;
            rbt_hexa.Text = "Hexadecimnal";
            rbt_hexa.UseVisualStyleBackColor = true;
            // 
            // rbt_binario
            // 
            rbt_binario.AutoSize = true;
            rbt_binario.Checked = true;
            rbt_binario.Location = new Point(23, 25);
            rbt_binario.Name = "rbt_binario";
            rbt_binario.Size = new Size(62, 19);
            rbt_binario.TabIndex = 6;
            rbt_binario.TabStop = true;
            rbt_binario.Text = "Binário";
            rbt_binario.UseVisualStyleBackColor = true;
            // 
            // txt_decimal
            // 
            txt_decimal.Location = new Point(23, 75);
            txt_decimal.Name = "txt_decimal";
            txt_decimal.PlaceholderText = "Base Decimal";
            txt_decimal.Size = new Size(212, 23);
            txt_decimal.TabIndex = 5;
            // 
            // btn_converter
            // 
            btn_converter.Location = new Point(23, 123);
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new Size(212, 26);
            btn_converter.TabIndex = 8;
            btn_converter.Text = "Converter";
            btn_converter.UseVisualStyleBackColor = true;
            btn_converter.Click += btn_converter_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(6, 399);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(789, 39);
            txt_resultado.TabIndex = 9;
            // 
            // frm_conversorDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_resultado);
            Controls.Add(btn_converter);
            Controls.Add(rbt_hexa);
            Controls.Add(rbt_binario);
            Controls.Add(txt_decimal);
            Name = "frm_conversorDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor De Bases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbt_hexa;
        private RadioButton rbt_binario;
        private TextBox txt_decimal;
        private Button btn_converter;
        private TextBox txt_resultado;
    }
}
