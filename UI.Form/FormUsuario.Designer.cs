
namespace TP2
{
    partial class UI
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
            this.btnExc1 = new System.Windows.Forms.Button();
            this.btnExc2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDivCero
            // 
            this.btnDivCero.Location = new System.Drawing.Point(12, 12);
            this.btnDivCero.Name = "btnDivCero";
            this.btnDivCero.Size = new System.Drawing.Size(128, 61);
            this.btnDivCero.TabIndex = 0;
            this.btnDivCero.Text = "Dividir por cero";
            this.btnDivCero.UseVisualStyleBackColor = true;
            this.btnDivCero.Click += new System.EventHandler(this.btnDivCero_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(12, 146);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(128, 61);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "Division";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnExc1
            // 
            this.btnExc1.Location = new System.Drawing.Point(12, 272);
            this.btnExc1.Name = "btnExc1";
            this.btnExc1.Size = new System.Drawing.Size(128, 72);
            this.btnExc1.TabIndex = 2;
            this.btnExc1.Text = "NO TOCAR";
            this.btnExc1.UseVisualStyleBackColor = true;
            this.btnExc1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExc2
            // 
            this.btnExc2.Location = new System.Drawing.Point(12, 395);
            this.btnExc2.Name = "btnExc2";
            this.btnExc2.Size = new System.Drawing.Size(128, 61);
            this.btnExc2.TabIndex = 3;
            this.btnExc2.Text = "UWU";
            this.btnExc2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 545);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 597);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExc2);
            this.Controls.Add(this.btnExc1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDivCero);
            this.Name = "UI";
            this.Text = "UI";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDivCero;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnExc1;
        private System.Windows.Forms.Button btnExc2;
        private System.Windows.Forms.Button btnSalir;
    }
}