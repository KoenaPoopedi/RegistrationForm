using System.Data.SqlClient;

namespace Registration
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KOENA\\SQLEXPRESS;Initial Catalog=Registration-Koena;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            nameTxb.Text = "";
            surnameTxb.Text = "";
            genderCbx.Items.Clear();
            emailTxb.Text = "";
            citizenshipCbx.Items.Clear();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Members VALUES('"+nameTxb.Text+"','"+surnameTxb.Text+"','"+genderCbx.SelectedItem.ToString()+"','"+emailTxb.Text+"','"+citizenshipCbx.SelectedItem.ToString()+"')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved");

            nameTxb.Text = "";
            surnameTxb.Text = "";
            genderCbx.Items.Clear();
            emailTxb.Text = "";
            citizenshipCbx.Items.Clear();

            con.Close();
        }
    }
}
