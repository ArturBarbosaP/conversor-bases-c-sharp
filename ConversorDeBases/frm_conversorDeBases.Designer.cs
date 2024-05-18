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
            radioButton1310 = new RadioButton();
            rbt_binario1581 = new RadioButton();
            txt_decimal = new TextBox();
            btn_converter = new Button();
            txt_resultado = new TextBox();
            SuspendLayout();
            // 
            // radioButton1310
            // 
            radioButton1310.AutoSize = true;
            radioButton1310.Location = new Point(134, 25);
            radioButton1310.Name = "radioButton1310";
            radioButton1310.Size = new Size(101, 19);
            radioButton1310.TabIndex = 7;
            radioButton1310.Text = "Hexadecimnal";
            radioButton1310.UseVisualStyleBackColor = true;
            // 
            // rbt_binario1581
            // 
            rbt_binario1581.AutoSize = true;
            rbt_binario1581.Checked = true;
            rbt_binario1581.Location = new Point(23, 25);
            rbt_binario1581.Name = "rbt_binario1581";
            rbt_binario1581.Size = new Size(62, 19);
            rbt_binario1581.TabIndex = 6;
            rbt_binario1581.TabStop = true;
            rbt_binario1581.Text = "Binário";
            rbt_binario1581.UseVisualStyleBackColor = true;
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
            btn_converter.Location = new Point(23, 130);
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new Size(212, 26);
            btn_converter.TabIndex = 8;
            btn_converter.Text = "Converter";
            btn_converter.UseVisualStyleBackColor = true;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(168, 371);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(464, 39);
            txt_resultado.TabIndex = 9;
            // 
            // frm_conversorDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_resultado);
            Controls.Add(btn_converter);
            Controls.Add(radioButton1310);
            Controls.Add(rbt_binario1581);
            Controls.Add(txt_decimal);
            Name = "frm_conversorDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor De Bases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1310;
        private RadioButton rbt_binario1581;
        private TextBox txt_decimal;
        private Button btn_converter;
        private TextBox txt_resultado;
    }
}
