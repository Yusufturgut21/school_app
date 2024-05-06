using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace okull
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        // Veritabanı bağlantısı için bağlantı dizesini tanımlama
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
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text) || DropDownList1.SelectedValue == "")
            {
                // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tüm bilgileri doldurun.');", true);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // SQL sorgusu ve SqlCommand nesnesi oluşturma
                string sql = "INSERT INTO Table_2 (OgretmenAd, OgretmenSoyad, Yaş, Ders, OgretmenID) VALUES (@OgretmenAd, @OgretmenSoyad, @Yaş, @Ders, @OgretmenID)";
                SqlCommand comm = new SqlCommand(sql, con);

                // Parametreleri eklemek için
                comm.Parameters.AddWithValue("@OgretmenAd", TextBox1.Text);
                comm.Parameters.AddWithValue("@OgretmenSoyad", TextBox2.Text);
                comm.Parameters.AddWithValue("@Yaş", int.Parse(TextBox3.Text));
                comm.Parameters.AddWithValue("@Ders", DropDownList1.SelectedValue);
                comm.Parameters.AddWithValue("@OgretmenID", int.Parse(TextBox4.Text));

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

                string sql = "SELECT * FROM Table_2";
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
            // Veritabanı bağlantısı için bağlantı dizesini tanımlama
            string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=DenemeDb;Integrated Security=True";

            // Öğretmen ID'sini al
            string ogretmenIDText = TextBox4.Text;

            if (string.IsNullOrEmpty(ogretmenIDText))
            {
                // Öğretmen ID boşsa uyarı mesajı göster
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('SİLMEK İSTEDİĞİNİZ ÖĞRETMEN ID GİRİNİZ.');", true);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Öğrenciyi bulmak için SQL sorgusu ve SqlCommand nesnesi oluşturma
                string findSql = "SELECT * FROM Table_2 WHERE OgretmenID = @OgretmenID";
                SqlCommand findComm = new SqlCommand(findSql, con);
                findComm.Parameters.AddWithValue("@OgretmenID", int.Parse(ogretmenIDText)); // Silinecek öğrencinin ID'si

                SqlDataReader reader = findComm.ExecuteReader();

                if (reader.Read())
                {
                    // Öğrenci bulundu, silme işlemine devam et
                    reader.Close();

                    // Silme işlemi için SQL sorgusu ve SqlCommand nesnesi oluşturma
                    string deleteSql = "DELETE FROM Table_2 WHERE OgretmenID = @OgretmenID";
                    SqlCommand deleteComm = new SqlCommand(deleteSql, con);
                    deleteComm.Parameters.AddWithValue("@OgretmenID", int.Parse(ogretmenIDText));

                    int rowsAffected = deleteComm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Silme işlemi başarılıysa kullanıcıya bildirim göster
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('BAŞARIYLA SİLİNDİ.');", true);

                        // Verileri yeniden yükle
                        LoadRecords();
                    }
                    else
                    {
                        // Silme başarısızsa kullanıcıya hata bildirimi göster
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Deletion Failed');", true);
                    }
                }
                else
                {
                    // Öğrenci bulunamadı, kullanıcıya bir mesaj göster
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Öğrenci bulunamadı.');", true);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // TextBox kontrollerini temizle
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Eksik bilgileri kontrol et
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text))
            {
                // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tüm bilgileri doldurun.');", true);
                return;
            }

            // Veritabanı bağlantısı için bağlantı dizesini tanımlama
            string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=DenemeDb;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // SQL sorgusu ve SqlCommand nesnesi oluşturma
                string sql = "UPDATE Table_2 SET OgretmenAd = @OgretmenAd, OgretmenSoyad = @OgretmenSoyad, Yaş = @Yaş, Ders = @Ders WHERE OgretmenID = @OgretmenID";
                SqlCommand comm = new SqlCommand(sql, con);

                // Parametreleri eklemek için
                comm.Parameters.AddWithValue("@OgretmenAd", TextBox1.Text);
                comm.Parameters.AddWithValue("@OgretmenSoyad", TextBox2.Text);
                comm.Parameters.AddWithValue("@Yaş", int.Parse(TextBox3.Text));
                comm.Parameters.AddWithValue("@Ders", DropDownList1.SelectedValue); // DropDownList1'den seçim yapılıyor, eğer kullanıcıya özel bir değer girmesini isterseniz bu kısmı düzenleyebilirsiniz.
                comm.Parameters.AddWithValue("@OgretmenID", int.Parse(TextBox4.Text));

                // Sorguyu çalıştırma
                int rowsAffected = comm.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Güncelleme işlemi başarılıysa kullanıcıya bildirim göster
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Başarıyla Güncellendi');", true);

                    // Verileri yeniden yükle
                    LoadRecords();
                }
                else
                {
                    // Güncelleme başarısızsa kullanıcıya hata bildirimi göster
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Güncelleme Başarısız');", true);
                }
            }
        }

    }
}
