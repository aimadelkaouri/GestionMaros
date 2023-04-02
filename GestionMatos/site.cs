using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class site : Form
    {
        public site()
        {
            InitializeComponent();
        }

        int position = -1, Id;
        bool check = false;
        private void site_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = " SELECT * FROM site;";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader(); 
            if (rd.HasRows)
            {
                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4]);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "INSERT INTO site VALUES (" +this.inputIdsite.Text+ ", '" +this.inputNom.Text+ "', '" +this.inputDepartement.Text+ "', " + this.inputCp.Text+ ", '" +this.inputAdresse.Text+ "')";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show(a + "Site est ajouté");
            site_Load(sender, e);
            cnx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridView1.CurrentRow.Index;
            Id = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString());


            this.inputIdsite.ReadOnly = true;
            this.inputIdsite.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
            this.inputNom.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
            this.inputDepartement.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();
            this.inputCp.Text = this.dataGridView1.Rows[position].Cells[3].Value.ToString();
            this.inputAdresse.Text = this.dataGridView1.Rows[position].Cells[4].Value.ToString();

            check = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "UPDATE site SET nom=@p1, departement=@p2, cp=@p3, adresse=@p4 WHERE id=@p";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cmd.Parameters.AddWithValue("@p1", this.inputNom.Text);
            cmd.Parameters.AddWithValue("@p2", this.inputDepartement.Text);
            cmd.Parameters.AddWithValue("@p3", this.inputCp.Text);
            cmd.Parameters.AddWithValue("@p4", this.inputAdresse.Text);
            cmd.Parameters.AddWithValue("@p", this.inputIdsite.Text);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            site_Load(sender, e);
            MessageBox.Show("Le Site est bien Modifié");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM site WHERE id=@p";
            cmd.Parameters.AddWithValue("@p", Id);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.RemoveAt(position);
            cnx.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.inputIdsite.Text = String.Empty;
            this.inputNom.Text = String.Empty;
            this.inputDepartement.Text = String.Empty;
            this.inputCp.Text = String.Empty;
            this.inputAdresse.Text = String.Empty;

            this.inputId.ReadOnly = false;
        }
    }
}
