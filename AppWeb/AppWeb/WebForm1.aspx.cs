using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogear_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            try
            {
                if (cliente.LoggearCliente(int.Parse(txtNumEmpleado.Text), txtContrasena.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Holi');</script>");
                    Response.Redirect("WebForm2.aspx");
                }
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Algo salió mal');</script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}