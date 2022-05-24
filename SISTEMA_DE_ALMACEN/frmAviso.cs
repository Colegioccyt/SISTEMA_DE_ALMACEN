/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 09:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of frmAviso.
	/// </summary>
	public partial class frmAviso : Form
	{
		public frmAviso()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnFacturaClick(object sender, EventArgs e)
		{
			frmFactura frmFactura = new frmFactura();
			frmFactura.Show();
		}
		
		
	}
}
