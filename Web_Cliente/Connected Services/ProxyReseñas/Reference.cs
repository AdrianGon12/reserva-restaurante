//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Cliente.ProxyReseñas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyReseñas.IServicioReseñas")]
    public interface IServicioReseñas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetAllReseñasRestaurante", ReplyAction="http://tempuri.org/IServicioReseñas/GetAllReseñasRestauranteResponse")]
        ServiciosWCF.ReseñaBE[] GetAllReseñasRestaurante(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetAllReseñasRestaurante", ReplyAction="http://tempuri.org/IServicioReseñas/GetAllReseñasRestauranteResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE[]> GetAllReseñasRestauranteAsync(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetAllReseñasUsuario", ReplyAction="http://tempuri.org/IServicioReseñas/GetAllReseñasUsuarioResponse")]
        ServiciosWCF.ReseñaBE[] GetAllReseñasUsuario(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetAllReseñasUsuario", ReplyAction="http://tempuri.org/IServicioReseñas/GetAllReseñasUsuarioResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE[]> GetAllReseñasUsuarioAsync(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetReseña", ReplyAction="http://tempuri.org/IServicioReseñas/GetReseñaResponse")]
        ServiciosWCF.ReseñaBE GetReseña(short idRese);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/GetReseña", ReplyAction="http://tempuri.org/IServicioReseñas/GetReseñaResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE> GetReseñaAsync(short idRese);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/UpdateReseña", ReplyAction="http://tempuri.org/IServicioReseñas/UpdateReseñaResponse")]
        bool UpdateReseña(ServiciosWCF.ReseñaBE objReseñaBE, short idRese);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/UpdateReseña", ReplyAction="http://tempuri.org/IServicioReseñas/UpdateReseñaResponse")]
        System.Threading.Tasks.Task<bool> UpdateReseñaAsync(ServiciosWCF.ReseñaBE objReseñaBE, short idRese);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/InsertReseña", ReplyAction="http://tempuri.org/IServicioReseñas/InsertReseñaResponse")]
        bool InsertReseña(ServiciosWCF.ReseñaBE objReseñaBE, short idUsua, short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/InsertReseña", ReplyAction="http://tempuri.org/IServicioReseñas/InsertReseñaResponse")]
        System.Threading.Tasks.Task<bool> InsertReseñaAsync(ServiciosWCF.ReseñaBE objReseñaBE, short idUsua, short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/DeleteReseña", ReplyAction="http://tempuri.org/IServicioReseñas/DeleteReseñaResponse")]
        bool DeleteReseña(short idRese);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReseñas/DeleteReseña", ReplyAction="http://tempuri.org/IServicioReseñas/DeleteReseñaResponse")]
        System.Threading.Tasks.Task<bool> DeleteReseñaAsync(short idRese);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioReseñasChannel : Web_Cliente.ProxyReseñas.IServicioReseñas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioReseñasClient : System.ServiceModel.ClientBase<Web_Cliente.ProxyReseñas.IServicioReseñas>, Web_Cliente.ProxyReseñas.IServicioReseñas {
        
        public ServicioReseñasClient() {
        }
        
        public ServicioReseñasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioReseñasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReseñasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReseñasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiciosWCF.ReseñaBE[] GetAllReseñasRestaurante(short idResta) {
            return base.Channel.GetAllReseñasRestaurante(idResta);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE[]> GetAllReseñasRestauranteAsync(short idResta) {
            return base.Channel.GetAllReseñasRestauranteAsync(idResta);
        }
        
        public ServiciosWCF.ReseñaBE[] GetAllReseñasUsuario(short idUsua) {
            return base.Channel.GetAllReseñasUsuario(idUsua);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE[]> GetAllReseñasUsuarioAsync(short idUsua) {
            return base.Channel.GetAllReseñasUsuarioAsync(idUsua);
        }
        
        public ServiciosWCF.ReseñaBE GetReseña(short idRese) {
            return base.Channel.GetReseña(idRese);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReseñaBE> GetReseñaAsync(short idRese) {
            return base.Channel.GetReseñaAsync(idRese);
        }
        
        public bool UpdateReseña(ServiciosWCF.ReseñaBE objReseñaBE, short idRese) {
            return base.Channel.UpdateReseña(objReseñaBE, idRese);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateReseñaAsync(ServiciosWCF.ReseñaBE objReseñaBE, short idRese) {
            return base.Channel.UpdateReseñaAsync(objReseñaBE, idRese);
        }
        
        public bool InsertReseña(ServiciosWCF.ReseñaBE objReseñaBE, short idUsua, short idResta) {
            return base.Channel.InsertReseña(objReseñaBE, idUsua, idResta);
        }
        
        public System.Threading.Tasks.Task<bool> InsertReseñaAsync(ServiciosWCF.ReseñaBE objReseñaBE, short idUsua, short idResta) {
            return base.Channel.InsertReseñaAsync(objReseñaBE, idUsua, idResta);
        }
        
        public bool DeleteReseña(short idRese) {
            return base.Channel.DeleteReseña(idRese);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteReseñaAsync(short idRese) {
            return base.Channel.DeleteReseñaAsync(idRese);
        }
    }
}
