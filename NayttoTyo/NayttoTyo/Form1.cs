
namespace NayttoTyo
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True;Encrypt=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_kirjaudu_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_nimi.Text;
            user_password = txt_salasana.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + txt_nimi.Text + "' AND password = '" + txt_salasana.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_nimi.Text;
                    user_password = txt_salasana.Text;

                    //Sivu joka lataa seuraavaksi
                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("V‰‰r‰t kirjautumistiedot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nimi.Clear();
                    txt_salasana.Clear();

                    //Nimen keskitt‰miseen
                    txt_nimi.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_alusta_Click(object sender, EventArgs e)
        {
            txt_nimi.Clear();
            txt_salasana.Clear();

            txt_nimi.Focus();
        }
    }
}
