
namespace FormMain
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
            this.btnDivCero = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnExc2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDivCero
            // 
            this.btnDivCero.Location = new System.Drawing.Point(6, 41);
            this.btnDivCero.Name = "btnDivCero";
            this.btnDivCero.Size = new System.Drawing.Size(118, 54);
            this.btnDivCero.TabIndex = 0;
            this.btnDivCero.Text = "Dividir  por cero";
            this.btnDivCero.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(6, 135);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(118, 54);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "Dividir ";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnExc
            // 
            this.btnExc.Location = new System.Drawing.Point(6, 246);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(118, 54);
            this.btnExc.TabIndex = 2;
            this.btnExc.Text = "NO TOCAR";
            this.btnExc.UseVisualStyleBackColor = true;
            // 
            // btnExc2
            // 
            this.btnExc2.Location = new System.Drawing.Point(0, 384);
            this.btnExc2.Name = "btnExc2";
            this.btnExc2.Size = new System.Drawing.Size(118, 54);
            this.btnExc2.TabIndex = 3;
            this.btnExc2.Text = "UWU";
            this.btnExc2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnDivCero);
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Controls.Add(this.btnExc);
            this.groupBox1.Controls.Add(this.btnExc2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 453);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDivCero;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnExc2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}

