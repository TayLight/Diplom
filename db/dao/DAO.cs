using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Зачетное_задание_Евтушевская.db.entities;

namespace Зачетное_задание_Евтушевская.db.dao
{
    class DAO
    {
        private DBUntil db;

        public DAO()
        {
            db = new DBUntil();
        }

        public IEntity Add(IEntity entity)
        {
            try
            {
                using (NpgsqlConnection c = db.GetConnection())
                {
                    var sql = "insert into " + entity.Table + "(";
                    for(int i=0; i<entity.Count-1; i++)
                    {
                        sql += entity.Columns[i] + ", ";
                    }
                    sql += entity.Columns[entity.Count] + ") values (";
                    for (int i = 0; i < entity.Count - 1; i++)
                    {
                        sql += entity.Values[i] + ", ";
                    }
                    sql += entity.Values[entity.Count] + ")";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
                    cmd.ExecuteNonQuery();
                    return entity;
                }
            } catch(Exception e) { Console.WriteLine(e.Message); }
            return null;
        }

        public IEntity Edit(IEntity entity)
        {
            try
            {
                using (NpgsqlConnection c = db.GetConnection())
                {
                    var sql = "update " + entity.Table + "set";
                    for (int i = 1; i < entity.Count-1; i++)
                    {
                        sql += entity.Columns[i] + "= ";
                        sql += entity.Values[i] + ", ";
                    }
                    sql += entity.Columns[entity.Count] + "= "+ entity.Values[entity.Count] +
                        " where "+entity.Id + "=" + entity.IdValue;
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
                    cmd.ExecuteNonQuery();
                    return entity;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return null;
        }

        public IEntity Delete(IEntity entity)
        {
            try
            {
                using (NpgsqlConnection c = db.GetConnection())
                {
                    var sql = "delete from " + entity.Table;
                    sql += " where " + entity.Id + "=" + entity.IdValue;
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
                    cmd.ExecuteNonQuery();
                    return entity;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return null;
        }

        public DataTable Get(IEntity entity)
        {
            try
            {
                using (NpgsqlConnection c = db.GetConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = "Select * from "+entity.Table+" where " +entity.Id +"="+ entity.IdValue;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return null;
        }

        public DataTable GetAll(IEntity entity)
        {
            try
            {
                using (NpgsqlConnection c = db.GetConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = c;
                    cmd.CommandText = "Select * from "+entity.Table;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return null;
        }
    }
}
