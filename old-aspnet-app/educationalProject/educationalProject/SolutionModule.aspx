<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="SolutionModule.aspx.cs" Inherits="educationalProject.SolutionModule" %>
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
            <h2>Administrator Solution</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <!-- single-well start-->
       
        <!-- single-well end-->
       
              <a href="#">
                <h4 class="sec-head">solution module</h4>
              </a>
              
                                                                       
                <br />

			
            
             
             
               <div class="field your-name form-group">
                    SOLUTION:<asp:TextBox ID="txtSolution" runat="server" Height="150px" TextMode="MultiLine" Width="750px"></asp:TextBox>
                
                  <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtSolution" ErrorMessage="Enter Solution" 
                        ValidationGroup="a" CssClass="error"></asp:RequiredFieldValidator>
                
               </div>

               

               
               
            <div>           
            <asp:Button ID="btnUpdate" runat="server" Text="Update Solution" 
                    class="btn btn-theme pull-left" ValidationGroup="a" onclick="btnUpdate_Click" 
             />
               </div>
               <br />
                 <br />
              <!--<marquee scrolldelay="150" behavior="alternate">
          <img src="../img/Edu_Banner1.jpg"" width="460" height="200" alt="" /> &nbsp
          <img src="../img/Edu_Banner2.jpg" width="460" height="200" alt="" /> &nbsp
         <img src="../img/Edu_Banner3.jpg" width="460" height="200" alt="" /> &nbsp
          </marquee>-->


    </asp:Panel>

</asp:Content>
