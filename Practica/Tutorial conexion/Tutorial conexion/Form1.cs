using System.Data.SqlClient;
using System.Data;

namespace Tutorial_conexion
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3829VRG;Initial Catalog=tutorial;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from persona", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}