<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication11.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>id </p>
    <asp:TextBox ID="TextBox0" runat="server" OnTextChanged="TextBox0_TextChanged"></asp:TextBox>
    <p>name</p>
    <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="s" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
   <p>pasward</p>
    <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="s" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="join" ValidationGroup="s" OnClick="Button1_Click" />
</asp:Content>
