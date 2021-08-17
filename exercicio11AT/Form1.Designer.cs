
namespace exercicio11AT
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
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.lblAlturaTotal = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.txtAlturaTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Location = new System.Drawing.Point(24, 68);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(95, 13);
            this.lblPesoTotal.TabIndex = 0;
            this.lblPesoTotal.Text = "Digite o peso total:";
            // 
            // lblAlturaTotal
            // 
            this.lblAlturaTotal.AutoSize = true;
            this.lblAlturaTotal.Location = new System.Drawing.Point(24, 135);
            this.lblAlturaTotal.Name = "lblAlturaTotal";
            this.lblAlturaTotal.Size = new System.Drawing.Size(98, 13);
            this.lblAlturaTotal.TabIndex = 1;
            this.lblAlturaTotal.Text = "Digite a altura total:";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(27, 95);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(119, 20);
            this.txtPesoTotal.TabIndex = 2;
            // 
            // txtAlturaTotal
            // 
            this.txtAlturaTotal.Location = new System.Drawing.Point(27, 164);
            this.txtAlturaTotal.Name = "txtAlturaTotal";
            this.txtAlturaTotal.Size = new System.Drawing.Size(119, 20);
            this.txtAlturaTotal.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 203);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 22);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Exercício 11 AT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 260);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAlturaTotal);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.lblAlturaTotal);
            this.Controls.Add(this.lblPesoTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.Label lblAlturaTotal;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.TextBox txtAlturaTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTitulo;
    }
}

