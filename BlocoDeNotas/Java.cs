﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BlocoDeNotas
{
    public partial class Java : Form
    {
        Thread t1;

        public Java()
        {
            InitializeComponent();
        }

        private void openWindow(object obj)
        {
            Application.Run(new WindowJava());
        }

        private void closeWindow(object obj)
        {
            Application.Run(new Principal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openWindow);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(closeWindow);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void Java_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'notasDataSet.Java'. Você pode movê-la ou removê-la conforme necessário.
            this.javaTableAdapter.Fill(this.notasDataSet.Java);

        }
    }
}
