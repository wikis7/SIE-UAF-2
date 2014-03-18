<%@ Page Title="Carreras" Language="C#" MasterPageFile="~/ServEsc/ServEsc.Master" AutoEventWireup="true" CodeBehind="Carreras.aspx.cs" Inherits="SIE_UAF_2.ServEsc.Carreras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        Seleccione una Opción: 
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="descripcion" DataValueField="id_nivel" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:uafedu_sie_uafConnectionString %>" ProviderName="<%$ ConnectionStrings:uafedu_sie_uafConnectionString.ProviderName %>" SelectCommand="SELECT * FROM niveles order by id_nivel"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Button ID="Button1" runat="server" Height="30px" Text="Nueva Carrera" Width="113px" OnClick="Button1_Click" />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" CellPadding="4" DataSourceID="SqlDataSource2" Width="100%" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:uafedu_sie_uafConnectionString %>" ProviderName="<%$ ConnectionStrings:uafedu_sie_uafConnectionString.ProviderName %>" SelectCommand="carreras2" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="Label1" Name="id" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <div class="jumbotron">
        <h3>
         <asp:Label ID="Label11" runat="server" Text="Modificación de Datos de Carrera"></asp:Label>
        </h3>
        <br />
                    <asp:Label ID="Label12" runat="server" Text="Seleccione Nivel: " ForeColor="Black" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="descripcion" DataValueField="id_nivel" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Visible="False">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:uafedu_sie_uafConnectionString %>" ProviderName="<%$ ConnectionStrings:uafedu_sie_uafConnectionString.ProviderName %>" SelectCommand="SELECT * FROM niveles ORDER BY id_nivel"></asp:SqlDataSource>
                    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
&nbsp;
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                    &nbsp;<asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Clave: " ForeColor="Black"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" 
                Width="41px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" ForeColor="Black" Text="Descripción: "></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" ForeColor="Black" Text="Abreviatura:"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Height="21px" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" ForeColor="Black" Text="Modelo: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="Reforma: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" ForeColor="Black" Text="Revición: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Height="21px" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" ForeColor="Black" Text="Nivel: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox7" runat="server" Height="21px" Width="300px"></asp:TextBox>
                <br />
                <br />
        <asp:Button ID="Button2" runat="server" Height="36px" OnClick="Button2_Click" Text="Guardar" Width="101px" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Height="36px" OnClick="Button3_Click" Text="Eliminar" Width="101px" />
&nbsp;
        <asp:Button ID="Button4" runat="server" Height="36px" OnClick="Button4_Click" Text="Cancelar" Width="101px" />
    </div>
    
</asp:Content>
