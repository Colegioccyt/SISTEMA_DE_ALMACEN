/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 08:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SISTEMA_DE_ALMACEN
{
	partial class Ventas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMaterial = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbMarca = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbCantidad = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnComprar = new System.Windows.Forms.Button();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Material :";
			// 
			// cmbMaterial
			// 
			this.cmbMaterial.FormattingEnabled = true;
			this.cmbMaterial.Location = new System.Drawing.Point(158, 94);
			this.cmbMaterial.Name = "cmbMaterial";
			this.cmbMaterial.Size = new System.Drawing.Size(241, 21);
			this.cmbMaterial.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Marca:";
			// 
			// cmbMarca
			// 
			this.cmbMarca.FormattingEnabled = true;
			this.cmbMarca.Location = new System.Drawing.Point(158, 150);
			this.cmbMarca.Name = "cmbMarca";
			this.cmbMarca.Size = new System.Drawing.Size(241, 21);
			this.cmbMarca.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cantidad:";
			// 
			// cmbCantidad
			// 
			this.cmbCantidad.FormattingEnabled = true;
			this.cmbCantidad.Location = new System.Drawing.Point(158, 212);
			this.cmbCantidad.Name = "cmbCantidad";
			this.cmbCantidad.Size = new System.Drawing.Size(241, 21);
			this.cmbCantidad.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Precio:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(158, 276);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(241, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// btnComprar
			// 
			this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComprar.Location = new System.Drawing.Point(40, 350);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(122, 34);
			this.btnComprar.TabIndex = 9;
			this.btnComprar.Text = "Comprar";
			this.btnComprar.UseVisualStyleBackColor = true;
			this.btnComprar.Click += new System.EventHandler(this.BtnComprarClick);
			// 
			// btnRegistro
			// 
			this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistro.Location = new System.Drawing.Point(279, 350);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(137, 33);
			this.btnRegistro.TabIndex = 10;
			this.btnRegistro.Text = "Ingresar otro material";
			this.btnRegistro.UseVisualStyleBackColor = true;
			this.btnRegistro.Click += new System.EventHandler(this.BtnRegistroClick);
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(469, 419);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.btnComprar);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbMarca);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbMaterial);
			this.Controls.Add(this.label1);
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.VentasLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbMarca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbMaterial;
		private System.Windows.Forms.Label label1;
	}
}
