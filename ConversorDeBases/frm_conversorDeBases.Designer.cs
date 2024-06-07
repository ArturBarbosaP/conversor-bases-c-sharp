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
            rbt_decimal_bin = new RadioButton();
            txt_num = new TextBox();
            panel_baseNumero = new Panel();
            radioButton1 = new RadioButton();
            rbt_hexa_bin = new RadioButton();
            btn_calculadora = new Button();
            ltx_passo = new ListBox();
            label1 = new Label();
            label2 = new Label();
            panel_baseFinal = new Panel();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
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
            // rbt_decimal_bin
            // 
            rbt_decimal_bin.AutoSize = true;
            rbt_decimal_bin.Checked = true;
            rbt_decimal_bin.Location = new Point(13, 10);
            rbt_decimal_bin.Name = "rbt_decimal_bin";
            rbt_decimal_bin.Size = new Size(68, 19);
            rbt_decimal_bin.TabIndex = 0;
            rbt_decimal_bin.TabStop = true;
            rbt_decimal_bin.Text = "Decimal";
            rbt_decimal_bin.UseVisualStyleBackColor = true;
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
            panel_baseNumero.Controls.Add(radioButton1);
            panel_baseNumero.Controls.Add(rbt_hexa_bin);
            panel_baseNumero.Controls.Add(rbt_decimal_bin);
            panel_baseNumero.Location = new Point(16, 70);
            panel_baseNumero.Name = "panel_baseNumero";
            panel_baseNumero.Size = new Size(303, 39);
            panel_baseNumero.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(107, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Binário";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbt_hexa_bin
            // 
            rbt_hexa_bin.AutoSize = true;
            rbt_hexa_bin.Location = new Point(195, 10);
            rbt_hexa_bin.Name = "rbt_hexa_bin";
            rbt_hexa_bin.Size = new Size(94, 19);
            rbt_hexa_bin.TabIndex = 1;
            rbt_hexa_bin.Text = "Hexadecimal";
            rbt_hexa_bin.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 14;
            label1.Text = "Converter número da base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 15;
            label2.Text = "Converter para base";
            // 
            // panel_baseFinal
            // 
            panel_baseFinal.Controls.Add(radioButton2);
            panel_baseFinal.Controls.Add(radioButton3);
            panel_baseFinal.Controls.Add(radioButton4);
            panel_baseFinal.Location = new Point(16, 159);
            panel_baseFinal.Name = "panel_baseFinal";
            panel_baseFinal.Size = new Size(303, 39);
            panel_baseFinal.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(107, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 19);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Binário";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(195, 10);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 1;
            radioButton3.Text = "Hexadecimal";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(13, 10);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Decimal";
            radioButton4.UseVisualStyleBackColor = true;
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
            Controls.Add(label2);
            Controls.Add(label1);
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
        private RadioButton rbt_decimal_bin;
        private TextBox txt_num;
        private Panel panel_baseNumero;
        private RadioButton rbt_hexa_bin;
        private Button btn_calculadora;
        private ListBox ltx_passo;
        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private Panel panel_baseFinal;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button btn_converter;
    }
}
