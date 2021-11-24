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

namespace WFA211124
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }

        public FrmMain()
        {
            ConnectionString =
                @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = pelda;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand("SELECT * FROM tabla;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(
                    /*id*/    reader.GetInt32(0) * 10,
                    /*nev*/   reader["nev"],

                    /*szul*/  reader.GetDateTime(2).ToShortDateString(),
                    /*olt*/   reader.GetDateTime(3).ToString("MMM dd. (ddd) HH:mm"),

                    /*munka*/ (new DateTime() + reader.GetTimeSpan(4)).ToString("HH:mm"));
            }
            connection.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string szul = dtpSzul.Value.ToString("yyyy-MM-dd");
            string olt = $"{dtpOltasDatum.Value.ToString("yyyy-MM-dd")} {tbOltasOra.Text}:{tbOltasPerc.Text}";
            string mnk = $"{tbMOra.Text}:00";

            var connection = new SqlConnection(ConnectionString);

            try
            {
                string errorMessage = "";


                if (string.IsNullOrWhiteSpace(nev)) errorMessage += "a név üresen maradt\n";
                if (!int.TryParse(tbMOra.Text, out _)) errorMessage += "nem jó a munkaórák formátuma\n";

                if(!string.IsNullOrEmpty(errorMessage))
                    throw new Exception(errorMessage);

                connection.Open();
                var command = new SqlCommand(
                    "INSERT INTO tabla VALUES " +
                    $"('{nev}', '{szul}', '{olt}', '{mnk}');", connection);
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = command,
                };
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }

            FillDGV();
        }
    }
}
