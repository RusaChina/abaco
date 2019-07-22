using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Abaco.Models;
using System.Linq;

namespace Abaco.Repository
{
    public class UsuarioRepositorio
    {
        private SQLiteConnection con;
        private static UsuarioRepositorio instancia;
        public static UsuarioRepositorio Instancia
        {
            get
            {
                if (instancia == null)
                    throw new Exception("Debe llamar al iniciador");
                return instancia;
            }
        }

        public static void Inicializador(String filename)
        {
            if (filename == null)
                throw new ArgumentNullException();
            if (instancia != null)
                instancia.con.Close();
            instancia = new UsuarioRepositorio(filename);
        }

        private UsuarioRepositorio(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Usuario>();
        }

        public String EstadoMensaje;

        public int AddNewUsuario(String nombre, String apellido, String zona, String numero, String password, String correo)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Usuario()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Zona = zona,
                    Numero = numero,
                    Password = password,
                    Correo = correo,
                    
                });

                EstadoMensaje = string.Format("Cantidad de filaz afectadas:{0}", result);
            }catch (Exception e)
            {
                EstadoMensaje = e.Message;
            } 
                return result;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            try
            {
                return con.Table<Usuario>();

            }catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Usuario>();
        }


    }

}

