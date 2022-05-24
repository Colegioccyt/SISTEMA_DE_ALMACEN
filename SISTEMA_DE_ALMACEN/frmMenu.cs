/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 09:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of frmMenu.
	/// </summary>
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnRegistroClick(object sender, EventArgs e)
		{
			frmRegistro frmRegistro = new frmRegistro();
			frmRegistro.Show();
			
		}
		
		void BtnVentasClick(object sender, EventArgs e)
		{
			Ventas ventas = new Ventas();
			ventas.Show();
		}
		
		
	}
}
