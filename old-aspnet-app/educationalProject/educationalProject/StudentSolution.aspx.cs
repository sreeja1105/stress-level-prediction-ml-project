using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationalProject
{
    public partial class StudentSolution : System.Web.UI.Page
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
                tab = obj.GetResultsByRegNo(Session["RegNo"].ToString());

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
    }
}