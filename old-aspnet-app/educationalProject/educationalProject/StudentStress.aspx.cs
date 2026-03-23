using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Collections;
using System.Threading;
using System.Configuration;

namespace educationalProject
{
    public partial class StudentStress : System.Web.UI.Page
    {
        public static OleDbConnection oledbConn;
        DataTable dt = new DataTable();
        DataTable dtDistinct = new DataTable();
        static ArrayList _arrayPatientsCnt = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TrainingDS();                
            }
            catch
            {

            }
        }

        private void TrainingDS()
        {
            string FileName = "TrainingDataset.xls";

            string Extension = ".xls";

            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

            string _Location = "TrainingDataset";

            string FilePath = Server.MapPath(FolderPath + FileName);

            ImportTrainingDS(FilePath, Extension, _Location);
        }

        private void ImportTrainingDS(string FilePath, string Extension, string _Location)
        {
            string conStr = "";

            switch (Extension)
            {
                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, _Location);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();
            OleDbCommand cmdDistinct = new OleDbCommand();
            OleDbCommand cmdPatientsCnt = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();
            OleDbDataAdapter odaDistinct = new OleDbDataAdapter();

            cmdExcel.Connection = connExcel;
            cmdDistinct.Connection = connExcel;
            cmdPatientsCnt.Connection = connExcel;
            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

            connExcel.Close();

            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
            cmdDistinct.CommandText = "SELECT DISTINCT(Result) From [" + SheetName + "]";

            oda.SelectCommand = cmdExcel;
            odaDistinct.SelectCommand = cmdDistinct;

            oda.Fill(dt);
            odaDistinct.Fill(dtDistinct);

            //BLL obj = new BLL();

            if (dt.Rows.Count > 0)
            {
                if (dtDistinct.Rows.Count > 0)
                {
                    //for (int i = 0; i < dtDistinct.Rows.Count; i++)
                    //{
                    //    cmdPatientsCnt.CommandText = "SELECT COUNT(*) From [" + SheetName + "] where result=" + dtDistinct.Rows[i]["result"].ToString() + "";
                    //    _arrayPatientsCnt.Add(cmdPatientsCnt.ExecuteScalar());
                    //}
                }

                connExcel.Close();

            }
            else
            {               
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('No Training Dataset!!!')</script>");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string _data = DropDownList1.SelectedValue + "," +
                                 DropDownList2.SelectedValue + "," +
                                DropDownList3.SelectedValue + "," +
                                 DropDownList4.SelectedValue + "," +
                                 DropDownList5.SelectedValue + "," +
                                 DropDownList6.SelectedValue + "," +
                                 DropDownList7.SelectedValue + "," +
                                 DropDownList8.SelectedValue + "," +
                                 DropDownList9.SelectedValue + "," +
                                 DropDownList10.SelectedValue + "," +
                                 DropDownList11.SelectedValue + "," +
                                 DropDownList12.SelectedValue;


                string[] values = _data.Split(',');

                string _output = _KNNAlgorithm(values);

                //lblResult.ForeColor = System.Drawing.Color.Green;
                //lblResult.Font.Bold = true;
                //lblResult.Font.Size = 16;
                //lblResult.Text = "Result: " + _output;



                BLL obj = new BLL();

                if (obj.CheckOutput(Session["RegNo"].ToString()))
                {
                    obj.InsertResult(Session["RegNo"].ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, DropDownList3.SelectedValue, DropDownList4.SelectedValue,
                        DropDownList5.SelectedValue, DropDownList6.SelectedValue, DropDownList7.SelectedValue,
                        DropDownList8.SelectedValue, DropDownList9.SelectedValue, DropDownList10.SelectedValue, DropDownList11.SelectedValue, DropDownList12.SelectedValue, _output);

                    //ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Submitted Successfully')</script>");
                }
                else
                {
                    DataTable tab = new DataTable();
                    tab = obj.GetResultsByRegNo(Session["RegNo"].ToString());

                    obj.UpdateResult(Session["RegNo"].ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, DropDownList3.SelectedValue, DropDownList4.SelectedValue,
                        DropDownList5.SelectedValue, DropDownList6.SelectedValue, DropDownList7.SelectedValue,
                        DropDownList8.SelectedValue, DropDownList9.SelectedValue, DropDownList10.SelectedValue, DropDownList11.SelectedValue, DropDownList12.SelectedValue, _output, int.Parse(tab.Rows[0]["SolutionId"].ToString()));

                    //ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Submitted Successfully')</script>");
                }

                Response.Redirect(string.Format("StudentGraph.aspx?p1={0}", _output));

            }
            catch
            {

            }
        }

        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();

        //function to load subject
        public ArrayList GetSubject()
        {

            ArrayList s = new ArrayList();

            if (dtDistinct.Rows.Count > 0)
            {
                s.Clear();

                for (int i = 0; i < dtDistinct.Rows.Count; i++)
                {
                    if (dtDistinct.Rows[i]["Result"].Equals(""))
                    {
                    }
                    else
                    {
                        s.Add(dtDistinct.Rows[i]["Result"].ToString());
                    }
                }
            }

            return s;

        }

        //function which contains data preprocessing coding
        private void DataPreprocessingMethod()
        {
            try
            {

                //BLL obj = new BLL();
                //DataTable tabDataset = new DataTable();
                ArrayList _mising = new ArrayList();

                //tabDataset.Rows.Clear();
                //fetch the training dataset 
                //tabDataset = obj.GetTrainingDataset();

                if (dt.Rows.Count > 0)
                {
                    //code of binning method
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string _data = dt.Rows[i]["Gender"].ToString() + "," +
                            dt.Rows[i]["Financial_Issues"].ToString() + "," +
                            dt.Rows[i]["Family_Issues"].ToString() + "," +
                            dt.Rows[i]["Study_Hours"].ToString() + "," +
                            dt.Rows[i]["Teaching_Method"].ToString() + "," +
                            dt.Rows[i]["Health_Issues"].ToString() + "," +
                            dt.Rows[i]["Partiality_Fix"].ToString() + "," +
                            dt.Rows[i]["Exam_Schedule"].ToString() + "," +
                            dt.Rows[i]["Friends_Issue"].ToString() + "," +
                            dt.Rows[i]["Pressure"].ToString() + "," +
                            dt.Rows[i]["Regular"].ToString() + "," +
                            dt.Rows[i]["Interaction"].ToString();


                        string[] parameter = _data.Split(',');

                        for (int j = 0; j < parameter.Length; j++)
                        {
                            if (parameter[j].Equals("") || parameter.Equals("?"))
                            {
                                //for (int k = 0; k < tabDataset.Rows.Count; k++)
                                //{
                                //int id = 0;
                                //Random r = new Random();

                                //for (int x = 1; x <= 2; x++)
                                //{
                                //    id = r.Next(9);
                                //}

                                //mean value
                                double _numbers = 0, _meanvalue = 0;
                                for (int k = 0; k < dt.Rows.Count; k++)
                                {
                                    _numbers += double.Parse(dt.Rows[k][parameter[j]].ToString());
                                }

                                _meanvalue = _numbers / dt.Rows.Count;

                                //setting value for ? and null value
                                double _value = _meanvalue;
                                _mising.Add(_value);
                                //}
                            }

                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Dataset Not Found!!!')</script>");
                }
            }
            catch
            {

            }
        }


        //function which contains the algorithm steps
        private string _KNNAlgorithm(string[] values)
        {
            ArrayList _Distance = new ArrayList();
            ArrayList _RecordId = new ArrayList();

            ArrayList s = new ArrayList();
            output.Clear();

            //try
            //{
            s = GetSubject();

            int m = 30; //k value

            //finding the distance between the objects
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double _val = 0.0;

                for (int j = 0; j < values.Length; j++)
                {
                    string _valluee = dt.Rows[i][j].ToString();

                    if (_valluee.Equals("?") || values[j].ToString().Equals("?") ||
                        _valluee.Equals("") || values[j].ToString().Equals(""))
                    {

                    }
                    else
                    {
                        _val += Math.Pow(double.Parse(dt.Rows[i][j].ToString()) - double.Parse(values[j].ToString()), 2);
                    }
                }

                _val = Math.Sqrt(_val);

                _Distance.Add(Math.Round(_val, 1));
                _RecordId.Add(i);
            }

            ArrayList temp = new ArrayList();
            ArrayList arrayRecords = new ArrayList();

            ArrayList arrayExists = new ArrayList();
            int d = 0;

            for (int x = 0; x < _Distance.Count; x++)
            {
                temp.Add(_Distance[x]);
            }

            temp.Sort();

            for (int y = 0; y < m; y++)
            {
                d = 0;

                for (int z = 0; z < _Distance.Count; z++)
                {
                    if (_Distance[z].Equals(temp[y]))
                    {
                        if (d == 0 && !arrayExists.Contains(_RecordId[z]))
                        {
                            arrayRecords.Add(_RecordId[z]);

                            arrayExists.Add(_RecordId[z]);

                            ++d;
                        }
                    }
                }
            }

            string _output = null;

            if (arrayRecords.Count > 0)
            {
                int cnt;

                ArrayList arrayCnt = new ArrayList();
                ArrayList arrayOutcome = new ArrayList();

                for (int i = 0; i < s.Count; i++)
                {
                    cnt = 0;

                    for (int j = 0; j < arrayRecords.Count; j++)
                    {
                        if (dt.Rows[int.Parse(arrayRecords[j].ToString())]["Result"].ToString().Equals(s[i]))
                        {
                            ++cnt;
                        }
                    }

                    arrayCnt.Add(cnt);
                    arrayOutcome.Add(s[i]);
                }

                ArrayList temp1 = new ArrayList();

                for (int x = 0; x < arrayCnt.Count; x++)
                {
                    temp1.Add(arrayCnt[x]);
                }

                temp1.Sort();
                temp1.Reverse();



                for (int y = 0; y < arrayCnt.Count; y++)
                {
                    if (arrayCnt[y].Equals(temp1[0]))
                    {
                        _output = s[y].ToString();

                        //if (_output.Equals("0"))
                        //{
                        //    _output = "No";
                        //}
                        //else
                        //{
                        //    _output = "Yes";
                        //}

                        return _output;

                    }
                }
            }

            return _output;
        }
    }
}