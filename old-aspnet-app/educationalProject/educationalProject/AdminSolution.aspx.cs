using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationalProject
{
    public partial class AdminSolution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Session.Abandon();
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                LoadAllStudents();
            }
        }

        //function to load all students
        private void LoadAllStudents()
        {
            try
            {
                DataTable tab = new DataTable();
                BLL obj = new BLL();

                int serialNo = 1;

                tab = obj.GetAllStudentsResults();

                if (tab.Rows.Count > 0)
                {
                    tableStudents.Rows.Clear();

                    tableStudents.BorderStyle = BorderStyle.Double;
                    tableStudents.GridLines = GridLines.Both;
                    tableStudents.BorderColor = System.Drawing.Color.DarkGray;

                    TableRow mainrow = new TableRow();
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                    mainrow.BackColor = System.Drawing.Color.DeepSkyBlue;

                    TableCell cell1 = new TableCell();
                    cell1.Text = "<b>SerialNo</b>";
                    mainrow.Controls.Add(cell1);

                    TableCell cell21 = new TableCell();
                    cell21.Text = "<b>RegNo</b>";
                    mainrow.Controls.Add(cell21);

                    TableCell cell2 = new TableCell();
                    cell2.Text = "<b>Gender</b>";
                    mainrow.Controls.Add(cell2);

                    TableCell cell5 = new TableCell();
                    cell5.Text = "<b>Financial</b>";
                    mainrow.Controls.Add(cell5);

                    TableCell cell62 = new TableCell();
                    cell62.Text = "<b>Family</b>";
                    mainrow.Controls.Add(cell62);

                    TableCell cell63 = new TableCell();
                    cell63.Text = "<b>Study</b>";
                    mainrow.Controls.Add(cell63);

                    TableCell cell64 = new TableCell();
                    cell64.Text = "<b>Teaching</b>";
                    mainrow.Controls.Add(cell64);


                    TableCell cell641 = new TableCell();
                    cell641.Text = "<b>Health</b>";
                    mainrow.Controls.Add(cell641);

                    TableCell cell642 = new TableCell();
                    cell642.Text = "<b>Partiality</b>";
                    mainrow.Controls.Add(cell642);

                    TableCell cell643 = new TableCell();
                    cell643.Text = "<b>Exam</b>";
                    mainrow.Controls.Add(cell643);

                    TableCell cell644 = new TableCell();
                    cell644.Text = "<b>Friend</b>";
                    mainrow.Controls.Add(cell644);

                    TableCell cell645 = new TableCell();
                    cell645.Text = "<b>Pressure</b>";
                    mainrow.Controls.Add(cell645);

                    TableCell cell646 = new TableCell();
                    cell646.Text = "<b>Regular</b>";
                    mainrow.Controls.Add(cell646);

                    TableCell cell647 = new TableCell();
                    cell647.Text = "<b>Interaction</b>";
                    mainrow.Controls.Add(cell647);

                    TableCell cell648 = new TableCell();
                    cell648.Text = "<b>Result</b>";
                    mainrow.Controls.Add(cell648);

                    TableCell cell65 = new TableCell();
                    cell65.Text = "<b>Solution</b>";
                    mainrow.Controls.Add(cell65);

                    TableCell cell66 = new TableCell();
                    cell66.Text = "<b>Update</b>";
                    mainrow.Controls.Add(cell66);

                    tableStudents.Controls.Add(mainrow);

                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        TableRow row = new TableRow();

                        TableCell cellSerialNo = new TableCell();
                        cellSerialNo.Width = 50;
                        cellSerialNo.Text = serialNo + i + ".";
                        row.Controls.Add(cellSerialNo);

                        TableCell cellRegNo = new TableCell();
                        cellRegNo.Width = 150;
                        cellRegNo.Text = tab.Rows[i]["RegNo"].ToString();
                        row.Controls.Add(cellRegNo);

                        TableCell cellName = new TableCell();
                        cellName.Width = 150;
                        cellName.Text = tab.Rows[i]["Gender"].ToString();
                        row.Controls.Add(cellName);

                        TableCell cellCourse = new TableCell();
                        cellCourse.Width = 150;
                        cellCourse.Text = tab.Rows[i]["FinancialIssues"].ToString();
                        row.Controls.Add(cellCourse);

                        TableCell cellSem = new TableCell();
                        cellSem.Width = 80;
                        cellSem.Text = tab.Rows[i]["FamilyIssues"].ToString();
                        row.Controls.Add(cellSem);

                        TableCell cellContactNo = new TableCell();
                        cellContactNo.Width = 150;
                        cellContactNo.Text = tab.Rows[i]["StudyHrs"].ToString();
                        row.Controls.Add(cellContactNo);

                        TableCell cellEmailId = new TableCell();
                        cellEmailId.Width = 150;
                        cellEmailId.Text = tab.Rows[i]["TeachingMethod"].ToString();
                        row.Controls.Add(cellEmailId);


                        TableCell cellHealth = new TableCell();
                        cellHealth.Width = 150;
                        cellHealth.Text = tab.Rows[i]["HealthIssues"].ToString();
                        row.Controls.Add(cellHealth);

                        TableCell cellPartility = new TableCell();
                        cellPartility.Width = 150;
                        cellPartility.Text = tab.Rows[i]["PartialityFix"].ToString();
                        row.Controls.Add(cellPartility);


                        TableCell cellExam = new TableCell();
                        cellExam.Width = 150;
                        cellExam.Text = tab.Rows[i]["ExamSchedule"].ToString();
                        row.Controls.Add(cellExam);

                        TableCell cellFI = new TableCell();
                        cellFI.Width = 150;
                        cellFI.Text = tab.Rows[i]["FriendIssues"].ToString();
                        row.Controls.Add(cellFI);

                        TableCell cellPressure = new TableCell();
                        cellPressure.Width = 150;
                        cellPressure.Text = tab.Rows[i]["Pressure"].ToString();
                        row.Controls.Add(cellPressure);

                        TableCell cellRegular = new TableCell();
                        cellRegular.Width = 150;
                        cellRegular.Text = tab.Rows[i]["Regular"].ToString();
                        row.Controls.Add(cellRegular);

                        TableCell cellInteraction = new TableCell();
                        cellInteraction.Width = 150;
                        cellInteraction.Text = tab.Rows[i]["Interaction"].ToString();
                        row.Controls.Add(cellInteraction);

                        TableCell cellR = new TableCell();
                        cellR.Width = 150;
                        cellR.Text = tab.Rows[i]["Result"].ToString();
                        row.Controls.Add(cellR);


                        TableCell cellS= new TableCell();
                        cellS.Width = 350;
                        cellS.Text = tab.Rows[i]["Solution"].ToString();
                        row.Controls.Add(cellS);

                       

                        TableCell cell_delete = new TableCell();
                        cell_delete.Width = 100;
                        LinkButton lbtn_delete = new LinkButton();
                        lbtn_delete.ForeColor = System.Drawing.Color.Red;
                        lbtn_delete.Font.Bold = true;
                        lbtn_delete.Text = "Update";

                        lbtn_delete.ID = "Delete~" + tab.Rows[i]["RegNo"].ToString() + "~" + tab.Rows[i]["SolutionId"].ToString();                        
                        lbtn_delete.Click += new EventHandler(lbtn_delete_Click);
                        cell_delete.Controls.Add(lbtn_delete);
                        row.Controls.Add(cell_delete);

                        tableStudents.Controls.Add(row);
                    }
                }
                else
                {
                    tableStudents.Rows.Clear();

                    TableHeaderRow rno = new TableHeaderRow();
                    TableHeaderCell cellno = new TableHeaderCell();
                    cellno.ForeColor = System.Drawing.Color.Red;
                    cellno.Text = "No Students Found!!!";

                    rno.Controls.Add(cellno);
                    tableStudents.Controls.Add(rno);
                }
            }
            catch
            {

            }
        }

        void lbtn_delete_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            LinkButton lbtn = (LinkButton)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                Response.Redirect(string.Format("SolutionModule.aspx?reg={0}&id={1}", s[1], s[2]));            

            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!!!')</script>");
            }
        }

       
    }
}