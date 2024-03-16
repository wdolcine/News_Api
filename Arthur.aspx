<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Arthur.aspx.cs" Inherits="Devoir_final_Arthur.Arthur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>

    <link rel="stylesheet" type="text/css" href="style.css" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    
   
</head>
<body>
    <style>
       
        .auto-style1 {
            background-color:#DBB3B3;
            display: block;
            max-width: 100%;
            height: auto;
            width: 480px;
        }
        .auto-style2 {
             background-color:#DBB3B3;
            margin-left: 940px;
        }
        .auto-style4 {
            margin-left: 80px;
            background-color:#DBB3B3;

        }
        .auto-style5 {
            margin-left: 40px;

        }
        .progress-bar{
            background-color:#DBB3B3;
        }
    </style>
    <div align="center">
        <img src="image/images.jpg" class="auto-style1" /><br />
        <br />
&nbsp;</div>
       <div class="auto-style4">
           
    </div>

  
           <div class="progress" role="progressbar" readonly="true" id="progress-bar" aria-valuemin ="0" aria-valuemax="100">
  <div class="progress-bar" role="progressbar" aria-valuenow="0" ></div>
</div>
    <script>
        var progressbar = document.querySelector('.progress-bar');
        var width = 0;

        function incrementProgressBar() {
            width += 10;
            progressbar.style.width = width + '%';
            progressbar.textContent = width + '%';
            progressbar.setAttribute('aria-valuenow', width);

            if (width >= 100) {
                clearInterval(interval);
                window.location.replace('All_News.aspx');
            }
        }
        var interval = setInterval(incrementProgressBar, 2000);
    </script>

  
   
    <form id="form1" runat="server">

        <div class="auto-style5">
        </div>

        <div class="auto-style5">
            <asp:Panel ID="Panel1" runat="server" Height="20px" Width="40px">
            </asp:Panel>
        </div>
      
    </form>
</body>
</html>
