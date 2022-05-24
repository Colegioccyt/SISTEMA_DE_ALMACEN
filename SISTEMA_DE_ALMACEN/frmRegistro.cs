/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 10:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of frmRegistro.
	/// </summary>
	public partial class frmRegistro : Form
	{
		public frmRegistro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			ListViewItem lis;			
			
			
          // double dLado;
			//try 
			//{
			//	dLado = Convert.ToDouble(txtNumero.Text);
				
			//	lblReaultado.Text ="el area es "
			//		+ Convert.ToString(dLado * dLado)
			//		+ "metros cuadrados";
			
			// }
                           
		}
		
		
		
		void Label4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
