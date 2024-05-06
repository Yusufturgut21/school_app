using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace okull
{
    public partial class WebForm71 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = TextBox1.Text;
            string password = TextBox2.Text;

            if (IsUserValid(username, password))
            {
                // Doğruysa WebForm8.aspx sayfasına yönlendirin
                Response.Redirect("WebForm8.aspx");
            }
            else
            {
                // Doğru değilse JavaScript ile bir uyarı mesajı gösterin
                string script = "alert('Kullanıcı adı veya şifre yanlış.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
        }

        private bool IsUserValid(string username, string password)
        {
            // Kullanıcı adı ve şifre doğrulama mantığını burada gerçekleştirin
            // Örnek bir doğrulama işlemi:
            return (username == "YUSUF" && password == "TURGUT");
        }
    }

    }
    
