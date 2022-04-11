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

namespace PraktikumWeek8mtc
{
    public partial class formPertandingan : Form
    {
        public formPertandingan()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84 ; uid = student; pwd = isbmantap; database = premier_league";
            MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
            MySqlCommand sqlCommand = new MySqlCommand(sqlConnection);
            MySqlDataAdapter sqlAdapter;
            string sqlQuery;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dtKiri = new DataTable();
            DataTable dtKanan = new DataTable();
            sqlQuery = "SELECT t.team_name as `Nama Tim`, m.manager_name as `Manager`, t.team_id as 'ID Tim', t.home_stadium as 'Home Stadium', t.capacity as 'Capacity', p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtKiri);
            sqlAdapter.Fill(dtKanan);
            cBoxKiri.DataSource = dtKiri;
            cBoxKanan.DataSource = dtKanan;
            cBoxKiri.DisplayMember = "Nama Tim";
            cBoxKanan.DisplayMember = "Nama Tim";

        }

        private void lblVS_Click(object sender, EventArgs e)
        {

        }

        private void cBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNamaManagerKanan.Text = cBoxKanan.SelectedValue.ToString();
        }
    }
    
}
