using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResturentPos.utils;
using ResturentPos.controllers;

namespace ResturentPos.views
{
    public partial class CashierForm : MetroFramework.Forms.MetroForm
    {
        //utils validation instance
        Validations validate = new Validations();

        //db controller instance
        dbController database = new dbController();

        //helpers instance to get data to cb
        Helpers configure = new Helpers();

        public CashierForm()
        {
            InitializeComponent();
        }
        

        private void metroUserControlCatergoryMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCatergory_Click(object sender, EventArgs e)
        {
            if (validate.validateTextBoxes(tbCatergory))
            {
                try
                {
                    //add catergory to tbl
                    database.insert("insert into catergories values ('"+ tbCatergory.Text +"');");

                    //refresh table
                    tblCatergories.DataSource = database.select("select * from catergories;");

                    //show success alert
                    MetroFramework.MetroMessageBox.Show(this, tbCatergory.Text+" Added As A New Catergory..!", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "SQL Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Catergory To Add..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            try
            {
                //get catergory data to tbl
                tblCatergories.DataSource = database.select("select * from catergories;");

                //setup data to send as a DataTable
                var dataCat = database.select("select catergories.catergory from catergories;");

                //send and assign ComboBox
                cbCatergories.DataSource = configure.getDataToComboBox(dataCat);

                gbBillMenu.Show();
                gbCatergoryMenu.Hide();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "SQL Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //get catergory data to tbl
                tblCatergories.DataSource = database.select("select * from sub_catergories where sub_catergories.main_catergory = '" + cbCatergories.Text + "';");

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "SQL Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSubCatergory_Click(object sender, EventArgs e)
        {
            if (validate.validateTextBoxes(tbSubCatergories))
            {
                try
                {
                    //add catergory to tbl
                    database.insert("insert into sub_catergories values ('" + cbCatergories.Text + "' , '" + tbSubCatergories.Text + "');");

                    //refresh table
                    //tblCatergories.DataSource = database.select("select * from catergories;");

                    //show success alert
                    MetroFramework.MetroMessageBox.Show(this, tbSubCatergories.Text + " Added As A New Sub Catergory..!", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "SQL Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Sub Catergory To Add..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ID;

        private void tblCatergories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(tblCatergories.Rows[e.RowIndex].Cells[0].Value.ToString());
                tbCatergory.Text = tblCatergories.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Data Fetching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCatergory_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    //update catergory
                    database.update("update catergories set catergories.catergory = '"+tbCatergory.Text+"' where catergories.id = '"+ID+"';");

                    //show alert
                    MetroFramework.MetroMessageBox.Show(this, tbCatergory.Text + " Catergory Updated Successfully..!", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //refresh table
                    tblCatergories.DataSource = database.select("select * from catergories;");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select Catergory To Update..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Data Fetching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDeleteCatergory_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    //delete catergory
                    database.delete("delete from catergories where catergories.id= '"+ID+"';");

                    //show alert
                    MetroFramework.MetroMessageBox.Show(this, tbCatergory.Text + " Catergory Deleted Successfully..!", "Data Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //refresh table
                    tblCatergories.DataSource = database.select("select * from catergories;");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Select Catergory To Delete..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Data Fetching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTileCatergoryMenuBtn_Click(object sender, EventArgs e)
        {
            gbCatergoryMenu.Show();
            gbBillMenu.Hide();
        }

        private void metroTileBillMenuBtn_Click(object sender, EventArgs e)
        {
            gbBillMenu.Show();
            gbCatergoryMenu.Hide();
        }
    }
}
