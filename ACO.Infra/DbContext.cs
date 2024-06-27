using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ACO.Infra
{
	public class DbContext
	{
        private readonly string _SqlConnectionString;
        private readonly string _SqlConnectionStringTransversal;


        public DbContext(IConfiguration pConfiguration)
		{
			_SqlConnectionString = pConfiguration.GetConnectionString("ACO_DBConnectionString");
        }


        public SqlConnection CreateConnection() => new SqlConnection(_SqlConnectionString);

        public SqlConnection CreateConnectionTransversal() => new SqlConnection(_SqlConnectionStringTransversal);

    }
}
