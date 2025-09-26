using Npgsql;
using System.Data;
namespace dev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn;
        string connection = "Host=localhost;Port=5432;Username=postgres;password=ljiet;database=sample";



        void dbconnection()
        {
            try
            {
                conn = new NpgsqlConnection(connection);
                conn.Open();
                MessageBox.Show("connection sucessfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection  not sucessfully!!!" + ex.Message);
            }
        }


        void loaddata()
        {
            try
            {
                string select = "select * from sport";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error data from database" + ex.Message);
            }



        }

        bool namevalidate()
        {
            if (nametxt.Text == "" || nametxt.Text.Length < 3 || nametxt.Text.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        bool enrollvalidate()
        {
            if (entxt.Text.Length == 0 || entxt.Text.Length != 5 || !entxt.Text.All(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (namevalidate() && enrollvalidate() && comboBox1.SelectedIndex != -1)
            {
                //MessageBox.Show("data correct");
                string insert = "insert into sport(name,en,activity)values" + "(@name,@en,@activity)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@en", Convert.ToDouble(entxt.Text));
                    cmd.Parameters.AddWithValue("@activity", comboBox1.SelectedItem.ToString());
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("data inserted");
                        nametxt.Clear();
                        entxt.Clear();
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("data  not inserted");
                    }
                }
            }
            else
            {
                MessageBox.Show("data  not correct");
            }
            loaddata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("cricket");
            comboBox1.Items.Add("football");
            comboBox1.Items.Add("baseball");
            comboBox1.Items.Add("tennis");
            dbconnection();
            loaddata();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (login log = new login())
            {
                if (log.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                nametxt.Text = r.Cells[1].Value.ToString();
                entxt.Text = r.Cells[2].Value.ToString();
                comboBox1.Text = r.Cells[3].Value.ToString();
                label4.Text = r.Cells[0].Value.ToString();


            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string update = "Update sport set name=@name,en=@en,activity=@activity";
            using(NpgsqlCommand cmd = new NpgsqlCommand(update, conn))
            {
                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                cmd.Parameters.AddWithValue("@en", nametxt.Text);
                cmd.Parameters.AddWithValue("@name", nametxt.Text);

            }
        }
    }
}
