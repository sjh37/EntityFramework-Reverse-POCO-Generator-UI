using System;
using System.CodeDom;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace EntityFramework_RPG_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectToDatabase_Click(object sender, EventArgs e)
        {
            tables.Items.Clear();

            var dcd = new DataConnectionDialog();

            var sqlDataSource = DataSource.SqlDataSource;
            dcd.DataSources.Add(sqlDataSource);
            dcd.DataSources.Add(DataSource.SqlFileDataSource);
            var result = DataConnectionDialog.Show(dcd);

            if (result != DialogResult.OK)
                return;

            // Load tables
            using (var connection = new SqlConnection(dcd.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand("SELECT name FROM sys.Tables ORDER BY name", connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
    }
}
