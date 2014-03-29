<%@ Page Language="C#" AutoEventWireup="false" EnableEventValidation="false" Inherits="insitu.web.code.Default" %>

<!DOCTYPE html>
<html lang="en"> 
<head id="Head1" runat="server">
    <title>BIENVENIDO A INSITU :: CHILE - ARGENTINA</title>
    <meta name="viewport" content="width=device-width,initial-scale=1,user-scalable=no" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <meta name="apple-mobile-web-app-status-bar-style" content="black" />
    <!-- Link Collection -->
    <link rel="stylesheet" type="text/css" href="css/style-login.css" />
    <!-- JQuery Collection -->
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

    <style>
        .icon-wrap {
    text-align: center;
    margin: 0 auto;
    padding: 2em 0 3em;
}

.icon {
    display: inline-block;
    font-size: 0px;
    cursor: pointer;
    margin: 15px 30px;
    width: 400px;
    height: 400px;
    border-radius: 50%;
    text-align: center;
    position: relative;
    z-index: 10;
    color: #fff;
}

.icon:after {
    pointer-events: none;
    position: absolute;
    width: 100%;
    height: 100%;
    border-radius: 50%;
    -webkit-box-sizing: content-box;
    -moz-box-sizing: content-box;
    box-sizing: content-box;
}

.icon:before {
    background-color: #ccc;
}

/* Sonar Effect */
.icon-effect .icon {
    background: rgba(255, 255, 255, 0.1);
    -webkit-transition: -webkit-transform ease-out 0.1s, background .5s;
    -moz-transition: -moz-transform ease-out 0.1s, background .5s;
    transition: transform ease-out 0.1s, background .5s;
}

.icon-effect .icon:after {
    top: 0;
    left: 0;
    padding: 0;
    z-index: -1;
    box-shadow: 0 0 0 2px rgba(255, 255, 255, 0.1);
    opacity: 0;
    -webkit-transform: scale(0.9);
    -moz-transform: scale(0.9);
    -ms-transform: scale(0.9);
    transform: scale(0.9);
}


.icon-effect .icon:hover {
	background: rgba(255,255,255,0.05);
	-webkit-transform: scale(0.93);
	-moz-transform: scale(0.93);
	-ms-transform: scale(0.93);
	transform: scale(0.93);
	color: #fff;
}

.icon-effect .icon:hover {
    -webkit-animation: sonarEffect 1.3s ease-out 75ms;
    -moz-animation: sonarEffect 1.3s ease-out 75ms;
    animation: sonarEffect 1.3s ease-out 75ms;
}


/* Chrome, mobile browser support  */
@-webkit-keyframes sonarEffect {
    0% {
        opacity: 0.3;
    }
    40% {
        opacity: 0.5;
        
    }
    100% {
        
        -webkit-transform: scale(1.5);
        opacity: 0;
    }
}

/* Mozilla browser support*/
@-moz-keyframes sonarEffect {
    0% {
        opacity: 0.3;
    }
    40% {
        opacity: 0.5;
        
    }
    100% {
 
        -moz-transform: scale(1.5);
        opacity: 0;
    }
}


@keyframes sonarEffect {
    0% {
        opacity: 0.3;
    }
    40% {
        opacity: 0.5;
        
    }
    100% {
      
        transform: scale(1.5);
        opacity: 0;
    }
}
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
            <ContentTemplate>
                <center>
                    <br />
                    <br />
                    <br />
                     <div class="icon-wrap icon-effect">
            <div class="icon"><img src="images/iso.png"/></div>
        </div>
                    </center>
                <!-- Table for the main background-->
            </ContentTemplate>
            <Triggers>
            </Triggers>
        </asp:UpdatePanel>
    </form>
     
</body>
</html>


