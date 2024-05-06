using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace okull
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        // Veritabanı bağlantısı için bağlantı dizesini tanımlama
        string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=programmingDB;Integrated Security=True";
        //Data Source: SQL Server adresi ve örneği
        //Initial Catalog: Bağlanılacak veritabanının adı
       // Integrated Security=True: Windows kimlik doğrulama kullanılacak
       //Bu bağlantı dizesi, SqlConnection nesnesini oluşturarak C# programında SQL Server veritabanına bağlanmak için kullanılabilir.






        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadRecords(); // Sayfa yüklendiğinde verileri yükle
            }


        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            // Eksik veya yanlış bilgileri kontrol et
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text))
            {
                // Eksik bilgiler için uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tüm bilgileri doldurun.');", true);
                return;
            }

            int studentID;
            if (!int.TryParse(TextBox1.Text, out studentID))
            {
                // StudentID geçerli bir tamsayı değilse uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Öğrenci ID geçerli bir tamsayı olmalıdır.');", true);
                return;
            }

            double age;
            if (!double.TryParse(TextBox3.Text, out age))
            {
                // Age geçerli bir sayı değilse uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Yaş geçerli bir sayı olmalıdır.');", true);
                return;
            }
            long contact;
            if (!long.TryParse(TextBox4.Text, out contact))
            {
                // Contact geçerli bir long tamsayı değilse uyarı mesajı göster ve işlemi durdur
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('İletişim bilgisi geçerli bir tamsayı olmalıdır.');", true);
                return;
            }


            string studentName = TextBox2.Text;

            // Daha sonra studentName'i kullanabilirsiniz


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // SQL sorgusu ve SqlCommand nesnesi oluşturma
                string sql = "INSERT INTO StudentInfo_Tab (StudentID, StudentName, Adress, Age, Contact) VALUES (@StudentID, @StudentName, @Adress, @Age, @Contact)";
                SqlCommand comm = new SqlCommand(sql, con);

                // Parametreleri eklemek için
                comm.Parameters.AddWithValue("@StudentID", studentID);
                comm.Parameters.AddWithValue("@StudentName", TextBox2.Text);
                comm.Parameters.AddWithValue("@Adress", DropDownList1.SelectedValue);
                comm.Parameters.AddWithValue("@Age", age);
                comm.Parameters.AddWithValue("@Contact", contact);

                // Sorguyu çalıştırma
                comm.ExecuteNonQuery();
            }

            // Ekleme işlemi tamamlandığında kullanıcıya bildirim göster
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Başarıyla Eklendi');", true);

            // Verileri yeniden yükle
            LoadRecords();
        }



        // Verileri veritabanından çekip GridView'e yükleme
        void LoadRecords()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM StudentInfo_Tab";
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
            string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=programmingDB;Integrated Security=True";

            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text) || string.IsNullOrWhiteSpace(TextBox3.Text) || string.IsNullOrWhiteSpace(TextBox4.Text))
            {
                // Eksik bilgi uyarısı göster
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen tüm bilgileri girin');", true);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL sorgusu ve SqlCommand nesnesi oluşturma
                    string sql = "UPDATE StudentInfo_Tab SET StudentName = @StudentName, Adress = @Adress, Age = @Age, Contact = @Contact WHERE StudentID = @StudentID";
                    SqlCommand comm = new SqlCommand(sql, con);

                    // Parametreleri eklemek için
                    comm.Parameters.AddWithValue("@StudentID", int.Parse(TextBox1.Text)); // Güncellenecek öğrencinin ID'si
                    comm.Parameters.AddWithValue("@StudentName", TextBox2.Text); // Yeni öğrenci adı
                    comm.Parameters.AddWithValue("@Adress", DropDownList1.SelectedValue); // Yeni adres
                    comm.Parameters.AddWithValue("@Age", double.Parse(TextBox3.Text)); // Yeni yaş
                    comm.Parameters.AddWithValue("@Contact", TextBox4.Text); // Yeni iletişim bilgisi

                    // Sorguyu çalıştırma
                    int rowsAffected = comm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Güncelleme işlemi tamamlandığında kullanıcıya bildirim göster
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('BAŞARIYLA GÜNCELLENDİ.');", true);

                        // Verileri yeniden yükle
                        LoadRecords();
                    }
                    else
                    {
                        // Güncelleme başarısızsa kullanıcıya hata bildirimi göster
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('GÜNCELLEME BAŞARISIZ!!!');", true);
                    }
                }
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı için bağlantı dizesini tanımlama
            string connectionString = "Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=programmingDB;Integrated Security=True";

            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                // ID alanı boşsa kullanıcıya bir mesaj göster
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Lütfen ID değeri giriniz.');", true);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Öğrenciyi bulmak için SQL sorgusu ve SqlCommand nesnesi oluşturma
                    string findSql = "SELECT * FROM StudentInfo_Tab WHERE StudentID = @StudentID";
                    SqlCommand findComm = new SqlCommand(findSql, con);
                    findComm.Parameters.AddWithValue("@StudentID", int.Parse(TextBox1.Text)); // Silinecek öğrencinin ID'si

                    SqlDataReader reader = findComm.ExecuteReader();

                    if (reader.Read())
                    {
                        // Öğrenci bulundu, silme işlemine devam et
                        reader.Close();

                        // Silme işlemi için SQL sorgusu ve SqlCommand nesnesi oluşturma
                        string deleteSql = "DELETE FROM StudentInfo_Tab WHERE StudentID = @StudentID";
                        SqlCommand deleteComm = new SqlCommand(deleteSql, con);
                        deleteComm.Parameters.AddWithValue("@StudentID", int.Parse(TextBox1.Text));

                        int rowsAffected = deleteComm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Silme işlemi başarılıysa kullanıcıya bildirim göster
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('SİLME İŞLEMİ BAŞARILI');", true);

                            // Verileri yeniden yükle
                            LoadRecords();
                        }
                        else
                        {
                            // Silme başarısızsa kullanıcıya hata bildirimi göster
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('silme başarısız!!');", true);
                        }
                    }
                    else
                    {
                        // Öğrenci bulunamadı, kullanıcıya bir mesaj göster
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Öğrenci bulunamadı.');", true);
                    }
                }
            }
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            // TextBox kontrollerini temizle
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Olay işleyici kodunu burada tanımlayın.
        }



    }
}
