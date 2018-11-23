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
        
        private void Reg_Button_Click(object sender, EventArgs e)
        {
            string nev = NevTextBox.Text;
            string jelszo = JelszoTextBox.Text;
            DateTime regdatum = DateTimeTicker.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regiszracio;Uid=root;Password=;"))
            {

                conn.Open();   

            

                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhaszn where nev= @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();

                if (darab != 0)
                {
                    MessageBox.Show("A usernev mar létezik");
                    return;
                }


                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhaszn (nev,jelszo,regdatum) VALUES (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();
            }
        }
    }
}
