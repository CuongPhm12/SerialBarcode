﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingManySerials
{
    public partial class frmMain :Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            using(Form1 form1 = new Form1())
            {
                form1.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using(frmSearchSerial frmSearchSerial = new frmSearchSerial())
            {
                frmSearchSerial.ShowDialog();
            }

        }
    }
}
