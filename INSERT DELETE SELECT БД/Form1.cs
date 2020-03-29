using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;

namespace INSERT_DELETE_SELECT_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        string ConnectionString = @"Host = localhost;Username = postgres;Password = Misha310; Database = postgres";
        string hash(string password)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(password);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
        string salt = "ILDB";
        private async void reset()
        {
            var Connect = new NpgsqlConnection(ConnectionString);
            await Connect.OpenAsync();
            NpgsqlDataReader npgsqlReader = null;
            NpgsqlCommand Command = new NpgsqlCommand("SELECT * FROM users", Connect);
            try
            {
                listView1.Items.Clear();
                npgsqlReader = Command.ExecuteReader();
                while (npgsqlReader.Read())
                {
                    ListViewItem item = new ListViewItem(npgsqlReader["id"].ToString());
                    item.SubItems.Add(npgsqlReader["login"].ToString());
                    item.SubItems.Add(npgsqlReader["password"].ToString());
                    item.SubItems.Add(npgsqlReader["registrationdate"].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (npgsqlReader != null)
                    Connect.Close();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            reset();
        }
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var Connect = new NpgsqlConnection(ConnectionString);
                    await Connect.OpenAsync();
                    string login = listView1.SelectedItems[0].SubItems[1].Text;
                    NpgsqlCommand Command = new NpgsqlCommand("DELETE FROM users WHERE login= '"+login+"' ", Connect);
                    try
                    {
                        await Command.ExecuteNonQueryAsync();
                        label1.Text= "Пользоватьтель с логином " + login + " удален";
                        reset();
                    }
                    catch
                    {
                        label1.Text = "ERROR!";
                    }
                }
            }
            else if (listView1.SelectedItems.Count == 0) label1.Text = "Выберите элемент!";
            else if (listView1.SelectedItems.Count > 1) label1.Text = "Выберите только один элемент!";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string login = listView1.SelectedItems[0].SubItems[1].Text;
                string password = listView1.SelectedItems[0].SubItems[2].Text;
                string regdate = listView1.SelectedItems[0].SubItems[3].Text;
                Form3 f = new Form3(id, login, password, regdate);
                f.Owner = this;
                f.ShowDialog();
                reset();
            }
            else if (listView1.SelectedItems.Count == 0) label1.Text = "Выберите элемент!";
            else if (listView1.SelectedItems.Count > 1) label1.Text = "Выберите только один элемент!";
        }
    }
}