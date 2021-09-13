
namespace FormUsuario
{
    partial class FormDivision
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDiv = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(119, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(94, 42);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 2;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(94, 132);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIVIDENDO";
            // 
            // gbDiv
            // 
            this.gbDiv.Controls.Add(this.btnCancelar);
            this.gbDiv.Controls.Add(this.txtDivisor);
            this.gbDiv.Controls.Add(this.btnAceptar);
            this.gbDiv.Controls.Add(this.label2);
            this.gbDiv.Controls.Add(this.label1);
            this.gbDiv.Controls.Add(this.txtDividendo);
            this.gbDiv.Location = new System.Drawing.Point(12, 12);
            this.gbDiv.Name = "gbDiv";
            this.gbDiv.Size = new System.Drawing.Size(309, 243);
            this.gbDiv.TabIndex = 5;
            this.gbDiv.TabStop = false;
            this.gbDiv.Text = "Ingrese el/los valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DIVISOR";
            // 
            // FormDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 270);
            this.Controls.Add(this.gbDiv);
            this.Name = "FormDivision";
            this.Text = "Division";
            this.Load += new System.EventHandler(this.FormDivision_Load);
            this.gbDiv.ResumeLayout(false);
            this.gbDiv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDiv;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDivisor;
    }
}