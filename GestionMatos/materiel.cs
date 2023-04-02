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
    public partial class materiel : Form
    {
        public materiel()
        {
            InitializeComponent();
        }

        int position = -1, Id;
        bool check = false;
        private void materiel_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";
            String Query = "SELECT * FROM Materiel;";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "INSERT INTO materiel VALUES ("+this.inputId.Text+", '"+this.inputNom.Text+"', "+this.inputSerie.Text+", "+this.inputMtbf.Text+", '"+this.inputDate.Text+"', '"+this.inputDescription.Text+"' )";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show(a + "Materiel ajouté");
            materiel_Load(sender, e);
            cnx.Close();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "UPDATE materiel SET nom=@p1, numdeserie=@p2, mtbf=@p3, dateinstallation=@p4, description=@p5 WHERE id=@p";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cmd.Parameters.AddWithValue("@p1", this.inputNom.Text);
            cmd.Parameters.AddWithValue("@p2", this.inputSerie.Text);
            cmd.Parameters.AddWithValue("@p3", this.inputMtbf.Text);
            cmd.Parameters.AddWithValue("@p4", this.inputDate.Text);
            cmd.Parameters.AddWithValue("@p5", this.inputDescription.Text);
            cmd.Parameters.AddWithValue("@p", this.inputId.Text);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            materiel_Load(sender, e);
            MessageBox.Show("Le Materiel est bien Modifié");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.inputId.Text = String.Empty;
            this.inputNom.Text = String.Empty;
            this.inputSerie.Text = String.Empty;
            this.inputMtbf.Text = String.Empty;
            this.inputDate.Text = String.Empty;
            this.inputDescription.Text = String.Empty;


            this.inputId.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText= "DELETE FROM materiel WHERE id=@p";
            cmd.Parameters.AddWithValue("@p", Id);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.RemoveAt(position);
            cnx.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridView1.CurrentRow.Index;
            Id = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString());


            this.inputId.ReadOnly = true;
            this.inputId.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
            this.inputNom.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
            this.inputSerie.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();
            this.inputMtbf.Text = this.dataGridView1.Rows[position].Cells[3].Value.ToString();
            this.inputDate.Text = this.dataGridView1.Rows[position].Cells[4].Value.ToString();
            this.inputDescription.Text = this.dataGridView1.Rows[position].Cells[5].Value.ToString();

            check = true;
        }
    }
}
