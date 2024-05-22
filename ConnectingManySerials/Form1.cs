using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net.NetworkInformation;

namespace ConnectingManySerials
{
    public partial class Form1 : Form
    {
        int rep_num = 0;
        string _serialM;
        string serialAlready;
        string createDate;
        bool error_detective = false;
        UniqueArray<string> serialD_Result_arr;
        public Form1()
        {

            InitializeComponent();
            dataGridViewSearch.Visible = false;
            dataGridViewSerial.Visible = true;
            customizeGrid();
            FillDateCombobox();


        }

        private void customizeGrid()
        {
            dataGridViewSerial.Columns["No"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSerial.Columns["No"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSerial.Columns["No"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSerial.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSerial.Columns["Barcode"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSerial.Columns["Barcode"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSerial.Columns["Barcode"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSerial.Columns["Barcode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSerial.Columns["UpdateTime"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSerial.Columns["UpdateTime"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSerial.Columns["UpdateTime"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSerial.Columns["UpdateTime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSearch.Columns["No1"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSearch.Columns["No1"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSearch.Columns["No1"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSearch.Columns["No1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSearch.Columns["SerialD"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSearch.Columns["SerialD"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSearch.Columns["SerialD"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSearch.Columns["SerialD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSearch.Columns["UpdTime"].HeaderCell.Style.Font = new Font("Segoe UI Symbol", 9, FontStyle.Bold);
            dataGridViewSearch.Columns["UpdTime"].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewSearch.Columns["UpdTime"].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewSearch.Columns["UpdTime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSerial.RowHeadersVisible = false;
        }


        public Form1(string serialM)
        {

            dataGridViewSearch?.Rows?.Clear();
            dataGridViewSearch?.Refresh();

            _serialM = serialM;

            InitializeComponent();
            txtBarcode.Text = _serialM;
            dataGridViewSerial.Visible = false;
            dataGridViewSearch.Visible = true;
            FillDateCombobox();
            customizeGrid();
            using (SerialEntities db = new SerialEntities())
            {

                var result = db.SerialDs.Where(x => x.SerialM == _serialM).ToList();
                dataGridViewSearch.DataSource = result;
            }
        }


        private void FillDateCombobox()
        {
            List<Model> models = new List<Model>();
            models.Add(new Model { Id = 1, Name = "Test1_3pcb" });
            models.Add(new Model { Id = 2, Name = "Test3_5pcb" });
            cbbModel.DataSource = models;
            cbbModel.ValueMember = "Id";
            cbbModel.DisplayMember = "Name";
            cbbModel.SelectedIndex = -1;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtBarcode.GotFocus += OnFocus;
            this.txtBarcode.LostFocus += OnDefocus;
        }
        private void OnFocus(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            //lblMessage.Text = "";
        }


        private void addRow(string no, string barcode, string datetime)
        {
            String[] row = { no, barcode, datetime };
            dataGridViewSerial.Rows.Add(row);
        }

        private void refreshForm()
        {
            dataGridViewSerial.Rows.Clear();
            dataGridViewSerial.Refresh();

            txtBarcode.Text = "";
            txtBarcode.Focus();
            if (serialD_Result_arr != null)
                serialD_Result_arr.Clear();

        }



        private void btnBarCode_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSearch.Visible = false;
                dataGridViewSerial.Visible = true;
                using (SerialEntities db = new SerialEntities())
                {
                    lblMessage.ForeColor = Color.White;
                    if (serialD_Result_arr == null)
                    {


                        cbbModel.Focus();
                        lblMessage.Text = "Model is NULL!!!";

                    }
                    else if (txtBarcode.Text == "" || txtBarcode.Text == null)
                    {


                        txtBarcode.Focus();
                        lblMessage.Text = "Serial is NULL!!!";
                    }
                    else
                    {
                        if ((txtBarcode.Text != "" || txtBarcode.Text != null) && serialD_Result_arr.getSize() < rep_num)
                        {
                            var serialD = txtBarcode.Text;
                            if (!serialD_Result_arr.Add(serialD))
                            {


                                txtBarcode.Text = "";
                                txtBarcode.Focus();
                                lblMessage.Text = "Duplicate!!!";
                            }
                            else
                            {
                                lblMessage.Text = "";
                                addRow(serialD_Result_arr.getSize().ToString(), txtBarcode.Text, DateTime.Now.ToString());
                                txtBarcode.Text = "";
                                txtBarcode.Focus();


                            };

                        }
                        else if ((txtBarcode.Text != "" || txtBarcode.Text != null) && serialD_Result_arr.getSize() == rep_num)
                        {

                            var serialM = txtBarcode.Text;
                            if (!serialD_Result_arr.Add(serialM))
                            {


                                txtBarcode.Text = "";
                                txtBarcode.Focus();
                                lblMessage.Text = "Duplicate!!!";
                            }
                            else
                            {
                                serialAlready = txtBarcode.Text;
                                int count = db.SerialDs.Where(d => d.SerialM == serialAlready).Count();
                                if (count > 0)
                                {

                                   createDate = db.SerialDs
                                        .Where(d => d.SerialM == serialAlready)
                                        .Min(d => d.UpdTime).ToString();

                                    error_detective = true;

                                }

                                
                                addRow(serialD_Result_arr.getSize().ToString(), txtBarcode.Text, DateTime.Now.ToString());
                                serialD_Result_arr.RemoveAt(rep_num);


                                for (int i = 0; i < serialD_Result_arr.getSize(); i++)
                                {
                                    var addEntity = db.Entry(new SerialD
                                    {
                                        SerialM = serialM,
                                        SerialD1 = serialD_Result_arr.GetElement(i),
                                        SerialDId = i + 1,
                                        UpdTime = DateTime.Now

                                    });
                                    addEntity.State = System.Data.Entity.EntityState.Added;
                                    db.SaveChanges();
                                }

                                dataGridViewSerial.Rows.Clear();
                                dataGridViewSerial.Refresh();

                                txtBarcode.Text = "";
                                txtBarcode.Focus();
                                serialD_Result_arr.Clear();
                                serialM = "";
                                lblMessage.Text = "Save successfull!!!";
                                lblMessage.ForeColor = Color.DarkCyan;

                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                if (error_detective)
                {
                    lblMessage.Text =  $"The program met ERROR because serial {serialAlready} was created at {createDate}";
                    error_detective = false ;
                }
                else
                {
                    lblMessage.Text = ex.Message;
                }

                refreshForm();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBarCode_Click(this, new EventArgs());
        }

        private void cbbModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbModel.SelectedItem != null)
            {
                Model selectedModel = (Model)cbbModel.SelectedItem;
                string displayMemberValue = selectedModel.Name;
                if (displayMemberValue.Split('_')[1].Substring(0, 1) == "3")
                {
                    refreshForm();
                    rep_num = 3;
                    serialD_Result_arr = new UniqueArray<string>(rep_num + 1);


                }
                else if (displayMemberValue.Split('_')[1].Substring(0, 1) == "5")
                {
                    refreshForm();
                    rep_num = 5;
                    serialD_Result_arr = new UniqueArray<string>(rep_num + 1);

                }

            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void dataGridViewSearch_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewSearch.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

