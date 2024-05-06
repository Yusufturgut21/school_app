using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace okull
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=DenemeDb;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecords(); // Sayfa yüklendiğinde verileri yükle
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Eksik bilgileri kontrol et
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tüm bilgileri doldurun.');", true);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // SQL sorgusu ve SqlCommand nesnesi oluşturma
                string sql = "INSERT INTO Date_Table (Date ,TeacherName, Day, [8AM-9AM], [9AM-10AM], [10AM-11AM], [11AM-12PM]) VALUES (@Date, @TeacherName, @Day, @8AM9AM, @9AM10AM, @10AM11AM, @11AM12PM)";
                SqlCommand comm = new SqlCommand(sql, con);

                // Parametreleri eklemek için
                comm.Parameters.AddWithValue("@Date", TextBox2.Text);
                comm.Parameters.AddWithValue("@TeacherName", TextBox1.Text);
                comm.Parameters.AddWithValue("@Day", DropDownList1.SelectedValue);
                comm.Parameters.AddWithValue("@8AM9AM", DropDownList2.SelectedValue);
                comm.Parameters.AddWithValue("@9AM10AM", DropDownList3.SelectedValue);
                comm.Parameters.AddWithValue("@10AM11AM", DropDownList4.SelectedValue);
                comm.Parameters.AddWithValue("@11AM12PM", DropDownList5.SelectedValue);

                // Sorguyu çalıştırma
                comm.ExecuteNonQuery();
            }

            // Ekleme işlemi tamamlandığında kullanıcıya bildirim göster
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Başarıyla Eklendi');", true);

            // Verileri yeniden yükle
            LoadRecords();
        }

        void LoadRecords()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Date_Table";
                SqlCommand comm = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Eksik bilgileri kontrol et
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
            {
                // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen öğretmen adını ve tarihi girin.');", true);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // SQL sorgusu ve SqlCommand nesnesi oluşturma
                string sql = "UPDATE Date_Table SET TeacherName = @TeacherName, Day = @Day, [8AM-9AM] = @8AM9AM, [9AM-10AM] = @9AM10AM, [10AM-11AM] = @10AM11AM, [11AM-12PM] = @11AM12PM WHERE Date = @Date";
                SqlCommand comm = new SqlCommand(sql, con);

                // Parametreleri eklemek için
                comm.Parameters.AddWithValue("@Date", TextBox2.Text);
                comm.Parameters.AddWithValue("@TeacherName", TextBox1.Text);
                comm.Parameters.AddWithValue("@Day", DropDownList1.SelectedValue);
                comm.Parameters.AddWithValue("@8AM9AM", DropDownList2.SelectedValue);
                comm.Parameters.AddWithValue("@9AM10AM", DropDownList3.SelectedValue);
                comm.Parameters.AddWithValue("@10AM11AM", DropDownList4.SelectedValue);
                comm.Parameters.AddWithValue("@11AM12PM", DropDownList5.SelectedValue);

                // Sorguyu çalıştırma
                comm.ExecuteNonQuery();
            }

            // Güncelleme işlemi tamamlandığında kullanıcıya bildirim göster
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Başarıyla Güncellendi');", true);

            // Verileri yeniden yükle
            LoadRecords();
        }

       protected void Button3_Click(object sender, EventArgs e)
{
    // Eksik bilgileri kontrol et
    if (string.IsNullOrEmpty(TextBox2.Text))
    {
        // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tarihi girin.');", true);
        return;
    }

    using (SqlConnection con = new SqlConnection(connectionString))
    {
        con.Open();

        // SQL sorgusu ve SqlCommand nesnesi oluşturma
        string sql = "DELETE FROM Date_Table WHERE Date = @Date";
        SqlCommand comm = new SqlCommand(sql, con);

        // Parametreyi eklemek için
        comm.Parameters.AddWithValue("@Date", TextBox2.Text);

        // Sorguyu çalıştırma
        comm.ExecuteNonQuery();
    }

    // Silme işlemi tamamlandığında kullanıcıya bildirim göster
    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Başarıyla Silindi');", true);

    // Verileri yeniden yükle
    LoadRecords();
}

    }
}
