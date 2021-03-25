using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestForGAZIT
{
    public partial class fEdform : Form
    {
        public SQLiteConnection db;
        public string EditParam;
        //public DataGridViewRow dDivision;
        public DataGridView dgEdUsers;
        public DataGridViewRow dUser;
        public DataRow drUser;
        private DataSet dsAddr;
        private DataSet dsSubs;
        public fEdform()
        {
            InitializeComponent();
            ToolTip tadd = new ToolTip();
            tadd.SetToolTip(button3, "Добавить");
            ToolTip tdel = new ToolTip();
            tdel.SetToolTip(button4, "Удалить");
            ToolTip tchPost = new ToolTip();
            tchPost.SetToolTip(bChPost, "Выбрать должность");
            ToolTip tchDiv = new ToolTip();
            tchDiv.SetToolTip(bChDivision, "Выбрать подразделение");
            ToolTip tchChief = new ToolTip();
            tchChief.SetToolTip(bChChief, "Выбрать руководителя");
            ToolTip tchAddress = new ToolTip();
            tchAddress.SetToolTip(bChAddress, "Указать адрес");
        }
        private void fEdForm_Load(object sender, EventArgs e)
        {
            if (EditParam == "add")
            {
                // добавление записи сотрудника в выбранное подразделение
                FillNewForm();
            }
            else if (EditParam == "edit")
            {
                // редактирование активной записи сотрудника
                FillEditForm();
                fillUserAddress();
                FillSbordinatedUser();
            }
            else
            {
                //Не предусмотрено пока
            }
        }
        private void FillNewForm()
        {

            tbDivision.Text = drUser.Field<string>("div_name");
            drUser.SetField("birth_date", DateTime.Now.AddYears(-20).Date);
            dtpBirthDate.Value = drUser.Field<DateTime>("birth_date");
        }
        private void FillEditForm()
        {
            if (drUser.ItemArray.Length > 0)
            {
                tbLastName.Text = drUser.Field<string>("last_name");
                tbFirstName.Text = drUser.Field<string>("first_name");
                tbSecondName.Text = drUser.Field<string>("second_name");
                tbFullName.Text = drUser.Field<string>("full_name");
                mtbPhone.Text = drUser.Field<string>("phone_num");
                tbPost.Text = drUser.Field<string>("post_name");
                tbDivision.Text = drUser.Field<string>("div_name");
                tbChief.Text = drUser.Field<string>("chief_name");
                if (drUser.Field<DateTime>("birth_date") == null)
                {
                    dtpBirthDate.Value = DateTime.MinValue;
                }
                else
                {
                    dtpBirthDate.Value = drUser.Field<DateTime>("birth_date");
                }
            }
        }
        private void FillSbordinatedUser()
        {
            string sqlQuery = "Select full_name from users where chief_id = " + drUser.Field<long>("id");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
            dsSubs = new DataSet();
            try
            {
                db.Open();
                adapter.Fill(dsSubs, "subs");
                db.Close();
                if (dsSubs.Tables[dsSubs.Tables.IndexOf("subs")].Rows.Count > 0)
                {
                    dgSubs.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    lSubs.Text = "Подчиненные:";
                    dgSubs.AutoGenerateColumns = true;
                    dgSubs.DataSource = dsSubs;
                    dgSubs.DataMember = "subs";
                    int i = 0;
                    foreach (DataGridViewColumn dgc in dgSubs.Columns)
                    {
                        dgSubs.Columns[i].HeaderText = "ФИО";
                        i = ++i;
                    }
                }
                else
                {
                    dgSubs.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    lSubs.Text = "Подчиненные отсутствуют";
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void FillDRWithForm()
        {
            drUser.SetField("last_name", tbLastName.Text);
            drUser.SetField("first_name", tbFirstName.Text);
            drUser.SetField("second_name", tbSecondName.Text);
            drUser.SetField("full_name", tbFullName.Text);
            drUser.SetField("phone_num", mtbPhone.Text);
            drUser.SetField("birth_date", dtpBirthDate.Value);//.ToString("yyyy-MM-dd");
        }
        void MakeFullName()
        {
            tbFullName.Text = tbLastName.Text + ' ' + tbFirstName.Text + ' ' + tbSecondName.Text;
        }
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            MakeFullName();
        }
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            MakeFullName();
        }
        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            MakeFullName();
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            //Тут Надо проверить доступ к базе и заполненность обязательных полей
            //Пока сохраняем в базу все, без контроля изменений
            var sqlCmd = db.CreateCommand();
            db.Open();
            sqlCmd.Connection = db;
            FillDRWithForm(); // Заполняем строку данных из полей формы
            if (EditParam == "edit")
            {
                sqlCmd.CommandText = "UPDATE Users SET " +
                "division_id = '" + (int)drUser.Field<long>("division_id") + "', " +
                "post_id = '" + (int)drUser.Field<long>("post_id") + "', " +
                "chief_id = '" + (int)drUser.Field<long>("chief_id") + "', " +
                "first_name = '" + drUser.Field<string>("first_name") + "', " +
                "second_name = '" + drUser.Field<string>("second_name") + "', " +
                "last_name = '" + drUser.Field<string>("last_name") + "', " +
                "full_name = '" + drUser.Field<string>("full_name") + "', " +
                "birth_date = '" + (drUser.Field<DateTime>("birth_date")).ToString("yyyy-MM-dd") + "', " +
                "phone_num = '" + drUser.Field<string>("phone_num") + "' " +
                "WHERE id = '" + (int)drUser.Field<long>("id") + "';";
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    db.Close();
                    Close();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (EditParam == "add")
            {
                sqlCmd.CommandText = "INSERT INTO Users (" +
                "division_id, post_id, chief_id, first_name, second_name, last_name, full_name, " +
                " birth_date, phone_num ) VALUES ('" +
                (int)drUser.Field<Int32>("division_id") + "', '" +
                (int)drUser.Field<Int32>("post_id") + "', '" +
                (int)drUser.Field<Int32>("chief_id") + "', '" +
                drUser.Field<string>("first_name") + "', '" +
                drUser.Field<string>("second_name") + "', '" +
                drUser.Field<string>("last_name") + "', '" +
                drUser.Field<string>("full_name") + "', '" +
                (drUser.Field<DateTime>("birth_date")).ToString("yyyy-MM-dd") + "', '" +
                drUser.Field<string>("phone_num") + "')";
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    db.Close();
                    Close();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                //
            }

        }
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bChPost_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select id, post_name from Posts";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
            DataSet ds = new DataSet();
            try
            {
                db.Open();
                adapter.Fill(ds, "posts");
                db.Close();
                fChForm fChPost = new fChForm();
                fChPost.dgChRef.AutoGenerateColumns = true;
                fChPost.dgChRef.DataSource = ds;
                fChPost.dgChRef.DataMember = "posts";
                int i = 0;
                foreach (DataGridViewColumn dgc in fChPost.dgChRef.Columns)
                {
                    if (dgc.Name == "id") { fChPost.dgChRef.Columns[i].Visible = false; }
                    else { fChPost.dgChRef.Columns[i].HeaderText = "Выбор"; }
                    i = ++i;
                }

                DialogResult dialogResult = fChPost.ShowDialog();
                DataGridViewRow dgSelRow = fChPost.getSelectedRow();
                drUser.SetField("post_id", dgSelRow.Cells["id"].Value);
                drUser.SetField("post_name", dgSelRow.Cells["post_name"].Value);
                tbPost.Text = drUser.Field<string>("post_name");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bChDivision_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select id, div_name from Divisions";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
            DataSet ds = new DataSet();
            try
            {
                db.Open();
                adapter.Fill(ds, "divisions");
                db.Close();
                fChForm fChDiv = new fChForm();
                fChDiv.dgChRef.AutoGenerateColumns = true;
                fChDiv.dgChRef.DataSource = ds;
                fChDiv.dgChRef.DataMember = "divisions";
                int i = 0;
                foreach (DataGridViewColumn dgc in fChDiv.dgChRef.Columns)
                {
                    if (dgc.Name == "id") { fChDiv.dgChRef.Columns[i].Visible = false; }
                    else { fChDiv.dgChRef.Columns[i].HeaderText = "Выбор"; }
                    i = ++i;
                }

                DialogResult dialogResult = fChDiv.ShowDialog();
                DataGridViewRow dgSelRow = fChDiv.getSelectedRow();
                drUser.SetField("division_id", dgSelRow.Cells["id"].Value);
                drUser.SetField("div_name", dgSelRow.Cells["div_name"].Value);
                tbDivision.Text = drUser.Field<string>("div_name");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bChChief_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select id, full_name as chief_name from Users";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
            DataSet ds = new DataSet();
            try
            {
                db.Open();
                adapter.Fill(ds, "ch_users");
                db.Close();
                fChForm fChChief = new fChForm();
                fChChief.dgChRef.AutoGenerateColumns = true;
                fChChief.dgChRef.DataSource = ds;
                fChChief.dgChRef.DataMember = "ch_users";
                int i = 0;
                foreach (DataGridViewColumn dgc in fChChief.dgChRef.Columns)
                {
                    if (dgc.Name == "id") { fChChief.dgChRef.Columns[i].Visible = false; }
                    else { fChChief.dgChRef.Columns[i].HeaderText = "Выбор"; }
                    i = ++i;
                }

                DialogResult dialogResult = fChChief.ShowDialog();
                DataGridViewRow dgSelRow = fChChief.getSelectedRow();
                drUser.SetField("chief_id", dgSelRow.Cells["id"].Value);
                drUser.SetField("chief_name", dgSelRow.Cells["chief_name"].Value);
                tbChief.Text = drUser.Field<string>("chief_name");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void fillUserAddress()
        {
            if (drUser.Field<long>("id") > 0)
            {
                string sqlQuery = "SELECT ua.id, " +
                                    "ua.user_id, " +
                                    "ua.address_id, " +
                                    "ua.valid_to, " +
                                    "a.city_id, " +
                                   "c.city_name, " +
                                    "s.street_name, " +
                                   " a.street_id, " +
                                    "a.House_num, " +
                                    "a.flat_num, " +
                                    "c.city_name|| ', '||s.street_name ||', д.' || a.house_num||', кв.'|| a.flat_num as full_addr " +
                             "FROM UserAddress ua " +
                               "join addresses a " +
                                  " on ua.address_id = a.id " +
                               "left join Cities c " +
                                   "on a.city_id = c.id " +
                               "left join Streets s " +
                                   "on a.street_id = s.id and a.city_id = s.city_id " +
                              "WHERE ua.valid_to is null and ua.user_id = " + drUser.Field<long>("id");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, db);
                try
                {
                    dsAddr = new DataSet();
                    db.Open();
                    adapter.Fill(dsAddr, "adresses");
                    db.Close();
                    if (dsAddr.Tables["adresses"].Rows.Count>0) tbAddress.Text = dsAddr.Tables["adresses"].Rows[0].Field<string>("full_addr");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bChAddress_Click(object sender, EventArgs e)
        {
            fEdAddressForm fEdAdrrForm = new fEdAddressForm();
            DialogResult dialogResult = fEdAdrrForm.ShowDialog();
        }
    }
}

