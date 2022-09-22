
namespace AppMatrices0_1
{
    partial class FrmContador
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
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTER";
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(60, 288);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(177, 46);
            this.btnDisminuir.TabIndex = 1;
            this.btnDisminuir.Text = "DISMINUIR";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(306, 288);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(177, 46);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "REINICIAR ";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(564, 288);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(177, 46);
            this.btnIncrementar.TabIndex = 3;
            this.btnIncrementar.Text = "INCREMENTAR";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContador.Location = new System.Drawing.Point(345, 133);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(98, 108);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "0";
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 375);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.label1);
            this.Name = "FrmContador";
            this.Load += new System.EventHandler(this.FrmContador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Label lblContador;
    }
}