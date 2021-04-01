using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зачетное_задание_Евтушевская.db.dao
{
    class DBUntil
    {
        private NpgsqlConnection c;

        public NpgsqlConnection GetConnection()
        {
            if(c == null)
            {
                c = new NpgsqlConnection();
                c.ConnectionString = "Host=localhost; Database=diplom; Username=postgres; Password=root";
                c.Open();
            }
            return c;
        }
    }
}
