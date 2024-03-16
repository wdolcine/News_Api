<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All_News.aspx.cs" Inherits="Devoir_final_Arthur.All_News" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .bg-whitesmoke {
            background-color: #DBB3B3;
        }

        .auto-style1 {
            margin-left: 280px;
        }
    </style>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-whitesmoke">
            <div class="container">
                <a class="navbar-brand text-info" href="#">All News </a>
                <%--<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>--%>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ml-auto">
                        <%--  <li class="nav-item">
          <a class="nav-link text-info" href="#">Accueil</a>
        </li>--%>
                        <%-- <li class="nav-item">
          <a class="nav-link text-info" href="#">À propos</a>
        </li> --%>
                    </ul>
                </div>
            </div>
        </nav>
        

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"></script>

        <div class="row row-cols-1 row-cols-md-3 g-4">
            <div class="col">
                <div class="card h-100" style="background-color: azure; border: 5px solid #DBB3B3">
                    <div class="card text-bg-secondary mb-3" style="max-width: 18rem;"></div>
                    <asp:ImageButton ID="image0" class="card-img-top img-responsive" alt="..." runat="server" OnClick="image0_Click" />
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="lbltitle0" runat="server" Text="Title"></asp:Label>
                        </h5>
                        <p class="card-text">
                            <asp:Label ID="lblAuthor0" runat="server" Text="Author"></asp:Label>
                        </p>
                        <p class="card-text">
                            <asp:Label ID="lblDate0" runat="server" Text="Date Released"></asp:Label>
                        </p>

                    </div>

                </div>
            </div>
            <div class="col">
                <div class="card h-100" style="background-color: azure; border: 5px solid #DBB3B3">
                    <div class="card text-bg-secondary mb-3" style="max-width: 18rem;"></div>
                    <asp:ImageButton ID="image1" class="card-img-top img-responsive" alt="..." runat="server" OnClick="image1_Click" />
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="lbltitle1" runat="server" Text="Title :"></asp:Label>
                        </h5>
                        <p class="card-text">
                            <asp:Label ID="lblAuthor1" runat="server" Text="Author :"></asp:Label>
                        </p>
                        <p class="card-text">
                            <asp:Label ID="lblDate1" runat="server" Text="Date Released :"></asp:Label>
                        </p>
                    </div>

                </div>
            </div>
            <div class="col">
                <div class="card h-100" style="background-color: azure; border: 5px solid #DBB3B3">
                    <div class="card text-bg-secondary mb-3" style="max-width: 18rem;"></div>
                    <asp:ImageButton ID="image2" class="card-img-top img-responsive" alt="..." runat="server" OnClick="image2_Click" />
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="lbltitle2" runat="server" Text="Title"></asp:Label>
                        </h5>
                        <p class="card-text">
                            <asp:Label ID="lblAuthor2" runat="server" Text="Author"></asp:Label>
                        </p>
                        <p class="card-text">
                            <asp:Label ID="lblDate2" runat="server" Text="Date Released"></asp:Label>
                        </p>

                    </div>

                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />




        <div class="auto-style1">
            <asp:Button ID="btnfirst" runat="server" BackColor="DimGray" Text="First" CssClass="btn btn-secondary" align="left" Height="40px" Width="197px" OnClick="btnfirst_Click" />

            <asp:Button ID="BtnPrev" runat="server" BackColor="DimGray" Text="Previous" align="left" CssClass="btn btn-secondary" Height="40px" Width="181px" OnClick="BtnPrev_Click1" />

            <asp:Button ID="BtnNext" runat="server" BackColor="DimGray" Text="Next" CssClass="btn btn-secondary" align="right" Height="40px" Width="153px" OnClick="BtnNext_Click1" Style="margin-left: 21px" />

            <asp:Button ID="btnlast" runat="server" BackColor="DimGray" Text="Last"  CssClass="btn btn-secondary" Height="40px" Width="203px" Style="margin-left: 5px" OnClick="btnlast_Click" />

        </div>
        <div>
        </div>
    </form>




</body>
</html>
