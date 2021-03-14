<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SalesTaxesSol._Default" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <div class="form-horizontal">
        <div class="form-group padding">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblItem" runat="server" Text="Item"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblQty" class="col-2" runat="server" Text="Qty"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:TextBox ID="txtItem1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtQty1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPrice1" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd1" runat="server" OnClick="btnAdd1_Click" Text="Add" CssClass="btn btn-primary" />
            <asp:Button ID="btnClear1" runat="server" Text="Clear" OnClick="btnClear1_Click" CssClass="btn btn-primary" Height="34px" />
        </div>
    </div>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:TextBox ID="txtItem2" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtQty2" runat="server" Style="margin-bottom: 7"></asp:TextBox>
            <asp:TextBox ID="txtPrice2" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd2" runat="server" Text="Add" OnClick="btnAdd2_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnClear2" runat="server" Text="Clear" OnClick="btnClear2_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnRemove2" runat="server" Text="Remove" OnClick="btnRemove2_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:TextBox ID="txtItem3" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtQty3" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPrice3" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd3" runat="server" Text="Add" OnClick="btnAdd3_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnClear3" runat="server" Text="Clear" OnClick="btnClear3_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnRemove3" runat="server" Text="Remove" OnClick="btnRemove3_Click" CssClass="btn btn-primary" />

        </div>
    </div>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:TextBox ID="txtItem4" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtQty4" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPrice4" runat="server"></asp:TextBox>
            <asp:Button ID="btnClear4" runat="server" Text="Clear" OnClick="btnClear4_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnRemove4" runat="server" Text="Remove" OnClick="btnRemove4_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Submit_Click" CssClass="btn btn-primary" />
    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="Clear_Click" CssClass="btn btn-primary" />
    <br />
    <br />

    <table class="nav-justified">
        <tr>
            <td style="height: 20px">
                <asp:Label ID="lblItem1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblItem2" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblItem3" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblItem4" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSalesTax" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>

    <br />
</asp:Content>

