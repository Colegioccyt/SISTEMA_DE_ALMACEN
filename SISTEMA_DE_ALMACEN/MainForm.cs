/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 09:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
         string sUsuario ="Administrador";
         string sContraseña = "1234";
           
         if(txtUsuario.Text == sUsuario && mskContraseña.Text== sContraseña)
         {
         	MessageBox.Show("Bienvenido al sistema de almacen","senccion iniciada",MessageBoxButtons.OK,MessageBoxIcon.Information);
         
         frmMenu frmMenu = new frmMenu();
         frmMenu.Show();
         }
         
         else
         {
         	MessageBox.Show("Su contraseña o el usuario es incorrecto verifiquelo","VALICION INCORECTA",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
         	
         }
              
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
