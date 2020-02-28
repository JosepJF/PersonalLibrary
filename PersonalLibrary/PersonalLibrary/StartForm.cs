using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class StartForm : Form
    {
        private StreamWriter sw;

        public StartForm()
        {
            InitializeComponent();
        }

        //Create configuration.txt, PersonalLibraryDB, tables and open mainForm
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Server=" + comboBoxServers.Text + "; Database=master; Trusted_Connection=true";
                    conn.Open();
                    Configuration.ServerName = comboBoxServers.Text;
                    Configuration.ConnectionString = @"Server=" + comboBoxServers.Text + "; Database=PersonalLibraryDB; Trusted_Connection=true";
                    if (Directory.Exists(Configuration.path) == false)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(Configuration.path);
                    }
                    sw = File.CreateText(Configuration.pathtxt);
                }
                using (sw)
                {
                    sw.WriteLine(Configuration.ServerName);
                    sw.WriteLine(Configuration.ConnectionString);
                }
                bool db = ChechDatabase();
                if (db == false)
                {
                    CreateDataBase();
                    CreateTable();
                }
                showMainForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonChargeServers_Click(object sender, EventArgs e)
        {
            ShowSqlServerInstances();
        }

        //Show all Sql Server instances
        private void ShowSqlServerInstances()
        {
            Cursor.Current = Cursors.WaitCursor;

            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();

            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString())
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                    {
                        comboBoxServers.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        comboBoxServers.Text = servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"];
                    }
                    else
                    {
                        comboBoxServers.Items.Add(servers.Rows[i]["ServerName"]);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        //Check if PersonalLibraryDB exist in Server
        private bool ChechDatabase()
        {
            string dataBaseName = "";
            bool dbExists = false;

            try
            {
                string cmdText = "select * from master.dbo.sysdatabases where name=\'PersonalLibraryDB\'";

                using (SqlConnection sqlConnection = new SqlConnection(@"Server=" + Configuration.ServerName + "; Database=master; Trusted_Connection=true"))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConnection))
                    {

                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataBaseName = reader.GetString(0);
                            }
                        }

                        if (dataBaseName == "PersonalLibraryDB")
                            dbExists = true;
                        else
                            dbExists = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbExists;
        }

        //Create PersonalLibraryDB data base in Serverr
        private void CreateDataBase()
        {
            String str;
            SqlConnection myConn = new SqlConnection(@"Server=" + Configuration.ServerName + "; Database=master; Trusted_Connection=true");

            str = "CREATE DATABASE PersonalLibraryDB";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                //MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        //Create all tables in PersonalLibraryDB 
        private void CreateTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Configuration.ConnectionString;
                    conn.Open();

                    SqlCommand createTableComandSerie = new SqlCommand("CREATE TABLE SeriesLibrary (ID int identity primary key, Type nvarchar(10) not null," +
                    "Title nvarchar(50) not null, Score int, Year nvarchar(4), State nvarchar(20), Image nvarchar(MAX) not null)", conn);
                    createTableComandSerie.ExecuteNonQuery();

                    SqlCommand createTableComandMovies = new SqlCommand("CREATE TABLE MoviesLibrary (ID int identity primary key, Type nvarchar(10) not null," +
                    "Title nvarchar(100) not null, Score int, Year nvarchar(4), State nvarchar(20), Image nvarchar(MAX) not null)", conn);
                    createTableComandMovies.ExecuteNonQuery();

                    SqlCommand createTableComandAnime = new SqlCommand("CREATE TABLE AnimesLibrary (ID int identity primary key, Type nvarchar(10) not null," +
                    "Title nvarchar(100) not null, Score int, Year nvarchar(4), State nvarchar(20), Image nvarchar(MAX) not null)", conn);
                    createTableComandAnime.ExecuteNonQuery();

                    SqlCommand createTableComandBooks = new SqlCommand("CREATE TABLE BooksLibrary (ID int identity primary key, Type nvarchar(10) not null," +
                    "Title nvarchar(100) not null, Score int, Year nvarchar(4), State nvarchar(20), Image nvarchar(MAX) not null)", conn);
                    createTableComandBooks.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Show MainForm
        private void showMainForm()
        {
            Cursor.Current = Cursors.Default;
            Configuration.mainForm = new MainForm();
            Configuration.mainForm.Show();
            this.Hide();
        }
    }
}
