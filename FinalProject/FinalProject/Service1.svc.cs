using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FinalProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {


        public bool RegistrarCliente(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado)
        {
            try
            {
                NordsonEntities db = new NordsonEntities();

                clientes clientes = new clientes
                {
                    nombre = Nombre,
                    contrasena = Contrasena,
                    cargo = Cargo,
                    turno = Turno,
                    numeroEmpleado=noEmpleado
                };
                db.clientes.Add(clientes);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
                   
        }

        public bool RegistrarUsuario(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado)
        {
            try
            {
                NordsonEntities db = new NordsonEntities();
                usuarios usuarios = new usuarios
                {
                    nombre = Nombre,
                    contrasena = Contrasena,
                    cargo = Cargo,
                    turno = Turno,
                    numeroEmpleado = noEmpleado
                };
                db.usuarios.Add(usuarios);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }



        }

        public bool LoggearUsuario(int numeroEmpleado, string Contrasena)
        {
            bool status = false;
            try
            {
                NordsonEntities db = new NordsonEntities();
                usuarios user = db.usuarios.Where(x => x.numeroEmpleado == numeroEmpleado).FirstOrDefault();

                if (user != null)
                {
                    if (user.contrasena == Contrasena)
                    {
                        status = true;
                    }
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception)
            {
                return false;

            }

            return status;
        }

        public bool LoggearCliente(int numeroEmpleado, string Contrasena)
        {
            bool status = false;
            try
            {
                NordsonEntities db = new NordsonEntities();
                clientes clie = db.clientes.Where(x => x.numeroEmpleado == numeroEmpleado).FirstOrDefault();

                if (clie != null)
                {
                    if (clie.contrasena == Contrasena)
                    {
                        status = true;
                    }
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception)
            {
                return false;

            }

            return status;
        }
    }
}