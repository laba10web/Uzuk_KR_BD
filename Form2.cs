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

namespace Uzuk_Affiche
{
    public partial class Form2 : Form
    {

        public DataSet ds_play;
        public DataSet ds_poster;
        public DataSet ds_theatre;
      
        MySqlDataAdapter adapter_play;
        MySqlDataAdapter adapter_poster;
        MySqlDataAdapter adapter_theatre;
       
        MySqlCommandBuilder commandBuilder;
        string connStr = "server=localhost;user=root;database=affiche;password=c9a0t1;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            data_poster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_poster.AllowUserToAddRows = false;
            data_play.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_play.AllowUserToAddRows = false;
            data_theatre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_theatre.AllowUserToAddRows = false;
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                string sql = "SELECT * FROM poster;";
                adapter_poster = new MySqlDataAdapter(sql, connection);
                ds_poster = new DataSet();
                adapter_poster.Fill(ds_poster);
                data_poster.DataSource = ds_poster.Tables[0];

                sql = "SELECT * FROM play;";
                adapter_play = new MySqlDataAdapter(sql, connection);
                ds_play = new DataSet();
                adapter_play.Fill(ds_play);
                data_play.DataSource = ds_play.Tables[0];

                sql = "SELECT * FROM theatre;";
                adapter_theatre = new MySqlDataAdapter(sql, connection);
                ds_theatre = new DataSet();
                adapter_theatre.Fill(ds_theatre);
                data_theatre.DataSource = ds_theatre.Tables[0];
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView grid;
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0:
                    grid =  data_poster;
                    break;
                case 1:
                    grid = data_theatre;
                    break;
                case 2:
                    grid =  data_play;
                    break;
                default:
                    grid = data_poster;
                    break;
            }

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                grid.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds;
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0:
                    ds = ds_poster;
                    break;
                case 1:
                    ds = ds_theatre;
                    break;
                case 2:
                    ds = ds_play;
                    break;
                default:
                    ds = ds_poster;
                    break;
            }
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            DataGridView grid;
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0:
                    grid = data_poster;
                    break;
                case 1:
                    grid = data_theatre;
                    break;
                case 2:
                    grid = data_play;
                    break;
                default:
                    grid = data_poster;
                    break;
            }

            grid.CurrentRow.Selected = false;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    string now = grid.Rows[i].Cells[j].Value.ToString();
                    if (now.Contains(search))
                    {
                        grid.Rows[i].Selected = true;
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DataSet ds;
            MySqlDataAdapter adapter;
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0:
                    ds = ds_poster;
                    adapter = adapter_poster;
                    break;
                case 1:
                    ds = ds_theatre;
                    adapter = adapter_theatre;
                    break;
                case 2:
                    ds = ds_play;
                    adapter = adapter_play;
                    break;
                default:
                    ds = ds_poster;
                    adapter = adapter_poster;
                    break;
            }

            using (MySqlConnection connect = new MySqlConnection(connStr))
            {
                connect.Open();
                commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
            }
        }
    }
}
