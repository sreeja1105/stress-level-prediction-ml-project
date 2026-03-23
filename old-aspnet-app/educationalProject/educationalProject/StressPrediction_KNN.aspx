<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="StressPrediction_KNN.aspx.cs" Inherits="educationalProject.StressPrediction_KNN" %>
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
          <h2 class="sec-head">Student Stress Prediction</h2>            
          </div>
        </div>
      </div>
      <div class="row">
       


       <br />
 <div style="height:250px; width:auto; overflow:auto">

 <h3>Testing Dataset</h3>

<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
         BorderColor="#DEBA84" BorderWidth="1px" CellPadding="3" BorderStyle="None" 
         CellSpacing="2">

    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" 
        HorizontalAlign="Center" />
    <RowStyle ForeColor="#8C4510" BackColor="#FFF7E7" />
    <SelectedRowStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />

</asp:GridView>
</div>
          <br />

           <h2><span>STRESS </span> PREDICTION USING KNN!!!</h2>
          <hr />

          <br />
          <asp:Button ID="btnPrediction" runat="server" 
                      Text="Predict Output" 
              onclick="btnPrediction_Click" CssClass="btn" Height="50px" Width="150px" /> &nbsp;&nbsp;&nbsp;


                 <asp:Button ID="btnLevels" runat="server" 
                      Text="Stress Level" 
             CssClass="btn" Height="50px" Width="150px" onclick="btnLevels_Click" /> &nbsp;&nbsp;&nbsp;


          <asp:Button ID="btnResults" runat="server" CssClass="btn" 
              onclick="btnResults_Click" Text="Result Analysis" Height="50px" 
              Width="150px" />

              &nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnGraph" runat="server" CssClass="btn" 
              onclick="btnGraph_Click" Text="Data Visualization" Height="50px" 
              Width="150px" />
          <br />
          <br />
          <h4>Predict Output: Two way Classification '0' - Stress Free '1' - Stressed</h4>
          <h4>Stress Level: '0' - Normal, '1' - 25% Stress Level, '2' - 50% Stress level, '3' - 100% Stress Level</h4>

          <br /><br /><div>
              <table style="width:100%;">
                  <tr>
                      <td>
                          <asp:Table ID="Table1" runat="server">
                          </asp:Table>
                      </td>
                      <td>
                          <asp:Table ID="tablePrediction" runat="server">
                          </asp:Table>
                      </td>
                      <td>
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                  </tr>
              </table>
              <br />
      </div>
          <br />
        

     

        <!-- End col-->
      </div>
    </div>
    </div>
  <!-- End Contact Area -->


    </asp:Panel>

</asp:Content>
