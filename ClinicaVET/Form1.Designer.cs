namespace ClinicaVET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaLosPerrosPorRazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem,
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem,
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem,
            this.listaLosPerrosPorRazaToolStripMenuItem,
            this.listarTodosLosClientesToolStripMenuItem,
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem});
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem
            // 
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem.Name = "cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem";
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem.Text = "Cantidad de dinero recaudado en una fecha";
            this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem_Click);
            // 
            // totalRecaudadoPorUnClienteDadoToolStripMenuItem
            // 
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem.Name = "totalRecaudadoPorUnClienteDadoToolStripMenuItem";
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem.Text = "Total recaudado por un cliente dado";
            this.totalRecaudadoPorUnClienteDadoToolStripMenuItem.Click += new System.EventHandler(this.totalRecaudadoPorUnClienteDadoToolStripMenuItem_Click);
            // 
            // listarLasMascotasDeUnClienteDadoToolStripMenuItem
            // 
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem.Name = "listarLasMascotasDeUnClienteDadoToolStripMenuItem";
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem.Text = "Listar las mascotas de un cliente dado";
            this.listarLasMascotasDeUnClienteDadoToolStripMenuItem.Click += new System.EventHandler(this.listarLasMascotasDeUnClienteDadoToolStripMenuItem_Click);
            // 
            // listaLosPerrosPorRazaToolStripMenuItem
            // 
            this.listaLosPerrosPorRazaToolStripMenuItem.Name = "listaLosPerrosPorRazaToolStripMenuItem";
            this.listaLosPerrosPorRazaToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listaLosPerrosPorRazaToolStripMenuItem.Text = "Lista los perros por raza";
            this.listaLosPerrosPorRazaToolStripMenuItem.Click += new System.EventHandler(this.listaLosPerrosPorRazaToolStripMenuItem_Click);
            // 
            // listarTodosLosClientesToolStripMenuItem
            // 
            this.listarTodosLosClientesToolStripMenuItem.Name = "listarTodosLosClientesToolStripMenuItem";
            this.listarTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listarTodosLosClientesToolStripMenuItem.Text = "Listar todos los clientes";
            this.listarTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listarTodosLosClientesToolStripMenuItem_Click);
            // 
            // listarLasConsultasPorRangoDeFechaToolStripMenuItem
            // 
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem.Name = "listarLasConsultasPorRangoDeFechaToolStripMenuItem";
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem.Text = "Listar las consultas por rango de fecha";
            this.listarLasConsultasPorRangoDeFechaToolStripMenuItem.Click += new System.EventHandler(this.listarLasConsultasPorRangoDeFechaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clinica Veterinaria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeDineroRecaudadoEnUnaFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRecaudadoPorUnClienteDadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLasMascotasDeUnClienteDadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaLosPerrosPorRazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLasConsultasPorRangoDeFechaToolStripMenuItem;
    }
}

