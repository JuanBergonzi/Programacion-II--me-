﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Reporte de ventas");
            comboBox1.Items.Add("Reporte de clientes");
            comboBox1.Items.Add("Reporte de productos");

        }
    }
}
