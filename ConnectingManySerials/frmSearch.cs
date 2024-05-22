using System;
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
    public partial class frmSearch : Form
    {
        private string _serialM;
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
      

        }

        private void dataGridViewSearch_DoubleClick(object sender, EventArgs e)
        {
            _serialM = dataGridViewSearch.Rows[dataGridViewSearch.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

            Form1 frm = new Form1(_serialM);
            frm.ShowDialog();
        }

        private void dataGridViewSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewSearch.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text;

            using (SerialEntities db = new SerialEntities())
            {


                var result = (from x in db.SerialDs
                              where x.SerialD1.Contains(keySearch)
                              group x by x.SerialM into g
                              select new { SerialM = g.Key, UpdTime = g.Max(y => y.UpdTime) }).ToList();


                dataGridViewSearch.DataSource = result.ToList();
            }
        }
    }
}
