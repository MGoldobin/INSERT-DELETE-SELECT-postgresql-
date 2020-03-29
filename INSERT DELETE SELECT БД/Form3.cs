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
    public partial class Form3 : Form
    {
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
        public Form3(string id, string login, string password, string regdate)
        {
            InitializeComponent();
            labelId.Text = id;
            labelOldLogin.Text = login;
            labelOldPass.Text = password;
            labelRegDate.Text = regdate;
        }
        private async void buttonChange_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNewLogin.Text) && !string.IsNullOrWhiteSpace(textBoxNewLogin.Text) &&
                !string.IsNullOrEmpty(textBoxNewPass.Text) && !string.IsNullOrWhiteSpace(textBoxNewPass.Text))
            {
                string new_login = textBoxNewLogin.Text;
                string new_password = hash(textBoxNewPass.Text + salt);
                string ConnectionString = @"Host = localhost;Username = postgres;Password = Misha310; Database = postgres";
                var Connect = new NpgsqlConnection(ConnectionString);
                Connect.Open();
                NpgsqlCommand Command = new NpgsqlCommand("update users set login = '"+new_login+"', password = '"+new_password+"' where login = '" + labelOldLogin.Text + "' ;", Connect);
                try
                {
                    await Command.ExecuteNonQueryAsync();
                    label3.Text = "Данные пользователя " + labelOldLogin.Text + " изменены";
                }
                catch
                {
                    label3.Text = "Пользоватьтель с логином " + textBoxNewLogin.Text + "  уже зарегистрирован";
                }
                finally
                {
                    textBoxNewLogin.Text = "";
                    textBoxNewPass.Text = "";
                }
            }
        }
        private void buttonLockPass_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.UseSystemPasswordChar) textBoxNewPass.UseSystemPasswordChar = false;
            else textBoxNewPass.UseSystemPasswordChar = true;
        }
    }
}
  