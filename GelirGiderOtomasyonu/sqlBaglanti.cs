using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GelirGiderOtomasyonu
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-7LIB0QO\SQLEXPRESS;Initial Catalog=KasaGelirGiderOtomasyonu;Integrated Security=True");
            b.Open();
            return b;   
        }
    }
}
