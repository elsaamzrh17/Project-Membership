using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGymLy_MembershipAdmin.App.Core;
using ProjectGymLy_MembershipAdmin.App.Models;

namespace ProjectGymLy_MembershipAdmin.App.Context
{
    internal class StatusContext : DatabaseWrapper
    {
        private static string table = "status";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataStatus = queryExecutor(query);
            return dataStatus;
        }

        public static void AddStatus(M_Status newStatus)
        {
            string query = $"INSERT INTO {table} (status_membership) values (@status_membership)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@status_membership", NpgsqlDbType.Varchar){Value = newStatus.status_membership},
            };
            commandExecutor(query, parameters);
        }

        public static void UpdateStatus(M_Status editStatus)
        {
            string query = $"UPDATE {table} SET status_membership = @status_membership WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@status_membership", NpgsqlDbType.Varchar){Value = editStatus.status_membership},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = editStatus.id}
            };
            commandExecutor(query, parameters);
        }

        public static void DeleteStatus(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }
    }
}
