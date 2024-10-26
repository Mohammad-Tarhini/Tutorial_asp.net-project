<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sendData.aspx.cs" Inherits="WebApplication11.sendData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="session" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="query" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="cookie" OnClick="Button3_Click" />
</asp:Content>
