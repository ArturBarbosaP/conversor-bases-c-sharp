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
            btn_somar = new Button();
            txt_num1 = new TextBox();
            panel_rbts = new Panel();
            rbt_binario = new RadioButton();
            rbt_decimal = new RadioButton();
            rbt_hexa = new RadioButton();
            txt_num2 = new TextBox();
            btn_sub = new Button();
            btn_multi = new Button();
            txt_resultado = new TextBox();
            btn_voltar = new Button();
            panel_rbts.SuspendLayout();
            SuspendLayout();
            // 
            // btn_somar
            // 
            btn_somar.Location = new Point(27, 237);
            btn_somar.Name = "btn_somar";
            btn_somar.Size = new Size(349, 26);
            btn_somar.TabIndex = 21;
            btn_somar.Text = "Somar";
            btn_somar.UseVisualStyleBackColor = true;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(27, 168);
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
            panel_rbts.Location = new Point(27, 123);
            panel_rbts.Name = "panel_rbts";
            panel_rbts.Size = new Size(349, 39);
            panel_rbts.TabIndex = 19;
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
            // txt_num2
            // 
            txt_num2.Location = new Point(27, 197);
            txt_num2.Name = "txt_num2";
            txt_num2.PlaceholderText = "Número 2";
            txt_num2.Size = new Size(349, 23);
            txt_num2.TabIndex = 22;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(27, 269);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(349, 26);
            btn_sub.TabIndex = 23;
            btn_sub.Text = "Subtrair";
            btn_sub.UseVisualStyleBackColor = true;
            // 
            // btn_multi
            // 
            btn_multi.Location = new Point(27, 301);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(349, 26);
            btn_multi.TabIndex = 24;
            btn_multi.Text = "Multiplicar";
            btn_multi.UseVisualStyleBackColor = true;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(424, 197);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(349, 23);
            txt_resultado.TabIndex = 25;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(27, 391);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(349, 26);
            btn_voltar.TabIndex = 26;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            // 
            // frm_calculadoraDeBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_voltar);
            Controls.Add(txt_resultado);
            Controls.Add(btn_multi);
            Controls.Add(btn_sub);
            Controls.Add(txt_num2);
            Controls.Add(btn_somar);
            Controls.Add(txt_num1);
            Controls.Add(panel_rbts);
            Name = "frm_calculadoraDeBases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Bases";
            panel_rbts.ResumeLayout(false);
            panel_rbts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_somar;
        private TextBox txt_num1;
        private Panel panel_rbts;
        private RadioButton rbt_binario;
        private RadioButton rbt_decimal;
        private RadioButton rbt_hexa;
        private TextBox txt_num2;
        private Button btn_sub;
        private Button btn_multi;
        private TextBox txt_resultado;
        private Button btn_voltar;
    }
}