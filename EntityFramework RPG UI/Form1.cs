﻿using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace EntityFramework_RPG_UI
{
    public partial class Form1 : Form
    {
        private const string NoTables = "TableFilterInclude = new Regex(\"^$\");";
        private const string AllTables = "TableFilterInclude = null;";

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
            dcd.SelectedDataSource = sqlDataSource;
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

        private void tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRegex();
        }

        private void UpdateRegex()
        {
            if (tables.CheckedItems.Count == 0)
            {
                regex.Text = NoTables;
                return;
            }

            var sb = new StringBuilder();
            sb.Append("TableFilterInclude = new Regex(\"");

            bool first = true;
            foreach (var item in tables.CheckedItems)
            {
                if (!first)
                    sb.Append("|");
                else
                    first = false;

                sb.AppendFormat("^{0}$", item);
            }

            sb.Append("\");");
            Clipboard.SetText(sb.ToString());
            regex.Text = sb.ToString();
        }

        private void selectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for(var n = 0; n < tables.Items.Count; n++)
            {
                tables.SetItemCheckState(n, CheckState.Checked);
            }
            regex.Text = AllTables;
            Clipboard.SetText(AllTables);
        }

        private void selectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (var n = 0; n < tables.Items.Count; n++)
            {
                tables.SetItemCheckState(n, CheckState.Unchecked);
            }
            regex.Text = NoTables;
            Clipboard.SetText(NoTables);
        }
    }
}
