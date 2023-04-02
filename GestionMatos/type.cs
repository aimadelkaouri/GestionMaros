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
    public partial class type : Form
    {
        public type()
        {
            InitializeComponent();
        }

        int position = -1, Id;
        bool check = false;
        private void type_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = " SELECT * FROM type";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2]);
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "INSERT INTO type VALUES (" + this.inputId.Text + ", '" + this.inputNomMateriel.Text + "', '" + this.inputTypeMateriel.Text + "' )";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show(a + " Type ajouté");
            type_Load(sender, e);
            cnx.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            check = false;
            this.inputId.Text = String.Empty;
            this.inputNomMateriel.Text = String.Empty;
            this.inputTypeMateriel.Text = String.Empty;

            this.inputId.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM type WHERE id=@p";
            cmd.Parameters.AddWithValue("@p", Id);
            cnx.Open();
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.RemoveAt(position);
            cnx.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-C8OOC4F\SQLEXPRESS;Initial Catalog=gestionmatos;Integrated Security=True";

            String Query = "UPDATE type SET nommateriel=@p1, type=@p2 WHERE id=@p";
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cmd.Parameters.AddWithValue("@p1", this.inputNom.Text);
            cmd.Parameters.AddWithValue("@p2", this.inputNomMateriel.Text);
            cmd.Parameters.AddWithValue("@p", this.inputId.Text);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            type_Load(sender, e);
            MessageBox.Show("Le Site est bien Modifié");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridView1.CurrentRow.Index;
            Id = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString());


            this.inputId.ReadOnly = true;
            this.inputId.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
            this.inputNomMateriel.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
            this.inputTypeMateriel.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();


            check = true;
        }
    }
}
