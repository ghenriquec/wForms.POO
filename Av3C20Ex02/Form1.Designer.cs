
namespace Av3C20Ex02
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
            this.lblPago = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.nmrd_quantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrd_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(-4, 79);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(157, 28);
            this.lblPago.TabIndex = 0;
            this.lblPago.Text = "Valor a ser pago:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(148, 79);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 34);
            this.txt_Valor.TabIndex = 1;
            // 
            // nmrd_quantidade
            // 
            this.nmrd_quantidade.Location = new System.Drawing.Point(232, 129);
            this.nmrd_quantidade.Name = "nmrd_quantidade";
            this.nmrd_quantidade.Size = new System.Drawing.Size(120, 34);
            this.nmrd_quantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade de produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Produto:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(169, 30);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(129, 34);
            this.txt_Nome.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(12, 176);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(194, 40);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(12, 241);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(23, 28);
            this.lbl_Valor.TabIndex = 7;
            this.lbl_Valor.Text = "0";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(212, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 40);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrd_quantidade);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lblPago);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrd_quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.NumericUpDown nmrd_quantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Button btnLimpar;
    }
}

