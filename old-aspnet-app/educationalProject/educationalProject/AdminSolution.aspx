<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="AdminSolution.aspx.cs" Inherits="educationalProject.AdminSolution" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <!-- Start contact Area -->  
    <div id="about" class="about-area area-padding">
   <div class="container">
      <div class="row">
        <div class="col-md-12 col-sm-12 col-xs-12">
          <div class="section-headline text-center">
            <h2>View Students Parameters and Solution</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <!-- single-well start-->
       
        <!-- single-well end-->
       
              <a href="#">
                <h4 class="sec-head">View Students Results</h4>
              </a>
              
                                                                       
                

               
                     <asp:Table ID="tableStudents" runat="server">
                     </asp:Table>
              

     <br />
      <br />
      <h3>Parameter Descriptions</h3>
     <h6>Gender: 1- male , 2 - female</h6>
      <h6>Financial_Issues: 0- No , 1 - Yes</h6>
       <h6>Family_Issues: 0- No , 1 - Yes</h6>
       <h6>Study_Hours: Numeric 1,2,3 ....</h6>
        <h6>Teaching_Method: 0- Fair / 1- Not Good.</h6>
         <h6>Health_Issues: 0- No , 1 - Yes</h6>
         <h6>Partiality_Fix: 0- No , 1 - Yes</h6>
         <h6>Exam_Schedule: 1-Monthly/ 2-Half/ 3-yearly/ 4-Annual/ 5-Slip Test/</h6>
          <h6>Friends_Issue: 0- No , 1 - Yes</h6>
          <h6>Pressure: 0- No , 1 - Yes</h6>
          <h6>Regular: 1- No , 2 - Yes</h6>
          <h6>Interaction: 1- Excellent , 2 - Good, 3 - Average, 4 - Poor</h6>
          <h6>
             Outcome: 0 - Normal, 1 - 25% Stress Level, <br />
             2 - 50% Stress level, 3 - 100% Stress 
             Level</h6>


     <br />

        <!-- End col-->
      </div>
    </div>
    </div>
  <!-- End Contact Area -->


    </asp:Panel>



</asp:Content>
