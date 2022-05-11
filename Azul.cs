﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); // Indico qual sera aberto
            this.Hide(); // Fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); // Indico qual sera aberto
            this.Hide(); // Fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormVerde_Click(object sender, EventArgs e)
        {
            FrmVerde frm = new FrmVerde(); // Indico qual sera aberto
            this.Hide(); // Fechar o atual
            frm.ShowDialog();
        }
    }
}
