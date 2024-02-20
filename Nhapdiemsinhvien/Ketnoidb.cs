using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Ketnoidb
    {
        public DataTable Dsdiem(string sql)
        {
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MAY-26;Initial Catalog=QLdiemthi;Integrated Security=True");
                    conn.Open();
                    DataTable db = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(db);
                    conn.Close();
                    return db;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex);
                    return null;
                }
            }
        }
        public void updatedata(string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MAY-26;Initial Catalog=QLdiemthi;Integrated Security=True");
                conn.Open();
                DataTable db = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Update thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex);
                
            }
        }
    }
}
