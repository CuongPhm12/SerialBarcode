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

namespace ConnectingManySerials
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int rep_num = 0;
        string _serialM;
        UniqueArray<string> serialD_Result;
        public Form1()
        {
         
            InitializeComponent();
            dataGridviewSearch.Visible = false;
            dataGridViewSerial.Visible = true;
            FillDateCombobox();
            customizeGrid();

        }
        public Form1(string serialM)
        {
            
            dataGridviewSearch?.Rows?.Clear();
            dataGridviewSearch?.Refresh();

            _serialM = serialM;
            
            InitializeComponent();
            txtSerial.Text = _serialM;
            dataGridViewSerial.Visible = false;
            dataGridviewSearch.Visible = true;
            FillDateCombobox();
            customizeGrid();
            using (SerialEntities db = new SerialEntities())
            {
                //var result = from x in db.SerialDs where x.SerialM == serialM select x;
                var result = db.SerialDs.Where(x => x.SerialM == _serialM).ToList();
                dataGridviewSearch.DataSource = result;
            }
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

            dataGridViewSerial.RowHeadersVisible = false;
        }
        private void FillDateCombobox()
        {
            List<Model> models = new List<Model>();
            models.Add(new Model { Id = 1, Name = "Test1_3pcb" });
            models.Add(new Model { Id = 2, Name = "Test3_5pcb" });
            cbModel.DataSource = models;
            cbModel.ValueMember = "Id";
            cbModel.DisplayMember = "Name";
            cbModel.SelectedIndex = -1;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dX_TESTDataSet.SerialD' table. You can move, or remove it, as needed.
            //this.serialDTableAdapter.Fill(this.dX_TESTDataSet.SerialD);
            this.txtSerial.GotFocus += OnFocus;
            this.txtSerial.LostFocus += OnDefocus;



        }
        private void OnFocus(object sender, EventArgs e)
        {
            lbMessage.Text = "";
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            //lbMessage.Text = "";
        }




        private void addRow(string no, string barcode)
        {
            String[] row = { no, barcode };
            dataGridViewSerial.Rows.Add(row);
        }

        private void refreshForm()
        {
            dataGridViewSerial.Rows.Clear();
            dataGridViewSerial.Refresh();

            txtSerial.Text = "";
            txtSerial.Focus();
            if (serialD_Result != null)
                serialD_Result.Clear();
            //serialM = "";

        }





        private void txtSerial_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBarCode_Click(this, new EventArgs());
        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridviewSearch.Visible = false;
                dataGridViewSerial.Visible = true;
                using (SerialEntities db = new SerialEntities())
                {
                    lbMessage.ForeColor = Color.FromArgb(255, 128, 128);
                    if (serialD_Result == null)
                    {
                        //MessageBox.Show("Model is NULL!!!");

                        cbModel.Focus();
                        lbMessage.Text = "Model is NULL!!!";

                    }
                    else if (txtSerial.Text == "" || txtSerial.Text == null)
                    {
                        //MessageBox.Show("Serial is NULL!!!");

                        txtSerial.Focus();
                        lbMessage.Text = "Serial is NULL!!!";
                    }
                    else
                    {
                        if ((txtSerial.Text != "" || txtSerial.Text != null) && serialD_Result.getSize() < rep_num)
                        {
                            var serialD = txtSerial.Text;
                            if (!serialD_Result.Add(serialD))
                            {

                                //MessageBox.Show("Duplicate");

                                txtSerial.Text = "";
                                txtSerial.Focus();
                                lbMessage.Text = "Duplicate!!!";
                            }
                            else
                            {
                                lbMessage.Text = "";
                                addRow(serialD_Result.getSize().ToString(), txtSerial.Text);
                                txtSerial.Text = "";
                                txtSerial.Focus();

                                //if (serialD_Result.getSize() == rep_num)
                                //{
                                //    MessageBox.Show("Full");
                                //    //num = 0;
                                //}

                            };

                        }
                        else if ((txtSerial.Text != "" || txtSerial.Text != null) && serialD_Result.getSize() == rep_num)
                        {
                            var serialM = txtSerial.Text;
                            if (!serialD_Result.Add(serialM))
                            {

                                //MessageBox.Show("Duplicate");

                                txtSerial.Text = "";
                                txtSerial.Focus();
                                lbMessage.Text = "Duplicate!!!";
                            }
                            else
                            {
                                addRow(serialD_Result.getSize().ToString(), txtSerial.Text);
                                serialD_Result.RemoveAt(rep_num);


                                for (int i = 0; i < serialD_Result.getSize(); i++)
                                {
                                    var addEntity = db.Entry(new SerialD
                                    {
                                        SerialM = serialM,
                                        SerialD1 = serialD_Result.GetElement(i),
                                        SerialDId = i + 1,
                                        UpdTime = DateTime.Now

                                    });
                                    addEntity.State = System.Data.Entity.EntityState.Added;
                                    db.SaveChanges();
                                }
                                //MessageBox.Show("Save successfully!!!");
                                //lbMessage.Text = "Save successfully!!!";
                                dataGridViewSerial.Rows.Clear();
                                dataGridViewSerial.Refresh();

                                txtSerial.Text = "";
                                txtSerial.Focus();
                                serialD_Result.Clear();
                                serialM = "";
                                lbMessage.Text = "Save successfull!!!";
                                lbMessage.ForeColor = Color.DarkCyan;

                            };


                        }
                        //else
                        //{
                        //    MessageBox.Show("Serial is NULL!!!");
                        //}


                    }



                }
            }
            catch (Exception ex)
            {

                lbMessage.Text = ex.Message;
            }
        }

        private void cbModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbModel.SelectedItem != null)
            {
                Model selectedModel = (Model)cbModel.SelectedItem;
                string displayMemberValue = selectedModel.Name;
                if (displayMemberValue.Split('_')[1].Substring(0, 1) == "3")
                {
                    refreshForm();
                    rep_num = 3;
                    serialD_Result = new UniqueArray<string>(rep_num + 1);


                }
                else if (displayMemberValue.Split('_')[1].Substring(0, 1) == "5")
                {
                    refreshForm();
                    rep_num = 5;
                    serialD_Result = new UniqueArray<string>(rep_num + 1);

                }


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridviewSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridviewSearch.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
