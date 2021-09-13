
namespace FormUsuario
{
    partial class FormMain
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnDivCero = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnExc1 = new System.Windows.Forms.Button();
            this.btnExc2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnSalir);
            this.gbMain.Controls.Add(this.btnExc2);
            this.gbMain.Controls.Add(this.btnExc1);
            this.gbMain.Controls.Add(this.btnDiv);
            this.gbMain.Controls.Add(this.btnDivCero);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(284, 444);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Seleccione una opcion";
            // 
            // btnDivCero
            // 
            this.btnDivCero.Location = new System.Drawing.Point(6, 37);
            this.btnDivCero.Name = "btnDivCero";
            this.btnDivCero.Size = new System.Drawing.Size(268, 45);
            this.btnDivCero.TabIndex = 0;
            this.btnDivCero.Text = "Dividir por cero";
            this.btnDivCero.UseVisualStyleBackColor = true;
            this.btnDivCero.Click += new System.EventHandler(this.btnDivCero_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(6, 125);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(268, 45);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnExc1
            // 
            this.btnExc1.Location = new System.Drawing.Point(6, 212);
            this.btnExc1.Name = "btnExc1";
            this.btnExc1.Size = new System.Drawing.Size(268, 45);
            this.btnExc1.TabIndex = 2;
            this.btnExc1.Text = "NO TOCAR";
            this.btnExc1.UseVisualStyleBackColor = true;
            this.btnExc1.Click += new System.EventHandler(this.btnExc1_Click);
            // 
            // btnExc2
            // 
            this.btnExc2.Location = new System.Drawing.Point(6, 302);
            this.btnExc2.Name = "btnExc2";
            this.btnExc2.Size = new System.Drawing.Size(268, 45);
            this.btnExc2.TabIndex = 3;
            this.btnExc2.Text = "Confia en mi, soy un boton";
            this.btnExc2.UseVisualStyleBackColor = true;
            this.btnExc2.Click += new System.EventHandler(this.btnExc2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(268, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 486);
            this.Controls.Add(this.gbMain);
            this.Name = "FormMain";
            this.Text = "Menuwu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExc2;
        private System.Windows.Forms.Button btnExc1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDivCero;
    }
}

