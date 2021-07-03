using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace DistanceCalculator
{
    class  PermutSeqFileGen
    {
        //assume array limit is 5 for full sequences
        const int arrayLimit = 5;
        List<String> full_sequences = new List<string>();
        String[] list = new string[] { "A", "B", "C", "D" };
        List<String> sqlDBs = new List<string>();

        public void start_permutation_Ggenerator()
        {
            Permutations.PermutationOuellet.ForAllPermutation(list, generatePermutation);

        }

        private bool generatePermutation(string[] arg)
        {
            full_sequences.Add(arg.ToString());
            if (full_sequences.Count >= arrayLimit)
            {
                full_sequences = new List<string>();
            }
            return false;
        }
        public void CreateDatabaseIfNotExists( string dbName,
            String[] dataToEnter, SqlConnection connection)
        {
          
            SqlCommand cmd = null;
                cmd = new SqlCommand($"If(db_id(N'{dbName}') IS NULL) CREATE DATABASE [{dbName}]", connection);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE Sequences (id int NOT NULL AUTO_INCREMENT,sequence VARCHAR(50));";
                cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO Sequences ( sequence) VALUES (" + dataToEnter.ToString() + ");";
            cmd.ExecuteNonQuery();
            
                }
        private void write_to_db(FileInfo fileInfo, String connectionString)
        {
            
            SqlConnection connection;
                connection = new SqlConnection(connectionString);
                connection.Open();

            }

            private String get_name_of_file(int count)
        {
            String DB_name = "Sequence";
            if (count == 0)
            {
                return (DB_name + count);
            }

            int nextIndex = count - 1;
            return (DB_name + nextIndex);
        }

        
    }
}
