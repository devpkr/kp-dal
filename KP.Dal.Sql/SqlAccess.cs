using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KP.Dal.Sql
{
    public class SqlAccess
    {
        public static string CONNECTION_STRING;

        public static async Task<SqlDataReader> ExecuteReaderAsync<T>(SqlCommand command, CancellationToken cancellationToken)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync(cancellationToken).ConfigureAwait(false);
                command.Connection = connection;
                var result = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection, cancellationToken).ConfigureAwait(false);
                return result;
            }
        }
    }
}
