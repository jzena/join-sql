using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;


namespace JoinSQL
{
    public class DALSQLNative
    {
        private const string ConstFilterStackFrame = "WebTraining";//el mismo filtro existe en PageBase.
        public const string ConstNetSqlClientDataProvider = ".Net SqlClient Data Provider";
        public const int ConstErrorInConnectToBD = 18456;

        SqlConnection _conexion = null;
        SqlCommand _comando;
        SqlTransaction _transaccion = null;
        SqlParameter _param;
        SqlDataAdapter _adapter;
        DataTable dt;
        public string Cadenaconexion;

        public DALSQLNative()
        {
            //configurar();
        }

        public DALSQLNative(string Cadena)
        {
            this.Cadenaconexion = Cadena;
        }


        public SqlConnection conexion()
        {
            return _conexion;
        }

        public SqlTransaction transaccion()
        {
            return _transaccion;
        }

        public SqlConnection conectar()
        {
            _conexion = new SqlConnection(Cadenaconexion);
            if (_conexion.State.Equals(ConnectionState.Closed))
            {
                _conexion.Open();
            }
            return _conexion;
        }

        public void Desconectar()
        {
            if (_conexion.State.Equals(ConnectionState.Open))
            {
                _conexion.Close();
            }
        }

        public void Iniciarcomando()
        {
            _comando = new SqlCommand();

            if (_transaccion == null)
            {
                _comando.Transaction = _transaccion;
            }
        }

        public SqlCommand crearComando(string NomProcedure)
        {
            _comando = new SqlCommand(NomProcedure, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            if (_transaccion != null)
            {
                _comando.Transaction = _transaccion;
            }
            return _comando;
        }

        public SqlCommand crearComandoText(string SQLTEXT)
        {
            _comando = new SqlCommand();
            _comando.CommandText = SQLTEXT;
            _comando.Connection = _conexion;
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        public void ejecutarComandoNonQuery()
        {
            _comando.ExecuteNonQuery();
        }

        public long ExecuteCommandSQLText(string prmSQLText)
        {
            DALSQLNative bd = new DALSQLNative();
            long Result = 0;
            try
            {
                bd.conectar();
                bd.crearComandoText(prmSQLText);
                bd.ejecutarComandoNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bd.Desconectar();
            }
            return Result;
        }


        /// <summary>
        /// Obtiene el mensaje de texto y archivo de acceso a datos así como el método que originó el error.
        /// </summary>
        /// <param name="ex">Se envía el error</param>
        /// <param name="ErrorMessage">Retorna el mensaje de error</param>
        /// <param name="_StackFrame">Retorna el nombre del achivo y método que originó el error</param>
        private void GetErrorInformation(Exception ex, out string ErrorMessage, out StackFrame _StackFrame)
        {
            ErrorMessage = "";
            StackTrace StackTraceError;

            if (ex.InnerException != null)
            {
                ErrorMessage = ex.InnerException.Message;
                StackTraceError = new StackTrace(ex.InnerException, true);
            }
            else
            {
                ErrorMessage = ex.Message;
                StackTraceError = new StackTrace(ex, true);
            }

            //OBTENEMOS LA LISTA DE FRAMES
            List<StackFrame> List = StackTraceError.GetFrames().ToList();

            List<StackFrame> ListNew = new List<StackFrame>();

            //BEGIN: Hacemos la búsqueda de frames que tienen que ver con la aplicación.
            foreach (StackFrame sf in List)
            {
                string FileSF = sf.GetFileName();

                if (FileSF != null && sf.GetFileName().Contains(ConstFilterStackFrame))
                {
                    ListNew.Add(sf);
                }
            }
            //END: Hacemos la búsqueda de frames que tienen que ver con la aplicación.

            _StackFrame = ListNew[0];//MANDAMOS EL PRIMER FRAME PUES LA ÚLTIMA LÍNEA DONDE SE CAYÓ EL CÓDIGO.

        }

    }
}
