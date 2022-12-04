using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace JobTracker
{
    public partial class Form1 : Form
    {
        //string connection 
        string path = @"Data Source=DESKTOP-AQCP1HL\SQLEXPRESS;Initial Catalog=MSSA;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtcompany.Text == " " || txtposition.Text == " " || txtdate.Text == " ")
            {
                MessageBox.Show("Please fill in the blanks! ");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into MSSA(Company_Name,Position_Applied,Date_Applied)values('" + txtcompany.Text + "','" + txtposition.Text + "','" + txtdate.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Data has been saved in the Database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            clear();
            display();
        }
        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select *from MSSA", con);
                adpt.Fill(dt);
                dtDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            txtcompany.Text = " ";
            txtposition.Text = " ";
            txtdate.Text = " ";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update MSSA set Company_Name='" + txtcompany.Text + "',Position_Applied='" + txtposition + "',Date_Applied ='" + txtdate + "'where Company_Id='" + ID + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been updated");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from MSSA where Company_Id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been deleted");
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("Select *from MSSA where Company_Name like '%" + txtcompany.Text + "%'", con);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dtDataGridView.DataSource = dt;
            con.Close();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                //Making object 
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;

                //getting gridview rows
                for (int j = 2; j < dtDataGridView.Rows.Count; j++)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        ws.Cells[j, i] = dtDataGridView.Rows[j - 2].Cells[i - 1].Value;
                    }
                }
                //to getting the columns from gridview
                for (int i = 1; i < dtDataGridView.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dtDataGridView.Columns[i - 1].HeaderText;
                }
                //to get ALL  data from gridview
                for (int i = 0; i < dtDataGridView.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < dtDataGridView.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dtDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dtDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtcompany.Text = dtDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtposition.Text = dtDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdate.Text = dtDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
