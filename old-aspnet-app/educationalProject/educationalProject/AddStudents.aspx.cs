using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Globalization;
using System.Collections;
using System.Reflection;

namespace educationalProject
{
    public partial class AddStudents : System.Web.UI.Page
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
                if (!this.IsPostBack)
                {                   
                    txtRegNo.Focus();

                    if (Request.QueryString["regNo"] == null)
                    {

                    }
                    else
                    {
                        LoadStudent();
                    }
                }

               
            }
        }

        //function to load student details
        private void LoadStudent()
        {
            BLL obj = new BLL();
            DataTable tab = new DataTable();
            tab = obj.GetStudentById(Request.QueryString["regNo"]);

            Session["regNo"] = null;
            Session["regNo"] = Request.QueryString["regNo"];                       

            if (tab.Rows.Count > 0)
            {
                txtRegNo.Text = tab.Rows[0]["RegNo"].ToString();
                //txtPassword.Text = tab.Rows[0]["Password"].ToString();
                txtName.Text = tab.Rows[0]["Name"].ToString();                
                txtMobile.Text = tab.Rows[0]["Mobile"].ToString();
                txtEmailId.Text = tab.Rows[0]["EmailId"].ToString();
                txtDept.Text = tab.Rows[0]["DeptName"].ToString();
                txtSem.Text = tab.Rows[0]["Sem"].ToString();              
            }

            btnSubmit.Text = "Update Student";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();

            if (btnSubmit.Text.Equals("Add Student"))
            {
                try
                {
                    if (obj.CheckStudentRegNo(txtRegNo.Text))
                    {
                        obj.InsertStudent(txtRegNo.Text, txtPassword.Text, txtName.Text, txtMobile.Text, txtEmailId.Text, txtDept.Text, int.Parse(txtSem.Text));
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('New Student Added Successfully!!!')</script>");
                        

                        //Emails.MailSender.SendEmail("stressprediction@gmail.com", "stress123789", txtEmailId.Text, "Access Credentialis", "Your User Id and Password: " + txtRegNo.Text + ", " + txtPassword.Text, "");

                        MailMessage mm = new MailMessage("stressprediction@gmail.com", txtEmailId.Text);
                        mm.Subject = "Access Credentialis";
                        mm.Body = "Your User Id: " + txtRegNo.Text + ",  and Password: " + txtPassword.Text;

                        //string attach = txtBatchNo.Text + ".pdf";

                        //mm.Attachments.Add(new Attachment(new MemoryStream(bytes), attach));

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("stressprediction@gmail.com", "stress123789");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;

                        smtp.Port = 587;
                        smtp.Send(mm);

                        ClearTxts();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('RegNo Exists!!!')</script>");
                    }
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                }
            }
            else if (btnSubmit.Text.Equals("Update Student"))
            {
                if (txtRegNo.Text.Equals(Session["regNo"].ToString()))
                {
                    try
                    {
                        obj.UpdateStudent(txtRegNo.Text, txtPassword.Text, txtName.Text, txtMobile.Text, txtEmailId.Text, txtDept.Text, int.Parse(txtSem.Text));

                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Student Updated Successfully!!!')</script>");
                        ClearTxts();

                        btnSubmit.Text = "Add Student";

                    }
                    catch
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                    }
                }
                else
                {
                    if (obj.CheckStudentRegNo(txtRegNo.Text))
                    {
                        try
                        {
                            obj.UpdateStudent(txtRegNo.Text, txtPassword.Text, txtName.Text, txtMobile.Text, txtEmailId.Text, txtDept.Text, int.Parse(txtSem.Text));

                            ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Student Updated Successfully!!!')</script>");
                            ClearTxts();

                            btnSubmit.Text = "Add Student";

                        }
                        catch
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('Server Error!')</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('RegNo Exists!!!')</script>");
                    }
                }
            }
        }

        //function to clear text box contents
        private void ClearTxts()
        {
            txtMobile.Text = txtEmailId.Text = txtName.Text = txtRegNo.Text = txtSem.Text = txtDept.Text = string.Empty;
            
        }

    }
}