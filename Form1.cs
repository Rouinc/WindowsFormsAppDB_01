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

namespace WindowsFormsAppDB_01
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=premier_league;user=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter,adapterteam;
        DataTable table,tableteam;
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lihatTeam();
        }


        public void lihatTeam()
        {
            string query = "select team.team_id,team.team_name,manager.manager_name,team.home_stadium,player.player_name from team inner join manager on team.manager_id=manager.manager_id inner join player on team.captain_id=player.player_id";
           
            command = new MySqlCommand(query, connection);
            adapterteam = new MySqlDataAdapter(command);
            tableteam = new DataTable();
            adapterteam.Fill(tableteam);
            showRecord(0);

        }

        public void showRecord(int index)
        {
            string team = tableteam.Rows[index][1].ToString();
            string manager = tableteam.Rows[index][2].ToString();
            string stadium = tableteam.Rows[index][3].ToString();

            labelteam.Text = "Team Manager : " + team;
            labelmanager.Text = "Manager : " + manager;
            labelstadium.Text = "Stadium : " + stadium;
        }   



        public void lihatData()
        {
            string query = "select team.team_name,manager.manager_name,team.home_stadium,player.player_name from team inner join manager on team.manager_id=manager.manager_id inner join player on team.captain_id=player.player_id";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewmatch.DataSource = table;
            lihatRecord();
        }

        public void lihatRecord()
        {
            
            //.Text = dataGridView1.Rows[pos].Cells[0].Value.ToString();

            string team = dataGridViewmatch.Rows[pos].Cells[0].Value.ToString();
            string manager = dataGridViewmatch.Rows[pos].Cells[1].Value.ToString();
            string stadium = dataGridViewmatch.Rows[pos].Cells[2].Value.ToString();
        

            labelteam.Text = "Team Manager : " + team;
            labelmanager.Text = "Manager : " + manager;
            labelstadium.Text = "Stadium : " + stadium;
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos = pos + 1;
            if (pos>tableteam.Rows.Count-1)
            {
                MessageBox.Show("Akhir Data");
                pos = tableteam.Rows.Count-1;
            }
            showRecord(pos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = pos - 1;
            if (pos < 0)
            {
                pos = 0;
                MessageBox.Show("Record Awal");
            }
            showRecord(pos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = tableteam.Rows.Count - 1;
            showRecord(pos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pos = 0;
            showRecord(pos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lihatRecord();
        }
    }
}
