//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Cliente.ProxyUsuarios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyUsuarios.IServicioUsuarios")]
    public interface IServicioUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/GetUsuario", ReplyAction="http://tempuri.org/IServicioUsuarios/GetUsuarioResponse")]
        ServiciosWCF.UsuarioBE GetUsuario(string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/GetUsuario", ReplyAction="http://tempuri.org/IServicioUsuarios/GetUsuarioResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.UsuarioBE> GetUsuarioAsync(string correo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioUsuariosChannel : Web_Cliente.ProxyUsuarios.IServicioUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUsuariosClient : System.ServiceModel.ClientBase<Web_Cliente.ProxyUsuarios.IServicioUsuarios>, Web_Cliente.ProxyUsuarios.IServicioUsuarios {
        
        public ServicioUsuariosClient() {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiciosWCF.UsuarioBE GetUsuario(string correo) {
            return base.Channel.GetUsuario(correo);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.UsuarioBE> GetUsuarioAsync(string correo) {
            return base.Channel.GetUsuarioAsync(correo);
        }
    }
}
