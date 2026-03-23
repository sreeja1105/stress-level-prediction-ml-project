using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationalProject
{
    public partial class SolutionModule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtSolution.Focus();
                LoadSolution();
            }
        }

        private void LoadSolution()
        {
            try
            {
                BLL obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetResultsByRegNo(Request.QueryString["reg"].ToString());

                if (tab.Rows.Count > 0)
                {
                    if (tab.Rows[0]["Solution"].ToString().Equals(""))
                    {

                    }
                    else
                    {
                        txtSolution.Text = tab.Rows[0]["Solution"].ToString();
                    }
                }
            }
            catch
            {

            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                BLL obj = new BLL();
                tab.Rows.Clear();

                obj.UpdateSolution(txtSolution.Text,int.Parse(Request.QueryString["id"].ToString()));

                
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Solution Added successfully')</script>");
                txtSolution.Text=string.Empty;
            }
            catch
            {

            }
        }
    }
}