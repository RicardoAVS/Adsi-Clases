<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resta.aspx.cs" Inherits="AppConsumir.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2> Caculo de la Resta de dos numeros    .</h2>

     <table style="width: 100%; height: 263px">
    <tr>
        <td class="modal-sm" style="width: 219px">PRIMER NUMERO</td>
        <td>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 219px">SEGUNDO NUMERO</td>
        <td>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="modal-sm" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="CALCULAR" />
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 219px">RESTA</td>
        <td>
            <asp:TextBox ID="txtResta" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelMsg" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
