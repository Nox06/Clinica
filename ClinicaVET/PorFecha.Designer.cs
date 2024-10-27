namespace ClinicaVET
{
    partial class PorFecha
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dd1 = new System.Windows.Forms.TextBox();
            this.aa1 = new System.Windows.Forms.TextBox();
            this.mm1 = new System.Windows.Forms.TextBox();
            this.mm2 = new System.Windows.Forms.TextBox();
            this.aa2 = new System.Windows.Forms.TextBox();
            this.dd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha 1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(744, 309);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dd1
            // 
            this.dd1.Location = new System.Drawing.Point(246, 55);
            this.dd1.Name = "dd1";
            this.dd1.Size = new System.Drawing.Size(30, 20);
            this.dd1.TabIndex = 2;
            // 
            // aa1
            // 
            this.aa1.Location = new System.Drawing.Point(318, 55);
            this.aa1.Name = "aa1";
            this.aa1.Size = new System.Drawing.Size(61, 20);
            this.aa1.TabIndex = 3;
            // 
            // mm1
            // 
            this.mm1.Location = new System.Drawing.Point(282, 55);
            this.mm1.Name = "mm1";
            this.mm1.Size = new System.Drawing.Size(30, 20);
            this.mm1.TabIndex = 4;
            // 
            // mm2
            // 
            this.mm2.Location = new System.Drawing.Point(505, 55);
            this.mm2.Name = "mm2";
            this.mm2.Size = new System.Drawing.Size(30, 20);
            this.mm2.TabIndex = 8;
            // 
            // aa2
            // 
            this.aa2.Location = new System.Drawing.Point(541, 55);
            this.aa2.Name = "aa2";
            this.aa2.Size = new System.Drawing.Size(61, 20);
            this.aa2.TabIndex = 7;
            // 
            // dd2
            // 
            this.dd2.Location = new System.Drawing.Point(469, 55);
            this.dd2.Name = "dd2";
            this.dd2.Size = new System.Drawing.Size(30, 20);
            this.dd2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha 2";
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(636, 53);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BUSCAR.TabIndex = 9;
            this.BUSCAR.Text = "Buscar";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // PorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.mm2);
            this.Controls.Add(this.aa2);
            this.Controls.Add(this.dd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mm1);
            this.Controls.Add(this.aa1);
            this.Controls.Add(this.dd1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "PorFecha";
            this.Text = "PorFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox dd1;
        private System.Windows.Forms.TextBox aa1;
        private System.Windows.Forms.TextBox mm1;
        private System.Windows.Forms.TextBox mm2;
        private System.Windows.Forms.TextBox aa2;
        private System.Windows.Forms.TextBox dd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUSCAR;
    }
}