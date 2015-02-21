﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime;
using testLib;

namespace libTestApp
{
    public partial class Form1 : Form
    {
        //[DllImport("testLib.dll")]
        //extern static void SomeFoo();

        public Form1()
        {
            InitializeComponent();
        }

        private void idMainCall_Click(object sender, EventArgs e)
        {
            HTMLWorker.SomeFoo(delegate() { MessageBox.Show("called from DLL!!! ^.^"); });
        }
    }
}
