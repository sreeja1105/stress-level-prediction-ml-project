<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="StudentStress.aspx.cs" Inherits="educationalProject.StudentStress" %>
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
            <h2>Stress Prediction - Enter Parameters</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <!-- single-well start-->
       
        <!-- single-well end-->
        <div class="col-md-6 col-sm-6 col-xs-12">
          <div class="well-middle">
            <div class="single-well">
              <a href="#">
                <h4 class="sec-head">Student Parameters</h4>
              </a>
              
             <br />

               

                <div class="form-group">
                <p><b>Gender</b></p>

                    <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="1">male</asp:ListItem>
                        <asp:ListItem Value="2">female</asp:ListItem>
                    </asp:DropDownList>
                
                    <br />
                    <br />
                <!--<h6>Gender: 1- male , 2 - female</h6>-->
                </div>
                <div class="form-group">
                 <p><b>Financial_Issues</b></p>
                <ol>
                  <li>Net family income below average</li>
                  <li>Excessive loans and interests</li>
                  <li>Hard time meeting</li> 
                  <li>Fee deadlines or any other financial issues.</li>
                 </ol>
                 <br />
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="0">no</asp:ListItem>
                        <asp:ListItem Value="1">yes</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                 <br />
                   
                 <!--<h6>Financial_Issues: 0- No , 1 - Yes</h6>-->
                </div>

                 <div class="form-group">
                  <p><b>Family_Issues</b></p>
                  <ol>
                  <li>Over expectations from parents</li>
                  <li>Divorce issues of parents</li>
                  <li>Poor communication</li>
                  <li>Being harassed or bullied by siblings or any other family issues.</li>
                  </ol>
                 <br />
                     <asp:DropDownList ID="DropDownList3" runat="server" Height="30px" Width="100px">
                         <asp:ListItem Value="0">no</asp:ListItem>
                         <asp:ListItem Value="1">yes</asp:ListItem>
                     </asp:DropDownList>
                <br />
                   
                     <br />

                         <!--<h6>Family_Issues: 0- No , 1 - Yes</h6>-->
                </div>

                 <div class="form-group">
                  <p><b>Study_Hours</b></p>
                     <asp:DropDownList ID="DropDownList4" runat="server" Height="30px" Width="100px">
                         <asp:ListItem Value="1">1</asp:ListItem>
                         <asp:ListItem Value="2">2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         <asp:ListItem>&gt;4</asp:ListItem>
                     </asp:DropDownList>
                <br />
                   
                     <br />
                         <h6>Study_Hours: Numeric 1,2,3 ....</h6>
                </div>

                 <div class="form-group">
                  <p><b>Teaching_Method</b></p>
                  <ol>
                  <li>Not able to comprehend teaching at college</li>
                  <li>Doubts not clarified</li>
                  <li>Lack of apt study material etc.</li>
                  </ol>
                  <br />
                     <asp:DropDownList ID="DropDownList5" runat="server" Height="30px" Width="100px">
                         <asp:ListItem Value="1">fair</asp:ListItem>
                         <asp:ListItem Value="2">not good</asp:ListItem>
                     </asp:DropDownList>
                     <br />
                <br />
                   
                        <!--<h6>Teaching_Method: 1- Fair / 2- Not Good.</h6>-->
                </div>

                 <div class="form-group">
                  <p><b>Health_Issues</b></p>
                     <ol>
                         <li>Insomnia</li>
                         <li>Acidity</li>
                         <li>Migraines</li>
                         <li>Feeling weak and malnurished or having any other heatlth issues.</li>
                     </ol>
                     <br />
                     <asp:DropDownList ID="DropDownList6" runat="server" Height="30px" Width="100px">
                         <asp:ListItem Value="1">no</asp:ListItem>
                         <asp:ListItem Value="2">yes</asp:ListItem>
                     </asp:DropDownList>
                     <br />
                <br />
                   
                        <!--<h6>Health_Issues: 1- No , 2 - Yes</h6>-->
                </div>

                 <div class="form-group">
                  <p><b>Partiality_Fix</b></p>
                     <ol>
                         <li>Recieving very minimal attention at home or college compared to others</li>
                         <li>Facing comparisons</li>
                         <li>Low self esteem etc.</li>
                     </ol>
                     <br />
                     <asp:DropDownList ID="DropDownList7" runat="server" Height="30px" Width="100px">
                         <asp:ListItem Value="0">no</asp:ListItem>
                         <asp:ListItem Value="1">yes</asp:ListItem>
                     </asp:DropDownList>
                     <br />
                 <br />

                        <!--<h6>Partiality_Fix: 0- No , 1 - Yes</h6>-->
                </div>

                <div class="form-group">
                  <p><b>Exam_Schedule</b></p>
                    <asp:DropDownList ID="DropDownList8" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="1">Monthly</asp:ListItem>
                        <asp:ListItem Value="2">Quaterly</asp:ListItem>
                        <asp:ListItem Value="3">Half</asp:ListItem>
                        <asp:ListItem Value="4">Annual</asp:ListItem>
                         <asp:ListItem Value="5">Slip Test</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                 <br />

                        <!--<h6>Exam_Schedule: 1-Monthly/ 2-Half/ 3-yearly/ 4-Annual/ 5-Slip Test/</h6>-->
                </div>

                <div class="form-group">
                  <p><b>Friends_Issue</b></p>
                    <ol>
                        <li>Misunderstandings between friends</li>
                        <li>Feeling left out</li>
                        <li>Facing betrayals</li>
                        <li>Lack of trust</li>
                        <li>Being used or feeling envious of the other etc</li>
                    </ol>
                    <br />
                    <asp:DropDownList ID="DropDownList9" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="0">no</asp:ListItem>
                        <asp:ListItem Value="1">yes</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                 <br />

                        <!--<h6>Friends_Issue: 0- No , 1 - Yes</h6>-->
                </div>

                <div class="form-group">
                  <p><b>Pressure due to Covid</b></p>
                    <ol>
                        <li>Mental disparity and anxiety because of covid</li>
                        <li>Students and their close ones getting infected by covid</li>
                        <li>No enough infrastructure for Online Classes in Pandamic</li>
                    </ol>
                    <br />
                    <asp:DropDownList ID="DropDownList10" runat="server" Height="30px" 
                        Width="100px">
                        <asp:ListItem Value="0">no</asp:ListItem>
                        <asp:ListItem Value="1">yes</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                 <br />
                        <!--<h6>Pressure: 0- No , 1 - Yes</h6>-->
                </div>

                <div class="form-group">
                  <p><b>Regular</b></p>
                    <ol>
                        <li>Hostler</li>
                        <ol>
                            <li>Home Sick</li>
                            <li>Lack of nutritious food</li>
                            <li>Lack of Resources</li>
                        </ol>
                                
                        <li>Localite</li>
                        <ol>
                            <li>Time management</li>
                            <li>Transportation Problem</li>
                        </ol>    
                    </ol>
                  <asp:DropDownList ID="DropDownList11" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="1">no</asp:ListItem>
                        <asp:ListItem Value="2">yes</asp:ListItem>
                    </asp:DropDownList>
                     <br />
                 <br />
                         <!--<h6>Regular: 1- No , 2 - Yes</h6>-->
                </div>

                <div class="form-group">
                  <p><b>Interaction</b></p>
                 <asp:DropDownList ID="DropDownList12" runat="server" Height="30px" Width="100px">
                        <asp:ListItem Value="1">Excellent</asp:ListItem>
                        <asp:ListItem Value="2">Good</asp:ListItem>
                         <asp:ListItem Value="3">Average</asp:ListItem>
                          <asp:ListItem Value="4">Poor</asp:ListItem>
                    </asp:DropDownList>
                 <br />
                    <br />
                         <!-- <h6>Interaction: 1- Excellent , 2 - Good, 3 - Average, 4 - Poor</h6>-->
                </div>

     <div>           
               <br />
         <asp:Button ID="btnSubmit" runat="server" BorderStyle="None" Height="34px" 
             onclick="btnSubmit_Click" Text="Predict Stress Level" ValidationGroup="a" />
         <br />
         <asp:Label ID="lblResult" runat="server"></asp:Label>
               </div>
             


            </div>
          </div>
        </div>
        <!-- End col-->
      </div>
    </div>
    </div>
  <!-- End Contact Area -->


    </asp:Panel>



</asp:Content>
