using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace educationalProject
{
    public partial class StudentGraph : System.Web.UI.Page
    {
        Dictionary<string, double> testData = new Dictionary<string, double>();

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);

                if (!IsPostBack)
                {
                    // bind chart type names to ddl
                    ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
                    ddlChartType.DataBind();

                    cbUse3D.Checked = false;

                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Font.Bold = true;
                    lblResult.Font.Size = 16;

                    string _outcome = Request.QueryString["p1"].ToString();

                    if (_outcome.Equals("0"))
                    {
                        lblResult.Text = "Result: Stress Free";
                        btnLevels.Visible = false;
                    }
                    else
                    {
                        lblResult.Text = "Result: Under Stress";
                        btnLevels.Visible = true;
                    }

                    cTestChart.Visible = false;
                }

                DataBind();

            }
            catch
            {

            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            testData.Clear();

            string _outcome = Request.QueryString["p1"].ToString();

            if (_outcome.Equals("0"))
            {
                Image1.Visible = true;
            }
            else if (_outcome.Equals("1"))
            {
                Image1.Visible = false;
                testData.Add("Stress Level", 25.0);
            }
            else if (_outcome.Equals("2"))
            {
                Image1.Visible = false;
                testData.Add("Stress Level", 50.0);
            }
            else if (_outcome.Equals("3"))
            {
                Image1.Visible = false;
                testData.Add("Stress Level", 100.0);
            }

            cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // update chart rendering           
            cTestChart.Series["Testing"].ChartTypeName = "Column";

            cTestChart.ChartAreas[0].Area3DStyle.Enable3D = cbUse3D.Checked;
            cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(rblInclinationAngle.SelectedValue);

            //cTestChart.Visible = true;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            cTestChart.Visible = true;

            OnDataBinding(e);
            OnPreRender(e);
        }

        protected void btnLevels_Click(object sender, EventArgs e)
        {
            cTestChart.Visible = true;
        }
    }
}