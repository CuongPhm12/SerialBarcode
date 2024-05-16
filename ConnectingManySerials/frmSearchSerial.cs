using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConnectingManySerials
{
    public partial class frmSearchSerial : MetroFramework.Forms.MetroForm
    {
        string _serialM;
        public frmSearchSerial()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string keySearch = txtSerialBarcode.Text;

            using (SerialEntities db = new SerialEntities())
            {


                var result = (from x in db.SerialDs
                              where x.SerialD1.Contains(keySearch)
                              group x by x.SerialM into g
                              select new { SerialM = g.Key, UpdTime = g.Max(y => y.UpdTime) }).ToList();


                gridViewSerialSearch.DataSource = result.ToList();
            }



        }

        private void gridViewSerialSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridViewSerialSearch.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void frmSearchSerial_Load(object sender, EventArgs e)
        {


        }

        private void gridViewSerialSearch_DoubleClick(object sender, EventArgs e)
        {

            _serialM = gridViewSerialSearch.Rows[gridViewSerialSearch.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

            Form1 frm = new Form1(_serialM);
            frm.ShowDialog();
        }
    }
}
