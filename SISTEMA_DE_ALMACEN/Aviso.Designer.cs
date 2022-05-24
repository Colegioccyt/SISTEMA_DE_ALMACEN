/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 09:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SISTEMA_DE_ALMACEN
{
	partial class Aviso
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSi = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "¿Desea realizar factura? si es asi registre al cliente";
			// 
			// btnSi
			// 
			this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSi.Location = new System.Drawing.Point(52, 62);
			this.btnSi.Name = "btnSi";
			this.btnSi.Size = new System.Drawing.Size(75, 23);
			this.btnSi.TabIndex = 2;
			this.btnSi.Text = "Si";
			this.btnSi.UseVisualStyleBackColor = true;
			this.btnSi.Click += new System.EventHandler(this.BtnSiClick);
			// 
			// btnNo
			// 
			this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNo.Location = new System.Drawing.Point(241, 62);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 23);
			this.btnNo.TabIndex = 3;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = true;
			// 
			// Aviso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 110);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnSi);
			this.Controls.Add(this.label1);
			this.Name = "Aviso";
			this.Text = "Aviso";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Button btnSi;
		private System.Windows.Forms.Label label1;
	}
}
