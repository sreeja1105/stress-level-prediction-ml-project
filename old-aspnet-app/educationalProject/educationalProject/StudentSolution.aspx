<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="StudentSolution.aspx.cs" Inherits="educationalProject.StudentSolution" %>
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
            <h2>Solution</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <!-- single-well start-->
       
        <!-- single-well end-->
       
              <a href="#">
                <h4 class="sec-head">Admin Solution</h4>
              </a>
              
                                                                       
                <br />
                  <div class="field your-name form-group">
                    SOLUTION:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                      <asp:TextBox ID="txtSolution" runat="server" TextMode="MultiLine" Height="150px" Width="750px" 
                          Enabled="False"></asp:TextBox>
                
                  <br />
                   
                
               </div>

			
            
             
             
          
                 <br />
              <!--<marquee scrolldelay="150" behavior="alternate">
          <img src="../img/Edu_Banner1.jpg"" width="460" height="200" alt="" /> &nbsp
          <img src="../img/Edu_Banner2.jpg" width="460" height="200" alt="" /> &nbsp
         <img src="../img/Edu_Banner3.jpg" width="460" height="200" alt="" /> &nbsp
          </marquee>-->


    </asp:Panel>

</asp:Content>
