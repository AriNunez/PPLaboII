﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if(usuario is not null && password is not null)
            {
                if(Bar.LoginUsuario(usuario, password))
                {
                    FormMenuPrincipal frmMenuPrincipal = new FormMenuPrincipal();
                    frmMenuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o password invalido", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
