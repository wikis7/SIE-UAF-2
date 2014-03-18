using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using MySql.Data;//conector v 6.8.3
using MySql.Data.MySqlClient;//conector v 6.8.3

namespace SIE_UAF_2.ServEsc
{
    public partial class Carreras : System.Web.UI.Page
    {
        MySqlCommand comando, comando2, comando3, comando4;
        MySqlConnection con;
        String sentenciaSQL, sentenciaSQL2, sentenciaSQL3, sentenciaSQL4;
        string strcon = "server=localhost;user id=root;database=uafedu_sie_uaf;persistsecurityinfo=True;password=pepe;allowuservariables=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = DropDownList1.SelectedValue.ToString();
                if (Label1.Text == "1" || Label1.Text == "2" || Label1.Text == "3" || Label1.Text == "4" || Label1.Text == "5")
                {
                    Label2.Text = "1";
                }
                else if (Label1.Text == "6" || Label1.Text == "7")
                {
                    Label2.Text = "2";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('Seleccione una Opción');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('" + ex + "');", true);
            }
        }
        protected void limpiar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Label13.Text = DropDownList2.SelectedValue.ToString();
                int id = Convert.ToInt32(Label13.Text);
                if (id >= 1 && id <= 5)
                {
                    limpiar();
                    Label14.Text = "1";
                    Label7.Text = "Modelo: ";
                    Label8.Text = "Reforma: ";
                    Label9.Visible = true;
                    Label10.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = true;
                    if (id == 1)
                    {
                        TextBox7.Text = "BACHILLERATO ESCOLARIZADO";
                    }
                    else if (id == 2)
                    {
                        TextBox7.Text = "BACHILLERATO MIXTO";
                    }
                    else if (id == 3)
                    {
                        TextBox7.Text = "PROFESIONAL ASOCIADO";
                    }
                    else if (id == 4)
                    {
                        TextBox7.Text = "LICENCIATURA MIXTO";
                    }
                    else if (id == 5)
                    {
                        TextBox7.Text = "LICENCIATURA ESCOLARIZADO";
                    }
                }
                else if (id >= 6 && id <= 7)
                {
                    limpiar();
                    Label14.Text = "2";
                    Label7.Text = "Periodo: ";
                    Label8.Text = "Nivel: ";
                    Label9.Visible = false;
                    Label10.Visible = false;
                    TextBox6.Visible = false;
                    TextBox7.Visible = false;
                    if (id == 5)
                    {
                        TextBox5.Text = "MAESTRIA";
                    }
                    if (id == 6)
                    {
                        TextBox5.Text = "MAESTRIA";
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('Seleccione una Opción');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('" + ex + "');", true);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                Label11.Text = "Modificación de Datos de Carrera";
                Label12.Visible = false;
                Button3.Visible = true;
                TextBox1.Enabled = true;
                DropDownList2.Visible = false;
                TextBox1.ReadOnly = true;
                if (IsPostBack == true)
                {
                    if (Label2.Text == "1")
                    {
                        limpiar();
                        //ModalPopupExtender1.Show();
                        Label7.Text = "Modelo: ";
                        Label8.Text = "Reforma: ";
                        Label9.Visible = true;
                        Label10.Visible = true;
                        TextBox6.Visible = true;
                        TextBox7.Visible = true;
                        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
                        TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
                        TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
                        TextBox4.Text = GridView1.SelectedRow.Cells[4].Text;
                        TextBox5.Text = GridView1.SelectedRow.Cells[5].Text;
                        TextBox6.Text = GridView1.SelectedRow.Cells[6].Text;
                        TextBox7.Text = GridView1.SelectedRow.Cells[7].Text;
                        //Label11.Text = Label2.Text;

                    }
                    else if (Label2.Text == "2")
                    {
                        limpiar();
                        //ModalPopupExtender1.Show();
                        Label7.Text = "Periodo: ";
                        Label8.Text = "Nivel: ";
                        Label9.Visible = false;
                        Label10.Visible = false;
                        TextBox6.Visible = false;
                        TextBox7.Visible = false;
                        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
                        TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
                        TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;
                        TextBox4.Text = GridView1.SelectedRow.Cells[4].Text;
                        TextBox5.Text = GridView1.SelectedRow.Cells[5].Text;
                        //Label11.Text = Label2.Text;
                        //Response.Write(a + " " + b + " " + c + " " + d + " " + f);
                    }
                }
                else
                {
                    //limpiar();
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('" + ex + "');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //nueva carrera
            limpiar();
            Button3.Visible = false;
            TextBox1.Enabled = false;
            Label2.Text = "3";
            Label11.Text = "Agregar nueva Carrera";
            Label12.Visible = true;
            DropDownList2.Visible = true;
            TextBox1.ReadOnly = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(strcon);
                con.Open();
                if (Label2.Text == "1")
                {
                    sentenciaSQL = "Update carreras set descripcion = '" + TextBox2.Text + "', abreviatura = '" + TextBox3.Text + "', modelo = '" + TextBox4.Text + "', reforma = '" + TextBox5.Text + "', revicion = '" + TextBox6.Text + "', nivel = '" + TextBox7.Text + "' where id_carrera = " + TextBox1.Text;
                }
                else if (Label2.Text == "2")
                {
                    sentenciaSQL = "update maestria set descripcio = '" + TextBox2.Text + "', abreviatur = '" + TextBox3.Text + "', periodo = '" + TextBox4.Text + "', nivel = " + TextBox5.Text + "' where maestria = " + TextBox1.Text;
                }
                else if (Label2.Text == "3")
                {
                    if (Label14.Text == "1")
                    {
                        sentenciaSQL = "insert into carreras (descripcion,abreviatura,modelo,reforma,revicion,nivel) values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "');";
                    }
                    else if (Label14.Text == "2")
                    {
                        sentenciaSQL = "insert into maestria (DESCRIPCIO,ABREVIATUR,PERIODO,NIVEL) values ('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "');";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('error'); ", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('error'); ", true);
                }
                //Response.Write(sentenciaSQL);
                comando = new MySqlCommand(sentenciaSQL, con);
                comando.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('Guardado Con Éxito'); ", true);
                limpiar();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('" + ex + "');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(strcon);
                con.Open();
                if (Label2.Text == "1")
                {
                    sentenciaSQL2 = "delete from carreras where id_carrera = " + TextBox1.Text;
                }
                else if (Label2.Text == "2")
                {
                    sentenciaSQL2 = "delete from maestria where maestria = " + TextBox1.Text;
                }
                comando = new MySqlCommand(sentenciaSQL2, con);
                comando.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('Eliminado Con Éxito');", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "confirm", "confirm('" + ex + "');", true);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}