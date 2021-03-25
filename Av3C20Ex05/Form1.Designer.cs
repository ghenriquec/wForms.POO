
namespace Av3C20Ex05
{
    partial class Form1
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.nmr_mes = new System.Windows.Forms.NumericUpDown();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_meses = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_mes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_numero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numero.Location = new System.Drawing.Point(12, 40);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(200, 25);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Selecione um número:";
            // 
            // nmr_mes
            // 
            this.nmr_mes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmr_mes.Location = new System.Drawing.Point(218, 38);
            this.nmr_mes.Name = "nmr_mes";
            this.nmr_mes.Size = new System.Drawing.Size(120, 32);
            this.nmr_mes.TabIndex = 1;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mes.Location = new System.Drawing.Point(-24, 92);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(0, 25);
            this.lbl_mes.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_meses
            // 
            this.lbl_meses.AutoSize = true;
            this.lbl_meses.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_meses.Location = new System.Drawing.Point(94, 136);
            this.lbl_meses.Name = "lbl_meses";
            this.lbl_meses.Size = new System.Drawing.Size(56, 25);
            this.lbl_meses.TabIndex = 4;
            this.lbl_meses.Text = "Mês: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 121);
            this.panel1.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(187, 82);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 170);
            this.Controls.Add(this.lbl_meses);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.nmr_mes);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_mes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.NumericUpDown nmr_mes;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_meses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
    }
}

