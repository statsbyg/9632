<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="topmenu" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LeftPane" Runat="Server">
    <asp:DataGrid 
    ID="dgQuick" 
   runat="server" 
   BackColor="#00EAB2" 
   BorderWidth="2px" 
   AutoGenerateColumns="False" Width="100%" 
   ShowFooter="True" AllowPaging="True" PageSize="20" AllowCustompaging="true" OnPageIndexChanged="dgQuick_PageIndexChanged"
   PagerStyle-PageButtonCount="5"
   PagerStyle-Mode="NumericPages" 
   PagerStyle-Visible="true">
   <Columns>
                <asp:BoundColumn HeaderText="Species Name" DataField="SpeciesName"></asp:BoundColumn>
              
     </Columns>        
 </asp:DataGrid>
 <asp:TextBox ID="txtNewPageNumber" runat="server" Width="40"></asp:TextBox>
 <asp:Button ID="btnDisplayPage" runat="server" Text="Update" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="RightPane" Runat="Server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

