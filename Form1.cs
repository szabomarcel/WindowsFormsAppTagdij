using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace WindowsFormsAppTagdij
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();
            tagokBetoltese();
        }

        private void tagokBetoltese()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1 ORDER BY nev;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        Tag beolvasottTag = new Tag(dr.GetInt32("azon"),dr.GetString("nev"),dr.GetInt32("szulev"), dr.GetInt32("irszam"), dr.GetString("orsz"));
                        listBox_tagok.Items.Add(beolvasottTag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void listBox_tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_tagok.SelectedIndex<0)
            {
                return;
            }
            Tag kivalasztottTag = listBox_tagok.SelectedItem as Tag;
            textBox_azon.Text = kivalasztottTag.azon.ToString();
            textBox_nev.Text = kivalasztottTag.nev.ToString();
            textBox_orsz.Text = kivalasztottTag.orsz.ToString();
            numericUpDownIrszam.Value = (decimal)kivalasztottTag.irszam;
            numericUpDownSzulev.Value = (decimal)kivalasztottTag.szulev;
        }

        private void button_letrehozas_Click(object sender, EventArgs e)
        {
            listBox_tagok.Items.Clear();
            //-- A beviteli mezőben lévő adat ellenőrzés
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
            //-- STB.
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDownSzulev.Value;
            decimal irszam = numericUpDownIrszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (NULL, @nev, @szulev, @irszam, @orsz)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szulev", szulev);
            command.Parameters.AddWithValue("@irszam", irszam);
            command.Parameters.AddWithValue("@orsz", orsz);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            textBox_nev.Text = "";
            numericUpDownSzulev.Value = numericUpDownSzulev.Minimum;
            numericUpDownIrszam.Value = numericUpDownIrszam.Minimum;
            textBox_orsz.Text = "H";
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            listBox_tagok.Items.Clear();
            //-- A beviteli mezőben lévő adat ellenőrzés
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs módosítva!");
                return;
            }
            //-- STB.
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDownSzulev.Value;
            decimal irszam = numericUpDownIrszam.Value;
            string orsz = textBox_orsz.Text;            
            command.CommandText = "UPDATE `ugyfel` SET `azon`= null,`nev`= @nev,`szulev`= @szulev,`irszam`= @irszam,`orsz`= @orsz WHERE `azon`= @azon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szulev", szulev);
            command.Parameters.AddWithValue("@irszam", irszam);
            command.Parameters.AddWithValue("@orsz", orsz);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            textBox_nev.Text = "";
            numericUpDownSzulev.Value = numericUpDownSzulev.Minimum;
            numericUpDownIrszam.Value = numericUpDownIrszam.Minimum;
            textBox_orsz.Text = "H";
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            listBox_tagok.Items.Clear();
            //-- A beviteli mezőben lévő adat ellenőrzés
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs törölve!");
                return;
            }
            //-- STB.
            string nev = textBox_nev.Text;
            decimal szulev = numericUpDownSzulev.Value;
            decimal irszam = numericUpDownIrszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "DELETE FROM `ugyfel` WHERE `azon` = azon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@azon", textBox_azon);            
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            textBox_nev.Text = "";
            numericUpDownSzulev.Value = numericUpDownSzulev.Minimum;
            numericUpDownIrszam.Value = numericUpDownIrszam.Minimum;
            textBox_orsz.Text = "H";
        }
    }
}
