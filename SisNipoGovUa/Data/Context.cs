using System.Data;
using System.Data.SqlClient;

namespace SisNipoGovUa.Data
{
    public static class Context
    {
        public static IDbConnection Connect
        {
            get
            {
                return new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DecentralizationGovUa;Trusted_Connection=True;");
            }
        }
    }
}