A<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="StudentGraph.aspx.cs" Inherits="educationalProject.StudentGraph" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <div id="about" class="about-area area-padding">
   <div class="container">
      <div class="row">
        <div class="col-md-12 col-sm-12 col-xs-12">
          <div class="section-headline text-center">
            <h2>Data Visualization</h2>
          </div>
        </div>
      </div>
      <div class="row">

                            <div>
						   		<span>
                                       <asp:Table ID="tableCompare" runat="server">
                                       </asp:Table>  </span>
						  </div>

  				<div class="clear"> </div>		


                 <asp:Panel ID="panelUpdatePassword" runat="server">

  <div class="article">
          <h2><span>Graph</span> Representation</h2>
          <hr />
    
    		<br />
<div style="float:left;width:340px;">
			<div class="box">
				<div class="registration_left">
   <%-- <a href="#"><div class="reg_fb"><i>Select Chart Type</i><div class="clear"></div></div></a>--%>
		 <div class="registration_form">
				<p>
					<asp:DropDownList ID="ddlChartType" runat="server" AutoPostBack="False" 
                        Visible="False">
					</asp:DropDownList>
				</p>
			</div>

			<div class="box">
				<p>
					<asp:RadioButtonList ID="rblValueCount" runat="server" AutoPostBack="False" Visible="False" 
                        >
						<asp:ListItem Value="10">10 Values</asp:ListItem>
						<asp:ListItem Value="20">20 Values</asp:ListItem>
						<asp:ListItem Value="50">50 Values</asp:ListItem>
						<asp:ListItem Value="100">100 Values</asp:ListItem>
						<asp:ListItem Value="500" Selected="True">500 Values</asp:ListItem>
					</asp:RadioButtonList>
				</p>O
			</div>
		</div>

		<div class="box">
			<p>
				<asp:CheckBox ID="cbUse3D" runat="server" AutoPostBack="False" 
                    Text="Use 3D Chart" Visible="False" />
			</p>
			<p>
				<asp:RadioButtonList ID="rblInclinationAngle" runat="server" 
                    AutoPostBack="False" Visible="False">
					<asp:ListItem Value="-90">-90°</asp:ListItem>
					<asp:ListItem Value="-50">-50°</asp:ListItem>
					<asp:ListItem Value="-20">-20°</asp:ListItem>
					<asp:ListItem Value="0">0°</asp:ListItem>
					<asp:ListItem Selected="True" Value="20">20°</asp:ListItem>
					<asp:ListItem Value="50">50°</asp:ListItem>
					<asp:ListItem Value="90">90°</asp:ListItem>
				</asp:RadioButtonList>
			</p>
		</div>
		

	</div>

  <div>
      <table style="width: 100%;">
          <tr>
              <td>
                  &nbsp;<asp:Button ID="btnShow" runat="server" onclick="btnShow_Click" Text="Show" 
                      ValidationGroup="a" Width="125px" Visible="False" />
                  &nbsp;</td>
          </tr>
          </table>
  
  </div>
		
      
    </div>
          <br />
          <div class="clear">
              <table style="width:100%;">
                  <tr>
                      <td>
                          <h4>
                              Outcome: 0 - Normal, 1 - 25% Stress Level,
                              <br />
                              2 - 50% Stress level, 3 - 100% Stress Level</h4>
                      </td>
                      <td>
                          &nbsp;</td>
                      <td>
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td>
                          <asp:Label ID="lblResult" runat="server"></asp:Label>
                      </td>
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
                  <tr>
                      <td>
                          <asp:Button ID="btnLevels" runat="server" CssClass="btn" Height="50px" 
                              onclick="btnLevels_Click" Text="Stress Level" Visible="False" Width="150px" />
                      </td>
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
                  <tr>
                      <td>
                          <asp:Chart ID="cTestChart" runat="server" Height="400px" Visible="False" 
                              Width="600px">
                              <Series>
                                  <asp:Series Name="Testing">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <Area3DStyle />
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </td>
                      <td>
                          <asp:Image ID="Image1" runat="server" ImageUrl="~/img/stressfree.jpg" 
                              Visible="False" Width="600px" />
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
              </table>
          </div>

          <br />
          <br />

        <br />

        </div>
        </asp:Panel>

        <br />


    <br />
    </div>
    </div>
    </div>
    </asp:Panel>


</asp:Content>
