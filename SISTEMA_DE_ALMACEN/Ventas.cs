/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 08:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of Ventas.
	/// </summary>
	public partial class Ventas : Form
	{
		public Ventas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void VentasLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnRegistroClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnComprarClick(object sender, EventArgs e)
		{
			Aviso aviso = new Aviso();
			aviso.Show();
		}
	}
}
