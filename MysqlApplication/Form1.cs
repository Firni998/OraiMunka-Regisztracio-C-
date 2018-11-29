using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Kiiratas()
        {
            list_box.Items.Clear();
            using (var conn = new MySqlConnection(
             "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var command = conn.CreateCommand();


                var osszes = conn.CreateCommand();
                osszes.CommandText = "select * from felhasznalo";

                var olvas = osszes.ExecuteReader();

                while (olvas.Read())
                {

                    list_box.Items.Add(olvas["id"].ToString() + " " + olvas["nev"].ToString() + " " + olvas["regdatun"].ToString());

                }


                list_box.SelectedIndex = 0;
                
            }
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {
            string nev = NevTextBox.Text;
            string jelszo = JelszoTextBox.Text;
            DateTime szuldat = DateTimeTicker.Value;
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev";

                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A felhasználó már létezik ");
                    return;
                }

                command.CommandText = "INSERT INTO felhasznalo (nev,jelszo,regdatum) values (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuldat);
                int sorok = command.ExecuteNonQuery();

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            list_box.ClearSelected();
            string nev = NevTextBox.Text;
            string jelszo = JelszoTextBox.Text;
            DateTime szuldat = DateTimeTicker.Value;
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev and jelszo=@jelszo";

                ellenorzes.Parameters.AddWithValue("@jelszo", jelszo);
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab == 0)
                {
                    MessageBox.Show("Rossz felhasználó nevet vagyj elszót adtál meg!");
                    return;
                }

                Kiiratas();

                btn_login.Hide();
                Reg_Button.Hide();
                btn_delete.Show();
                btn_logout.Show();
                list_box.Show();
                btn_update.Show();
                list_box.SelectedIndex = 0;














            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string adat = list_box.Text;
            string[] adatok = adat.Split(' ');


            int id = int.Parse(adatok[0]);


            using (var conn = new MySqlConnection(
            "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = "Delete from felhasznalo where id=@id";
                command.Parameters.AddWithValue("@id", id);

                int torolt = command.ExecuteNonQuery();

            }
            Kiiratas();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string nev = NevTextBox.Text;
            string jelszo = JelszoTextBox.Text;

            DateTime szuldat = DateTimeTicker.Value;

            string adat = list_box.Text;
            string[] adatok = adat.Split(' ');
            int id = int.Parse(adatok[0]);

            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev and id!=@id";

                ellenorzes.Parameters.AddWithValue("@nev", nev);
                ellenorzes.Parameters.AddWithValue("@id", id);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A felhasználó már letezik");
                    return;
                }

                command.CommandText = "UPDATE felhasznalo set nev=@nev,jelszo=@jelszo,regdatum=@regdatum where id=@id";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuldat);

                command.Parameters.AddWithValue("@id", id);
                int sorok = command.ExecuteNonQuery();


                Kiiratas();
                
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string nev = NevTextBox.Text;
            string jelszo = JelszoTextBox.Text;

            DateTime szuldat = DateTimeTicker.Value;

            string adat = list_box.Text;
            string[] adatok = adat.Split(' ');
            int id = int.Parse(adatok[0]);


            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev and id!=@id";

                ellenorzes.Parameters.AddWithValue("@nev", nev);
                ellenorzes.Parameters.AddWithValue("@id", id);
                var van = (long)ellenorzes.ExecuteScalar();
                if (van != 0)
                {
                    MessageBox.Show("A felhasználó  márr letezik");
                    return;
                }

                command.CommandText = "UPDATE felhasznalo set nev=@nev,jelszo=@jelszo,regdatum=@regdatum where id=@id";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuldat);

                command.Parameters.AddWithValue("@id", id);
                int sorok = command.ExecuteNonQuery();
                Kiiratas();
                
            }
        }
    }
}
