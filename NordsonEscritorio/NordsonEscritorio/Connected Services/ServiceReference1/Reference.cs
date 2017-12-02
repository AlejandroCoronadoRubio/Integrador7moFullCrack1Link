﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NordsonEscritorio.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarCliente", ReplyAction="http://tempuri.org/IService1/RegistrarClienteResponse")]
        bool RegistrarCliente(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarCliente", ReplyAction="http://tempuri.org/IService1/RegistrarClienteResponse")]
        System.Threading.Tasks.Task<bool> RegistrarClienteAsync(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarUsuario", ReplyAction="http://tempuri.org/IService1/RegistrarUsuarioResponse")]
        bool RegistrarUsuario(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarUsuario", ReplyAction="http://tempuri.org/IService1/RegistrarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> RegistrarUsuarioAsync(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoggearUsuario", ReplyAction="http://tempuri.org/IService1/LoggearUsuarioResponse")]
        bool LoggearUsuario(int numeroEmpleado, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoggearUsuario", ReplyAction="http://tempuri.org/IService1/LoggearUsuarioResponse")]
        System.Threading.Tasks.Task<bool> LoggearUsuarioAsync(int numeroEmpleado, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoggearCliente", ReplyAction="http://tempuri.org/IService1/LoggearClienteResponse")]
        bool LoggearCliente(int numeroEmpleado, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoggearCliente", ReplyAction="http://tempuri.org/IService1/LoggearClienteResponse")]
        System.Threading.Tasks.Task<bool> LoggearClienteAsync(int numeroEmpleado, string Contrasena);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : NordsonEscritorio.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<NordsonEscritorio.ServiceReference1.IService1>, NordsonEscritorio.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegistrarCliente(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado) {
            return base.Channel.RegistrarCliente(Nombre, Contrasena, Cargo, Turno, noEmpleado);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarClienteAsync(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado) {
            return base.Channel.RegistrarClienteAsync(Nombre, Contrasena, Cargo, Turno, noEmpleado);
        }
        
        public bool RegistrarUsuario(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado) {
            return base.Channel.RegistrarUsuario(Nombre, Contrasena, Cargo, Turno, noEmpleado);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarUsuarioAsync(string Nombre, string Contrasena, string Cargo, int Turno, int noEmpleado) {
            return base.Channel.RegistrarUsuarioAsync(Nombre, Contrasena, Cargo, Turno, noEmpleado);
        }
        
        public bool LoggearUsuario(int numeroEmpleado, string Contrasena) {
            return base.Channel.LoggearUsuario(numeroEmpleado, Contrasena);
        }
        
        public System.Threading.Tasks.Task<bool> LoggearUsuarioAsync(int numeroEmpleado, string Contrasena) {
            return base.Channel.LoggearUsuarioAsync(numeroEmpleado, Contrasena);
        }
        
        public bool LoggearCliente(int numeroEmpleado, string Contrasena) {
            return base.Channel.LoggearCliente(numeroEmpleado, Contrasena);
        }
        
        public System.Threading.Tasks.Task<bool> LoggearClienteAsync(int numeroEmpleado, string Contrasena) {
            return base.Channel.LoggearClienteAsync(numeroEmpleado, Contrasena);
        }
    }
}
