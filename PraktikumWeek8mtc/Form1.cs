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

            dgvData.DataSource = dtKiri;
            dgvData.DataSource = dtKanan;
        }

        private void lblVS_Click(object sender, EventArgs e)
        {
            DataTable dtMatch = new DataTable();
            DataTable dtMatch2 = new DataTable();
            sqlQuery = $"Select m.match_id , m.match_date FROM match m WHERE m.team_home = '{cBoxKiri.SelectedValue}' AND m.team_away = '{cBoxKanan.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch2);



            sqlQuery = "Select d.minute Minute, p.player_name as 'Player Name 1', if (d.type = 'CY', 'YELLOW CARD', if (d.type = 'CR', 'RED CARD', if (d.type = 'GO', 'GOAL', if (d.type = 'GP', 'GOAL PENALTY', if (d.type = 'GW', 'OWN GOAL', 'PENALTY MISS'))))) as 'Type 1', p2.player_name as 'Player Name 2', if (d2.type = 'CY', 'YELLOW CARD', if (d2.type = 'CR', 'RED CARD', if (d2.type = 'GO', 'GOAL', if (d2.type = 'GP', 'GOAL PENALTY', if (d2.type = 'GW', 'OWN GOAL', 'PENALTY MISS'))))) as 'Type 2' FROM dmatch d, dmatch d2, player p, player p2 WHERE p.player_id = d.player_id and p2.player_id = d2.player_id and d.match_id = " + dtMatch2.Rows[0][0].ToString() + " and d2.match_id = " + dtMatch2.Rows[0][0].ToString() + " ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);

            lblTanggal.Text = dtMatch.Rows[0][1].ToString();

            dgvData.DataSource = dtMatch;
        }

        private void cBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //DataTable dtKiri2 = new DataTable();
                //sqlQuery = "SELECT t.team_name as `Nama Tim`, m.manager_name as `Nama Man`, p.player_name, t.team_id as `ID TEAM` , t.capacity, concat(t.home_stadium, ',', t.city) " +
                //    "FROM team t, manager m, player p WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id And t.team_id = '" + cBoxKiri.SelectedValue.ToString() + "'";
                //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtKiri2);

                //lblNamaManagerKiri.Text = dtKiri2.Rows[cBoxKiri.SelectedIndex][4].ToString();
                //lblNamaCaptainKiri.Text = dtKiri2.Rows[cBoxKiri.SelectedIndex][5].ToString();
                //lblNamaStadium.Text = dtKiri2.Rows[cBoxKiri.SelectedIndex][2].ToString();
                //lblJumlahCapacity.Text = dtKiri2.Rows[cBoxKiri.SelectedIndex][3].ToString();
                //udh

                DataTable dtkiri = new DataTable();
                sqlQuery = "SELECT t.team_name as `Nama Tim`, m.manager_name as `Nama Man`, p.player_name, t.team_id as `ID TEAM` , t.capacity, concat(t.home_stadium, ',', t.city) " +
                    "FROM team t, manager m, player p WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id And t.team_id = '" + cBoxKiri.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtkiri);

                lblNamaManagerKiri.Text = dtkiri.Rows[0][1].ToString();
                lblNamaCaptainKiri.Text = dtkiri.Rows[0][2].ToString();
                lblStadium.Text = dtkiri.Rows[0][5].ToString();
                lblCapacity.Text = dtkiri.Rows[0][4].ToString();
            }

            catch (Exception ex)
            {
            }


        }




        private void cBoxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtkanan2 = new DataTable();
                sqlQuery = "SELECT t.team_name as `Nama Tim`, m.manager_name as `Nama Man`, p.player_name, t.team_id as `ID TEAM` FROM team t, manager m, player p WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id And t.team_id = '" + cBoxKanan.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtkanan2);

                lblNamaManagerKanan.Text = dtkanan2.Rows[0][1].ToString();
                lblNamaCaptainKanan.Text = dtkanan2.Rows[0][2].ToString();

                //DataTable dtkanan2 = new DataTable();
                //sqlQuery = "SELECT t.team_name as `Nama Tim`, m.manager_name as `Nama Man`, p.player_name, t.team_id as `ID TEAM` FROM team t, manager m, player p WHERE m.manager_id = t.manager_id and t.captain_id = p.player_id And t.team_id = '" + cBoxKanan.SelectedValue.ToString() + "'"; sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtkanan2);

                //lblNamaManagerKanan.Text = dtkanan2.Rows[cBoxKanan.SelectedIndex][4].ToString();
                //lblNamaCaptainKanan.Text = dtkanan2.Rows[cBoxKanan.SelectedIndex][5].ToString();

            }
            catch (Exception ex)
            {
            }
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPertandingan = new DataTable();

                DataTable dtPertandingan2 = new DataTable();
                sqlQuery = $"Select m.match_id , date_format(m.match_date, '%d %M %Y' ), concat(m.goal_home, ' - ', m.goal_away) as 'Skor' FROM `match` m WHERE m.team_home = '{cBoxKiri.SelectedValue}' AND m.team_away = '{cBoxKanan.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPertandingan2);

                lblTanggal.Text = dtPertandingan2.Rows[0][1].ToString();
                lblSkor.Text = dtPertandingan2.Rows[0][2].ToString();



                sqlQuery = "Select d.minute Minute, p.player_name as 'Player Name 1', if (d.type = 'CY', 'YELLOW CARD', if (d.type = 'CR', 'RED CARD', if (d.type = 'GO', 'GOAL', if (d.type = 'GP', 'GOAL PENALTY', if (d.type = 'GW', 'OWN GOAL', 'PENALTY MISS'))))) as 'Type 1', p2.player_name as 'Player Name 2', if (d2.type = 'CY', 'YELLOW CARD', if (d2.type = 'CR', 'RED CARD', if (d2.type = 'GO', 'GOAL', if (d2.type = 'GP', 'GOAL PENALTY', if (d2.type = 'GW', 'OWN GOAL', 'PENALTY MISS'))))) as 'Type 2' FROM dmatch d, dmatch d2, player p, player p2 WHERE p.player_id = d.player_id and p2.player_id = d2.player_id and d.match_id = " + dtPertandingan2.Rows[0][0].ToString() + " and d2.match_id = " + dtPertandingan2.Rows[0][0].ToString() + " ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPertandingan);


                dgvData.DataSource = dtPertandingan;

            }
            catch (Exception ex)
            {


            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
