<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication11.WebUserControl1" %>
<p>name:</p>
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" ValidationGroup="no"></asp:TextBox><asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox1" ErrorMessage="enter name" ValidationGroup="ok"></asp:RequiredFieldValidator>
<p>passward:</p>
<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ValidationGroup="ok"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="enter passward" ControlToValidate="TextBox2" ValidationGroup="ok"></asp:RequiredFieldValidator>
<p>passward confirm:</p>
<asp:TextBox ID="TextBox3" runat="server" ValidationGroup="ok"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox3" ControlToCompare="TextBox2"></asp:CompareValidator>
<p>address</p>
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<p> phone number</p>
<asp:TextBox ID="TextBox5" runat="server" ValidationGroup="ok"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="join" OnClick="Button1_Click" ValidationGroup="ok" />
<asp:Button ID="Button2" runat="server" Text="cancel" OnClick="Button2_Click" />
<asp:Button ID="Button3" runat="server" Text="Button" ValidationGroup="no" />