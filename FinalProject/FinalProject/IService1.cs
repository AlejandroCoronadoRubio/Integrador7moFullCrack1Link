using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FinalProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "registrar-cliente/",
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool RegistrarCliente(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "registrar-usuario/",
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool RegistrarUsuario(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "loggear-usuario/",
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool LoggearUsuario(int numeroEmpleado, string Contrasena);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "loggear-cliente/",
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool LoggearCliente(int numeroEmpleado, string Contrasena);

    }
}
