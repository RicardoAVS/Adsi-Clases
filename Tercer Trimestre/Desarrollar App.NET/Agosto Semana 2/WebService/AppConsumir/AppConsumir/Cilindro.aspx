<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cilindro.aspx.cs" Inherits="AppConsumir.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <h2> Caculo del volumen de un Cilindro.</h2>

     <table style="width: 100%; height: 263px">
    <tr>
        <td class="modal-sm" style="width: 219px">RADIO</td>
        <td>
            <asp:TextBox ID="txtRadio" runat="server" Height="22px"></asp:TextBox>
        &nbsp;&nbsp; metros</td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 219px">ALTURA</td>
        <td>
            <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
        &nbsp; metros</td>
    </tr>
    <tr>
        <td class="modal-sm" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="CALCULAR" />
        </td>
    </tr>
    <tr>
        <td class="modal-sm" style="width: 219px">VOLUMEN DEL CILINDRO</td>
        <td>
            <asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;metros<span style="font-size: x-small">3</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelMsg" runat="server" Visible="False"></asp:Label>
        </td>
    </tr>
</table>

                <div style="height: 113px">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" runat="server" Height="180px" ImageUrl="https://quimicayalgomas.com/wp-content/uploads/2019/01/Volumen-cilindro.jpg" Width="245px" style="margin-left: 0px; margin-top: 13px" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    </div>
</asp:Content>
