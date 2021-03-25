using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;

namespace TestForGAZIT
{

    public partial class MainForm : Form
    {
        public SQLiteConnection db;
        public DataSet ds;
        private DataTable dtForNewUser;
        private DataRow drForNewUser;
        string dbFileName = "dbSQLiteTest.sqlite3";
        public MainForm()
        {
            InitializeComponent();

        }
        public Boolean Connect_db()
        {
            if (!File.Exists(dbFileName))
            {
                MessageBox.Show("Please, create DB and tables.");
                return false;
            }
            else
            {
                try
                {
                    db.Open();
                    bdStatusLabel.Text = "Связь с БД установлена";
                    return true;
                }
                catch (SQLiteException ex)
                {
                    bdStatusLabel.Text = "Нет соединения с БД";
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private void Close_db()
        {
            try
            {
                db.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void FillDivList()
        {
            string sqlQuery = "Select id, div_name from Divisions";
            if (Connect_db())
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
                if (ds.Tables["Divisions"].Rows.Count > 0) ds.Tables["Divisions"].Clear();
                try
                {
                    adapter.Fill(ds,"Divisions");
                    Close_db();
                    dgDivision.DataSource = ds.Tables["Divisions"].DefaultView;
                    dgDivision.Columns["id"].Visible = false;
                    dgDivision.Columns["div_name"].HeaderText = "Подразделение";
                    dgDivision.Columns["div_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void MakeDRforNewuser()
        {
            dtForNewUser = new DataTable();
            dtForNewUser.Columns.Add("id", typeof(Int32));
            dtForNewUser.Columns.Add("division_id", typeof(Int32));
            dtForNewUser.Columns.Add("post_id", typeof(Int32));
            dtForNewUser.Columns.Add("chief_id", typeof(Int32));
            dtForNewUser.Columns.Add("first_name", typeof(string));
            dtForNewUser.Columns.Add("second_name", typeof(string));
            dtForNewUser.Columns.Add("last_name", typeof(string));
            dtForNewUser.Columns.Add("full_name", typeof(string));
            dtForNewUser.Columns.Add("birth_date", typeof(DateTime));
            dtForNewUser.Columns.Add("phone_num", typeof(string));
            dtForNewUser.Columns.Add("post_name", typeof(string));
            dtForNewUser.Columns.Add("chief_name", typeof(string));
            dtForNewUser.Columns.Add("div_name", typeof(string)); ;
            drForNewUser = dtForNewUser.NewRow();
        }
        private void FillUserListByDiv()
        {
            if (dgDivision.SelectedRows.Count == 0)
            {
                dgDivision.Rows[0].Selected = true;
            }
            var div_id = dgDivision.SelectedRows[0].Cells["id"].Value;

            string sqlQuery = "SELECT u.id," +
                              " u.division_id," +
                              " u.post_id," +
                              " u.chief_id," +
                              " u.first_name," +
                              " u.second_name," +
                              " u.last_name," +
                              " u.full_name," +
                              " u.birth_date," +
                              " u.phone_num," +
                              " p.post_name," +
                              " c.full_name as chief_name, " +
                              " d.div_name" +
                              " FROM Users as u " +
                              " left join Posts as p on u.post_id = p.id " +
                              " left join Users as c on u.chief_id = c.id " +
                              " join Divisions as d on u.division_id = d.id " +
                              " and u.division_id = " + div_id.ToString();
            if (Connect_db())
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
                if (ds.Tables["Users"].Rows.Count > 0) ds.Tables["Users"].Clear();
                try
                {
                    adapter.Fill(ds,"Users");
                    Close_db();
                    dgUsers.DataSource = ds.Tables["Users"].DefaultView;
                    MakeDRforNewuser();   
                    
                    if (ds.Tables["Users"].Rows.Count == 0)
                    {
                        MessageBox.Show("Пользователей в выбранном подразделении нет.");
                    }
                    else
                    {
                        dgUsers.Columns["division_id"].Visible = false;
                        dgUsers.Columns["id"].Visible = false;
                        dgUsers.Columns["post_id"].Visible = false;
                        dgUsers.Columns["chief_id"].Visible = false;
                        dgUsers.Columns["first_name"].Visible = false;
                        dgUsers.Columns["second_name"].Visible = false;
                        dgUsers.Columns["last_name"].Visible = false;
                        dgUsers.Columns["div_name"].Visible = false;
                        dgUsers.Columns["birth_date"].Visible = false;
                        dgUsers.Columns["full_name"].HeaderText = "ФИО";
                        dgUsers.Columns["phone_num"].HeaderText = "Телефон";
                        dgUsers.Columns["post_name"].HeaderText = "Должность";
                        dgUsers.Columns["chief_name"].HeaderText = "Руководитель";
                        dgUsers.Columns["birth_date"].HeaderText = "Дата рождения";
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.Tables.Add("Users");
            ds.Tables.Add("Divisions");
            db = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            FillDivList();
            FillUserListByDiv();
        }
        private void dgDivision_Click(object sender, EventArgs e)
        {
            FillUserListByDiv();
        }
        private void dgDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillUserListByDiv();
        }
        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdittoolStripButton_Click(sender, e);
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddtoolStripButton_Click(object sender, EventArgs e)
        {
            fEdform fAddUser = new fEdform();
            fAddUser.EditParam = "add";
            fAddUser.db = db;
            drForNewUser.SetField("div_name", dgDivision.SelectedRows[0].Cells["div_name"].Value);
            drForNewUser.SetField("division_id", dgDivision.SelectedRows[0].Cells["id"].Value);
            fAddUser.drUser = drForNewUser;
            fAddUser.ShowDialog();
            FillUserListByDiv();
        }
        private void EdittoolStripButton_Click(object sender, EventArgs e)
        {

            fEdform fEditUser = new fEdform();
            fEditUser.EditParam = "edit";
            fEditUser.db = db;
            DataRow[] drSelectedArray = ds.Tables["Users"].DefaultView.Table.Select("id = " + dgUsers.SelectedRows[0].Cells["id"].Value);
            fEditUser.drUser = drSelectedArray[0];
            //fEditUser.dUser = dgUsers.SelectedRows[0];
            fEditUser.ShowDialog();
            FillUserListByDiv();
        }
        private void DeltoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var sqlCmd = db.CreateCommand();
                sqlCmd.CommandText = "DELETE from Users WHERE id = '" + dgUsers.SelectedRows[0].Cells["id"].Value + "';";
                try
                {
                    if (Connect_db())
                    {
                        sqlCmd.ExecuteNonQuery();
                        db.Close();
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                FillUserListByDiv();
            }
        }

        private void RefStreets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }

        private void RefCities_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }
        private void RefPosts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }
        private void RefDivisions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }
    }
}
