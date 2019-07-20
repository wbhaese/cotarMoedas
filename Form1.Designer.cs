namespace CotarMoeda
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxQtdComprar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleciona a Moeda";
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "1 – Dólar (compra)",
            "2 – Euro (compra)",
            "3 – Libra esterlina (compra)"});
            this.cmbMoeda.Location = new System.Drawing.Point(12, 79);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(287, 26);
            this.cmbMoeda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(88, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Calcular";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(429, 7);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(187, 95);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "R$ 0,00";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cotação Atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Total:";
            // 
            // valorTotal
            // 
            this.valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotal.Location = new System.Drawing.Point(435, 89);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(181, 65);
            this.valorTotal.TabIndex = 6;
            this.valorTotal.Text = "R$ 0,00";
            this.valorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd para comprar:";
            // 
            // boxQtdComprar
            // 
            this.boxQtdComprar.Location = new System.Drawing.Point(68, 29);
            this.boxQtdComprar.Name = "boxQtdComprar";
            this.boxQtdComprar.Size = new System.Drawing.Size(178, 24);
            this.boxQtdComprar.TabIndex = 8;
            this.boxQtdComprar.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 163);
            this.Controls.Add(this.boxQtdComprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotar Moedas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoeda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxQtdComprar;
    }
}

