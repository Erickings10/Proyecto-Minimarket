using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using System.Runtime.InteropServices;

namespace SoftwareMinimarket
{
    public partial class Form1 : Form
    {
        public static entUsuario usuarioValido = null;
        public Form1()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            string userInput = txt_user.Text;
            string passInput = txt_pass.Text;

            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(passInput))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            List<entUsuario> listaUsuarios = logUsuario.Instancia.ListarUsuarios();
            usuarioValido = listaUsuarios
                .FirstOrDefault(user => user.usuario == userInput && user.contraseña == passInput);

            if (usuarioValido != null) //encuentra el usuario
            {
                if (usuarioValido.estado) //valida estado de usuario
                {
                    if (!usuarioValido.sesionActiva) //valida inicio de sesion
                    {
                        switch (usuarioValido.tipoUsuario) //valida tipo de usuario para mostrar interfaz
                        {
                            case 1:
                                ModuloGerente mg = new ModuloGerente();
                                mg.Show();

                                break;
                            case 2:
                                ModuloVentas mv = new ModuloVentas();
                                mv.Show();

                                break;
                            case 3:
                                ModuloEntradaProductos mep = new ModuloEntradaProductos();
                                mep.Show();
                                break;
                        }

                        logUsuario.Instancia.ActualizarInicioSesion(usuarioValido.id, true);
                        MessageBox.Show("Bienvenido(a) " + usuarioValido.usuario);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sesion activa en otro dispositivo. ");
                    }

                }
                else
                {
                    MessageBox.Show("Usuario no disponible. ");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO") 
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "") 
            {
                txt_user.Text = "USUARIO";
                txt_user.ForeColor = Color.LightGray;
            }
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA") 
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "") 
            {
                txt_pass.Text = "CONTRASEÑA";
                txt_pass.ForeColor = Color.LightGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //logUsuario.Instancia.ActualizarInicioSesion(usuarioValido.id, false);
        }
    }
}
