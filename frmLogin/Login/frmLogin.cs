using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {

        public static DataTable Tabla = new DataTable();
        public static DataRow Fila;
        public int x = 0;

        String usuario = "admin";
        String contraseña = "1234";
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(this.tb_usuarioTableAdapter.Usuarios(txtUsuario.Text, txtContraseña.Text)); 
            if (x!=1) {
                if (txtUsuario.Text != usuario)
                {
                    MessageBox.Show("Nombre de Usuario Incorrecto");
                    txtUsuario.ResetText();
                    txtUsuario.Focus();
                    return;
                }
                else if(txtContraseña.Text != contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtContraseña.ResetText();
                    txtContraseña.Focus();
                    return;
                }
            }
            else if(x==1)
            {
                frmLogin frm1 = new frmLogin();
                frmMenu frm = new frmMenu();
                frm1.Close();
                frm.Show();
                
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_usuario' Puede moverla o quitarla según sea necesario.
            this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);

        }

        private void tb_usuarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
