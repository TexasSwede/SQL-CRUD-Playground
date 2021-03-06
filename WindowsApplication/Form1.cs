﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; 
            btnLoad.Enabled = false;
            SqlDataReader rdr = null;
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Server=" + serverName.Text + ";Database=" + dbName.Text + ";User ID=ParaReader;Password=Reader2014";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("dbo." + procedureNameRead.Text, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cProdCode", ProducerCode.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    AgencyName.Text = rdr["AgencyName"].ToString();
                    AgencyAddress1.Text = rdr["AgencyAddress1"].ToString();
                    AgencyAddress2.Text = rdr["AgencyAddress2"].ToString();
                    AgencyCity.Text = rdr["AgencyCity"].ToString();
                    AgencyState.Text = rdr["AgencyState"].ToString();
                    AgencyZIP.Text = rdr["AgencyZIP"].ToString();
                }
                TexasSwedeLogo.Visible = true;
                var result = MessageBox.Show(procedureNameRead.Text + " has finished.", "Read Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoad.Enabled = true;
                TexasSwedeLogo.Visible = false;
                this.Cursor = Cursors.Default; 
            }
            finally
            {

                //Close the connections 
                if (cnn != null)
                {
                    cnn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
                this.Cursor = Cursors.Default;
                btnLoad.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            this.Cursor = Cursors.WaitCursor; 
            SqlConnection con = null;
            SqlCommand cmd = null;
            string connectionString = null;
            string xml = null;
            connectionString = "Server=" + serverName.Text + ";Database=" + dbName.Text + ";User ID=ParaReader;Password=Reader2014";
            int retval = 0;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(procedureNameCreate.Text, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProducerCode", ProducerCode.Text);
                cmd.Parameters.AddWithValue("@AgencyName", AgencyName.Text);
                cmd.Parameters.AddWithValue("@AgencyAddress1", AgencyAddress1.Text);
                cmd.Parameters.AddWithValue("@AgencyAddress2", AgencyAddress2.Text);
                cmd.Parameters.AddWithValue("@AgencyCity", AgencyCity.Text);
                cmd.Parameters.AddWithValue("@AgencyState", AgencyState.Text);
                cmd.Parameters.AddWithValue("@AgencyZIP", AgencyZIP.Text);
                SqlParameter ret = new SqlParameter("@retval", SqlDbType.Int);
                ret.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ret);
                con.Open();
                retval = Convert.ToInt32(cmd.ExecuteNonQuery());
                con.Close();
                TexasSwedeLogo.Visible = true;
                var result = MessageBox.Show(procedureNameCreate.Text + " returns " + retval.ToString(), "Create Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TexasSwedeLogo.Visible = false;
                btnCreate.Enabled = true;
                this.Cursor = Cursors.Default; 
            }
            finally
            {
                //Close the connections 
                if (cmd != null)
                {
                    //cmd.Close();
                    cmd.Dispose();
                }
                if (con != null)
                {
                    con.Close();
                }
                this.Cursor = Cursors.Default;
                btnCreate.Enabled = true;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            this.Cursor = Cursors.WaitCursor; 
            SqlConnection con = null;
            SqlCommand cmd = null;
            string connectionString = null;
            string xml = null;
            connectionString = "Server=" + serverName.Text + ";Database=" + dbName.Text + ";User ID=ParaReader;Password=Reader2014";
            int retval = 0;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(procedureNameDelete.Text, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProdCode", ProducerCode.Text);
                SqlParameter ret = new SqlParameter("@retval", SqlDbType.Int);
                ret.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ret);
                con.Open();
                retval = Convert.ToInt32(cmd.ExecuteNonQuery());
                con.Close();
                TexasSwedeLogo.Visible = true;
                var result = MessageBox.Show(procedureNameDelete.Text + " returns " + retval.ToString(), "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TexasSwedeLogo.Visible = false;
                btnDelete.Enabled = true;
                this.Cursor = Cursors.Default; 
            }
            finally
            {
                //Close the connections 
                if (cmd != null)
                {
                    //cmd.Close();
                    cmd.Dispose();
                }
                if (con != null)
                {
                    con.Close();
                }
                this.Cursor = Cursors.Default;
                btnDelete.Enabled = true;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            AgencyName.Text = "";
            AgencyAddress1.Text = "";
            AgencyAddress2.Text = "";
            AgencyCity.Text = "";
            AgencyState.Text = "";
            AgencyZIP.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            SqlConnection con = null;
            SqlCommand cmd = null;
            string connectionString = null;
            string xml = null;
            connectionString = "Server=" + serverName.Text + ";Database=" + dbName.Text + ";User ID=ParaReader;Password=Reader2014";
            int retval = 0;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(procedureNameUpdate.Text, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProducerCode", ProducerCode.Text);
                cmd.Parameters.AddWithValue("@AgencyName", AgencyName.Text);
                cmd.Parameters.AddWithValue("@AgencyAddress1", AgencyAddress1.Text);
                cmd.Parameters.AddWithValue("@AgencyAddress2", AgencyAddress2.Text);
                cmd.Parameters.AddWithValue("@AgencyCity", AgencyCity.Text);
                cmd.Parameters.AddWithValue("@AgencyState", AgencyState.Text);
                cmd.Parameters.AddWithValue("@AgencyZIP", AgencyZIP.Text);
                SqlParameter ret = new SqlParameter("@retval", SqlDbType.Int);
                ret.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ret);
                con.Open();
                retval = Convert.ToInt32(cmd.ExecuteNonQuery());
                con.Close();
                TexasSwedeLogo.Visible = true;
                var result = MessageBox.Show(procedureNameUpdate.Text + " returns " + retval.ToString(), "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TexasSwedeLogo.Visible = false;
                btnUpdate.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            finally
            {
                //Close the connections 
                if (cmd != null)
                {
                    //cmd.Close();
                    cmd.Dispose();
                }
                if (con != null)
                {
                    con.Close();
                }
                this.Cursor = Cursors.Default;
                btnUpdate.Enabled = true;
            }

        }



        

    }
}
