/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 09:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of Aviso.
	/// </summary>
	public partial class Aviso : Form
	{
		public Aviso()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSiClick(object sender, EventArgs e)
		{
			frmAviso frmAviso = new frmAviso();
			frmAviso.Show();
		}
	}
}
