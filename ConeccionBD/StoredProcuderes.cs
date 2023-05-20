using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace Gestion_Alquiler_Canchas.ConeccionBD
{
    public class StoredProcuderes
    {
        ConexionBD conexion = new ConexionBD();
        SqlCommand comandoQuery = new SqlCommand();
        
        
        public bool SP_ValidadLogin(string usuario, string contraseña)
        {

           
            using (SqlCommand command = new SqlCommand("ValidarLogin", conexion.abrirBd()))
            {
                try
                {
                    // Especificar que el comando es un procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros de entrada
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contraseña);

                    String mensaje =(string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);
                    if (mensaje == "Login exitoso")
                        return true;
                    else
                        return false;
                                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error con la base de datos: /n" + ex);
                     throw;
                }
                finally
                {
                    conexion.cerrarBD();
                }
                

            }

           

        }

        public void BuscarClientePorCarnet(string carnet , DataGridView dataGrid)
        {
            using (SqlCommand command = new SqlCommand("BuscarClientePorCarnet", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                        command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@carnet", carnet);

                    resultado = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(resultado);
                    dataGrid.DataSource = table;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                }
                finally
                {
                    conexion.cerrarBD();
                }
              
            }
        }
        //sobrecarga
        public DataTable BuscarClientePorCarnet(string carnet)
        {
            using (SqlCommand command = new SqlCommand("BuscarClientePorCarnet", conexion.abrirBd()))
            {
                SqlDataReader resultado;
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@carnet", carnet);

                    resultado = command.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(resultado);
                    return tabla;
                    
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e);
                    return null;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }

        public bool AgregarNuevoCliente(string nombre, string apellido, string carnet, string email, string telefono)
        {
            using (SqlCommand command = new SqlCommand("AgregarNuevoCliente", conexion.abrirBd()))
            {
                try
                {
                    command.CommandType=CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombre",nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@telefono", telefono);

                    String mensaje = (string)command.ExecuteScalar();

                    MessageBox.Show(mensaje);

                    if (mensaje == "NUEVO USUARIO GUARDADO EXITOSAMENTE")
                        return true;
                    else
                        return false;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }            
            
        }
        public bool modificarCliente(string nombre, string apellido, string carnet, string email, string telefono, string buscar)
        {
            using (SqlCommand command = new SqlCommand("ModificarCliente", conexion.abrirBd()))
            {
                try {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@carnet", carnet);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@buscar", buscar);

                String mensaje = (string)command.ExecuteScalar();

                MessageBox.Show(mensaje);

                if (mensaje == "CLIENTE ACTUALIZADO CORRECTAMENTE")
                    return true;
                else
                    return false;


            }
                catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex);
                throw ex;
            }
            finally
            {
                conexion.cerrarBD();
            }

        }
        }
        public bool EliminarCliente (string carnet)
        {
            using (SqlCommand command = new SqlCommand("EliminarCliente", conexion.abrirBd()))
            {
                try
                {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("carnet", carnet);

                        String mensaje = (string)command.ExecuteScalar();

                        MessageBox.Show(mensaje);

                        if (mensaje == "CLIENTE ELIMINADO CORRECTAMENTE")
                            return true;
                        else
                            return false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR VUELVA A INTERLO" + ex);
                    throw ex;
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
            
        }
    }
}

