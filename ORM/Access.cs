using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;


namespace ORM
{
    internal class Access
    {
        public SqlConnection Coneccion = new SqlConnection("Data Source=.;Initial Catalog=STOCK;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public SqlTransaction transaction;

        public void Open()
        {
            Coneccion.Open();
        }

        public void Close()
        {
            Coneccion.Close();
        }
        public void Start_TX()
        {
            transaction = Coneccion.BeginTransaction();
        }   

        public void Commit_TX()
        {
            transaction.Commit(); 
        }

        public void Cancelar_TX()
        {
            transaction.Rollback();
        }

        public DataTable Leer( string storedprocedure, SqlParameter[ ]? parameter = null )
        {
            DataTable table = new DataTable();
            try
            {
                Open();
                Start_TX();

                using (SqlCommand cmd = new SqlCommand(storedprocedure))
                {
                    cmd.Connection = Coneccion;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.Text;

                    if ( parameter != null )
                        cmd.Parameters.AddRange( parameter );

                    using ( SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }

                }
                return table;
            }
            catch
            {
                Cancelar_TX();
                return table;
            }
            finally
            {
                Close();
            }
        }
        public int Escribir(string storedprocedure, SqlParameter[]? parameter = null)
        {
            try 
            {
                Open();
                int filasafectadas = 0;

                Start_TX();
                using (SqlCommand sqlcommand = new SqlCommand(storedprocedure))
                {
                    sqlcommand.CommandType = CommandType.StoredProcedure;
                    sqlcommand.CommandText = storedprocedure;
                    sqlcommand.Connection = Coneccion;

                    if (parameter != null)
                    {
                        sqlcommand.Parameters.AddRange(parameter);
                    }

                    filasafectadas = sqlcommand.ExecuteNonQuery(); /// Devolvemos las filas afectadas

                    Commit_TX();

                    
                }
                return filasafectadas;
            }
            catch
            {
                Cancelar_TX();
                return -1;
            }
            finally
            {
                Close();
            }
            
        }
    }
}
