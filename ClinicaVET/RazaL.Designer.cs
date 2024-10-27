namespace ClinicaVET
{
    partial class RazaL
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
            this.lista = new System.Windows.Forms.ListView();
            this.racita = new System.Windows.Forms.TextBox();
            this.VER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique la raza";
            // 
            // lista
            // 
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(12, 23);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(121, 272);
            this.lista.TabIndex = 1;
            this.lista.UseCompatibleStateImageBehavior = false;
            // 
            // racita
            // 
            this.racita.Location = new System.Drawing.Point(159, 66);
            this.racita.Name = "racita";
            this.racita.Size = new System.Drawing.Size(100, 20);
            this.racita.TabIndex = 2;
            // 
            // VER
            // 
            this.VER.Location = new System.Drawing.Point(159, 102);
            this.VER.Name = "VER";
            this.VER.Size = new System.Drawing.Size(75, 23);
            this.VER.TabIndex = 3;
            this.VER.Text = "Ver";
            this.VER.UseVisualStyleBackColor = true;
            this.VER.Click += new System.EventHandler(this.VER_Click);
            // 
            // RazaL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 306);
            this.Controls.Add(this.VER);
            this.Controls.Add(this.racita);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Name = "RazaL";
            this.Text = "RazaL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.TextBox racita;
        private System.Windows.Forms.Button VER;
    }
}