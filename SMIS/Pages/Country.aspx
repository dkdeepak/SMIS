<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MenuMaster.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="SMIS.Pages.Country" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContain" runat="server">
   <script src="../Script/jquery-latest.js"></script>
    <script src="../Script/jquery.tablesorter.js"></script>
    <script type="text/javascript">
        var $js = $.noConflict(true);
            $js(document).ready(function () {
                $js('#cphContain_dgvCountry').tablesorter();

            });
    </script>
    <div class="panel panel-primary col-lg-10 col-lg-offset-1">
    <div class="panel-heading">Manage Data</div>
    <div class="panel-body">
    <asp:UpdatePanel ID="updateCountry" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Enter Text to Search" Width="20%" onkeyup="Search_Gridview(this, 'cphContain_dgvCountry')"></asp:TextBox>
        <asp:GridView ID="dgvCountry" runat="server" CssClass="tablesorter" AutoGenerateColumns="false" Width="100%"  OnRowDataBound="dgvCountry_RowDataBound"
            DataKeyNames="CountryID">
            
            <Columns>
                <asp:BoundField HeaderText="Country Name" DataField="CountryName" ItemStyle-CssClass="text_title" HeaderStyle-CssClass="grid-header" ItemStyle-Width="25%" />
                <asp:BoundField HeaderText="Created Date" DataField="CreatedOn" ItemStyle-CssClass="text_title" HeaderStyle-CssClass="grid-header" DataFormatString="{0:dd-MMM-yyyy}" ItemStyle-Width="25%" />
                <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid-header" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtn" ImageUrl="~/Images/edit.png" runat="server" CssClass="grid-botton" OnClick="imgbtn_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid-header" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtnfrDelete" OnClientClick="if (!confirm('Are you sure you want delete?')) return false;"
                             ImageUrl="~/Images/delete.png" runat="server" CssClass="grid-botton" OnClick="imgbtnfrDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
        </div>
</asp:Content>
