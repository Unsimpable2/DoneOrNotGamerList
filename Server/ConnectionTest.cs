using System;
using System.Collections.Generic;
using Npgsql;

namespace Server
{
    class ConnectionTest
    {
        static void Main(string[] args)
        {
            TestConnection();
            Console.ReadKey();
        }
        private static void TestConnection()
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected to database");
                }
                else 
                {
                    Console.WriteLine("Cannot connect to database");
                }
            }
        }
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Host=localhost; Database=DoneOrNotGamerListDB; Username=postgres; Password=admin; Port=1234");
        }
    }
}