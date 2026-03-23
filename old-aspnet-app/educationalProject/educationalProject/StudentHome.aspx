<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="educationalProject.StudentHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">

    var image1 = new Image()
    image1.src = "../img/slider/ed10.jpeg"
    var image2 = new Image()
    image2.src = "../img/slider/ed8.JPG"
    var image3 = new Image()
    image3.src = "../img/slider/ed11.jpeg"
    var image4 = new Image()
    image4.src = "../img/slider/ed4.jpg"
                      
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
    <!-- Start contact Area -->  
    <div id="about" class="about-area area-padding">
   <div class="container">
      <div class="row">
        <div class="col-md-12 col-sm-12 col-xs-12">
          <div class="section-headline text-center">
            <h2>Student Home Page</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <!-- single-well start-->
         <div id="Div1">
                <img src="../img/slider/ed10.JPG" width="1080px" height="320px" name="slide" />
                <script type="text/javascript">
            <!--
                    var step = 1
                    function slideit() {
                        document.images.slide.src = eval("image" + step + ".src")
                        if (step < 4)
                            step++
                        else
                            step = 1
                        setTimeout("slideit()", 2500)
                    }
                    slideit()
            //-->
                </script>
            </div>
     
      </div>
    
  <!-- End Contact Area -->
  <br />
   <div class="row">
    <h3>Stress</h3>
        <p>Stress can be defined as any type of change that causes physical, emotional, or psychological strain. Stress is your body's response to anything that requires attention or action. 
        </p>
        <p>Some common signs of stress include:﻿

            <ol>
                <li>Changes in mood</li>
                <li>Clammy or sweaty palms</li>
                <li>Diarrhea</li>
                <li>Difficulty sleeping</li>
                <li>Digestive problems</li>
                <li>Dizziness</li>
                <li>Feeling anxious</li>
                <li>Frequent sickness</li>
                <li>Grinding teeth</li>
                <li>Headaches</li>
                <li>Low energy</li>
                <li>Muscle tension, especially in the neck and shoulders</li>
                <li>Physical aches and pains</li>
                <li>Racing heartbeat</li>
                <li>Trembling</li>
            </ol>
        </p>
        </div>
       </div>
    </div> 
    </asp:Panel>
</asp:Content>
