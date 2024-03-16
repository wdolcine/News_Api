<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New_Clicked.aspx.cs" Inherits="Devoir_final_Arthur.New_Clicked" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <title></title>
<style>
    .left-align{
        align-content:initial;
    }
</style>
</head>
<body>
    <div class="col">
    <div class="card h-100" style="background-color:azure; border: 5px solid #DBB3B3">
      <div class="card text-bg-secondary mb-3" style="max-width: 18rem;"></div>
       <asp:Image ID="image1" class="card-img-top img-responsive" alt="..." runat="server" width="900" Height="600"  />
      <div class="card-body">
      <h5 class="card-title"> 
            <asp:Label ID="Label1Titre" runat="server" Text="Title :"></asp:Label>
             <asp:Label ID="Label5" runat="server" Text="Title"></asp:Label>

        </h5>
          <p class="card-text">            
             <asp:Label ID="Label2Auteur" runat="server" Text="Author :"></asp:Label>
              <asp:Label ID="Label6" runat="server" Text="Author"></asp:Label>

        </p>
        <p class="card-text">            
             <asp:Label ID="Label3Date" runat="server" Text="Date Released :"></asp:Label>
              <asp:Label ID="Label7" runat="server" Text="Date Released"></asp:Label>

        </p>
            <p class="card-text">            
             <asp:Label ID="Label1Content" runat="server" Text="Content :"></asp:Label>
             <asp:Label ID="Label8" runat="server" Text="Content"></asp:Label>

        </p>
        <%--  <p class="card-text">            
             <asp:Label ID="Label1Desc" runat="server" Text="Content :"></asp:Label>
             <asp:Label ID="Label2" runat="server" Text="Content"></asp:Label>

        </p>--%>
      </div>
    </div>
  </div>
  
    <br />
    <br />
        <br />
    <br />


    <form id="form1" runat="server">
    <br />


        <div>
            <div class="col">
            
        </div>           
            </div>
   
    <style>
        .auto-style1 {
            margin-left: 400px;
            width: 616px;
        }
    </style>
           <div align="center" class="auto-style1">
               <asp:Button  ID="btnAllNews" runat="server" BackColor="DimGray" Text="All News"  CssClass="btn btn-secondary" align="center" Height="36px" Width="193px" OnClick="btnAllNews_Click"  />
           </div>
            
    </form>
   
    </body>
</html>
