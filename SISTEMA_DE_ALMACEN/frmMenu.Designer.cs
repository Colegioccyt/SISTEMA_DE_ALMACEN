/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 09:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SISTEMA_DE_ALMACEN
{
	partial class frmMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.btnVentas = new System.Windows.Forms.Button();
			this.btnSalir2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(414, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido Elija la opcion deseada";
			// 
			// btnRegistro
			// 
			this.btnRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnRegistro.Location = new System.Drawing.Point(150, 117);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(233, 28);
			this.btnRegistro.TabIndex = 1;
			this.btnRegistro.Text = "Registro De Material";
			this.btnRegistro.UseVisualStyleBackColor = false;
			this.btnRegistro.Click += new System.EventHandler(this.BtnRegistroClick);
			// 
			// btnVentas
			// 
			this.btnVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentas.Location = new System.Drawing.Point(150, 182);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(233, 26);
			this.btnVentas.TabIndex = 2;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.UseVisualStyleBackColor = false;
			this.btnVentas.Click += new System.EventHandler(this.BtnVentasClick);
			// 
			// btnSalir2
			// 
			this.btnSalir2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir2.Location = new System.Drawing.Point(461, 275);
			this.btnSalir2.Name = "btnSalir2";
			this.btnSalir2.Size = new System.Drawing.Size(82, 23);
			this.btnSalir2.TabIndex = 3;
			this.btnSalir2.Text = "Salir";
			this.btnSalir2.UseVisualStyleBackColor = false;
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(564, 310);
			this.Controls.Add(this.btnSalir2);
			this.Controls.Add(this.btnVentas);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmMenu";
			this.Text = "frmMenu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir2;
		private System.Windows.Forms.Button btnVentas;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Label label1;
	}
}
