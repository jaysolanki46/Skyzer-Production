using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyzer_Production.Init
{
    class DBOperations
    {   
        public SqlConnection getConn()
        {
            SqlConnection con = 
                new SqlConnection(
                    "Data Source=localhost;Initial Catalog=SkyzerProduction;Integrated Security=True"
                    );
            return con;
        }

    }
}
 