using System;
using System.Data;
using System.Web.UI.WebControls;

namespace okull
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the DropDownList for faculties
                // You can bind it to a data source or add items manually.
                // For simplicity, I'm adding items manually.
                DropDownList1.Items.Add(new ListItem("MÜHENDİSLİK", "1"));
                DropDownList1.Items.Add(new ListItem("EDEBİYAT", "2"));
                DropDownList1.Items.Add(new ListItem("İSLAMİ İLİMLER", "3"));
                DropDownList1.Items.Add(new ListItem("SAĞLIK BİLİMLERİ", "4"));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the faculty selection changes, populate the class DropDownList
            // and update the GridView with the class schedule based on the faculty and class selection.
            string selectedFaculty = DropDownList1.SelectedValue;
            // You can use the selectedFaculty to fetch class data from your data source.
            // For this example, I'm populating the class DropDownList manually.
            PopulateClassDropDown(selectedFaculty);
            UpdateGridView(selectedFaculty, DropDownList2.SelectedValue);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the class selection changes, update the GridView with the class schedule.
            string selectedFaculty = DropDownList1.SelectedValue;
            string selectedClass = DropDownList2.SelectedValue;
            UpdateGridView(selectedFaculty, selectedClass);
        }

        private void PopulateClassDropDown(string selectedFaculty)
        {
            // You can fetch and populate the class DropDownList based on the selected faculty.
            // For this example, I'm populating it manually.
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add(new ListItem("1", "A"));
            DropDownList2.Items.Add(new ListItem("2", "B"));
            DropDownList2.Items.Add(new ListItem("3", "C"));
            DropDownList2.Items.Add(new ListItem("4", "D"));
        }

        private void UpdateGridView(string selectedFaculty, string selectedClass)
        {
            // Fetch and bind data to the GridView based on the selected faculty and class.
            // You should have your own logic and data source for this part.
            DataTable scheduleData = FetchScheduleData(selectedFaculty, selectedClass);
            GridView1.DataSource = scheduleData;
            GridView1.DataBind();
        }

        private DataTable FetchScheduleData(string selectedFaculty, string selectedClass)
        {
            // Replace this with your logic to fetch class schedule data from your data source.
            // You would typically query a database or use some other data source to retrieve the schedule data.
            // Create a DataTable and populate it with the fetched data.
            DataTable scheduleData = new DataTable();
            // Add columns to the DataTable (e.g., Time, Course, Instructor, etc.)
            scheduleData.Columns.Add("Time");
            scheduleData.Columns.Add("Course");
            scheduleData.Columns.Add("Instructor");

            // Add rows with schedule data
            // You can add rows based on your actual data.
            scheduleData.Rows.Add("9:00 AM - 10:30 AM", "Math 101", "Dr. Smith");
            scheduleData.Rows.Add("10:45 AM - 12:15 PM", "History 202", "Prof. Johnson");
            // Add more rows as needed.

            return scheduleData;
        }
    }
}
