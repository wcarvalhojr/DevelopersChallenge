<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TorneioMataMata._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <h2>
                <asp:Label ID="lblMensagem" runat="server" Text="" BackColor="Red"></asp:Label><br />
                <asp:Label ID="lblTitulo" runat="server"></asp:Label>
            </h2>
            <p>
                <asp:Repeater ID="rpt" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4">
                            <asp:RadioButton ID="rbtA" runat="server" Checked='<%#Eval("checkA")%>' GroupName="time" />
                            <asp:Label ID="lblTimeA" runat="server" Text='<%#Eval("grupoA")%>'></asp:Label>
                        </div>
                        <div class="col-md-2">X</div>
                        <div class="col-md-4">
                            <asp:RadioButton ID="rbtB" runat="server" Checked='<%#Eval("checkB")%>' GroupName="time" />
                            <asp:Label ID="lblTimeB" runat="server" Text='<%#Eval("grupoB")%>'></asp:Label>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </p>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-12">
            <p>
                <asp:Button ID="btnInicio" runat="server" Text="Início" class="btn btn-default"  PostBackUrl="~/Default.aspx" />                
                <asp:Button ID="btnSalvar" runat="server" Text="Avançar" class="btn btn-default"  OnClick="btnAvancar_Click" />                
            </p>
        </div>
    </div>

</asp:Content>
