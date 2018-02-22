<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
    <link href="assets/css/style-responsive.css" rel="stylesheet" />

    <title>Time zone API</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container" style="padding-top:110px">
            <div class="row">
                <div class=" col-lg-offset-2 col-lg-8">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Timezone list
                        </div>

                        <div class="panel-body">
                            <asp:Label Text="NOTE: For sample it work on ten countries. Leave Textbox empty to see the full list" runat="server" />
                            <br />
                            <asp:TextBox ID="txtId" CssClass="form-control" placeholder="Enter Country e.g: Turkey" runat="server" />
                            <br />
                            <asp:Button ID="btnGetApiData" CssClass="btn btn-info" Text="Get data" runat="server" OnClick="btnGetApiData_Click" />
                            <br />
                            <br /> 
                            <asp:GridView ID="grid" CssClass="table table-responsive table-striped table-hover" runat="server"></asp:GridView>
                        </div>

                    </div>
                </div>

            </div>

        </div>
    </form>
</body>
</html>
