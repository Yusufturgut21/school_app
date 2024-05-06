using System;
using System.Web.UI;

namespace okull
{
    public partial class WebForm4 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnOpenWebForm3_Click(object sender, EventArgs e)
        {
            // WebForm3 sayfasını açmak için Response.Redirect kullanabilirsiniz.
            Response.Redirect("WebForm7.aspx");
        }

        protected void btnOpenWebForm5_Click(object sender, EventArgs e)
        {
            // WebForm4 sayfasını açmak için Response.Redirect kullanabilirsiniz.
            Response.Redirect("WebForm7.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm16.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm17.aspx");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm13.aspx");
        }

    }
}
