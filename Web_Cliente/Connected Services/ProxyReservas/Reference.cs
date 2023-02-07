﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Cliente.ProxyReservas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyReservas.IServicioReservas")]
    public interface IServicioReservas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasCliente", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasClienteResponse")]
        ServiciosWCF.ReservaBE[] GetAllReservasCliente(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasCliente", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasClienteResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasClienteAsync(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasPorDia", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaResponse")]
        ServiciosWCF.ReservaBE[] GetAllReservasPorDia(System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasPorDia", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasPorDiaAsync(System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaRestauranteResponse")]
        ServiciosWCF.ReservaBE[] GetAllReservasPorDiaRestaurante(System.DateTime fecha, short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasPorDiaRestauranteResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasPorDiaRestauranteAsync(System.DateTime fecha, short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/InsertReserva", ReplyAction="http://tempuri.org/IServicioReservas/InsertReservaResponse")]
        bool InsertReserva(ServiciosWCF.ReservaBE objReservaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/InsertReserva", ReplyAction="http://tempuri.org/IServicioReservas/InsertReservaResponse")]
        System.Threading.Tasks.Task<bool> InsertReservaAsync(ServiciosWCF.ReservaBE objReservaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/CancelReserva", ReplyAction="http://tempuri.org/IServicioReservas/CancelReservaResponse")]
        bool CancelReserva(short idUsua, short idReser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/CancelReserva", ReplyAction="http://tempuri.org/IServicioReservas/CancelReservaResponse")]
        System.Threading.Tasks.Task<bool> CancelReservaAsync(short idUsua, short idReser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasRestauranteResponse")]
        ServiciosWCF.ReservaBE[] GetAllReservasRestaurante(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetAllReservasRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetAllReservasRestauranteResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasRestauranteAsync(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/UpdateEstadoReserva", ReplyAction="http://tempuri.org/IServicioReservas/UpdateEstadoReservaResponse")]
        void UpdateEstadoReserva(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/UpdateEstadoReserva", ReplyAction="http://tempuri.org/IServicioReservas/UpdateEstadoReservaResponse")]
        System.Threading.Tasks.Task UpdateEstadoReservaAsync(short idUsua);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetTopUsuariosReservasRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetTopUsuariosReservasRestauranteResponse")]
        ServiciosWCF.ReservaBE[] GetTopUsuariosReservasRestaurante(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetTopUsuariosReservasRestaurante", ReplyAction="http://tempuri.org/IServicioReservas/GetTopUsuariosReservasRestauranteResponse")]
        System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetTopUsuariosReservasRestauranteAsync(short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetCantPersonasReservas", ReplyAction="http://tempuri.org/IServicioReservas/GetCantPersonasReservasResponse")]
        short GetCantPersonasReservas(System.DateTime fecha, short idResta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReservas/GetCantPersonasReservas", ReplyAction="http://tempuri.org/IServicioReservas/GetCantPersonasReservasResponse")]
        System.Threading.Tasks.Task<short> GetCantPersonasReservasAsync(System.DateTime fecha, short idResta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioReservasChannel : Web_Cliente.ProxyReservas.IServicioReservas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioReservasClient : System.ServiceModel.ClientBase<Web_Cliente.ProxyReservas.IServicioReservas>, Web_Cliente.ProxyReservas.IServicioReservas {
        
        public ServicioReservasClient() {
        }
        
        public ServicioReservasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioReservasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReservasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReservasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiciosWCF.ReservaBE[] GetAllReservasCliente(short idUsua) {
            return base.Channel.GetAllReservasCliente(idUsua);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasClienteAsync(short idUsua) {
            return base.Channel.GetAllReservasClienteAsync(idUsua);
        }
        
        public ServiciosWCF.ReservaBE[] GetAllReservasPorDia(System.DateTime fecha) {
            return base.Channel.GetAllReservasPorDia(fecha);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasPorDiaAsync(System.DateTime fecha) {
            return base.Channel.GetAllReservasPorDiaAsync(fecha);
        }
        
        public ServiciosWCF.ReservaBE[] GetAllReservasPorDiaRestaurante(System.DateTime fecha, short idResta) {
            return base.Channel.GetAllReservasPorDiaRestaurante(fecha, idResta);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasPorDiaRestauranteAsync(System.DateTime fecha, short idResta) {
            return base.Channel.GetAllReservasPorDiaRestauranteAsync(fecha, idResta);
        }
        
        public bool InsertReserva(ServiciosWCF.ReservaBE objReservaBE) {
            return base.Channel.InsertReserva(objReservaBE);
        }
        
        public System.Threading.Tasks.Task<bool> InsertReservaAsync(ServiciosWCF.ReservaBE objReservaBE) {
            return base.Channel.InsertReservaAsync(objReservaBE);
        }
        
        public bool CancelReserva(short idUsua, short idReser) {
            return base.Channel.CancelReserva(idUsua, idReser);
        }
        
        public System.Threading.Tasks.Task<bool> CancelReservaAsync(short idUsua, short idReser) {
            return base.Channel.CancelReservaAsync(idUsua, idReser);
        }
        
        public ServiciosWCF.ReservaBE[] GetAllReservasRestaurante(short idResta) {
            return base.Channel.GetAllReservasRestaurante(idResta);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetAllReservasRestauranteAsync(short idResta) {
            return base.Channel.GetAllReservasRestauranteAsync(idResta);
        }
        
        public void UpdateEstadoReserva(short idUsua) {
            base.Channel.UpdateEstadoReserva(idUsua);
        }
        
        public System.Threading.Tasks.Task UpdateEstadoReservaAsync(short idUsua) {
            return base.Channel.UpdateEstadoReservaAsync(idUsua);
        }
        
        public ServiciosWCF.ReservaBE[] GetTopUsuariosReservasRestaurante(short idResta) {
            return base.Channel.GetTopUsuariosReservasRestaurante(idResta);
        }
        
        public System.Threading.Tasks.Task<ServiciosWCF.ReservaBE[]> GetTopUsuariosReservasRestauranteAsync(short idResta) {
            return base.Channel.GetTopUsuariosReservasRestauranteAsync(idResta);
        }
        
        public short GetCantPersonasReservas(System.DateTime fecha, short idResta) {
            return base.Channel.GetCantPersonasReservas(fecha, idResta);
        }
        
        public System.Threading.Tasks.Task<short> GetCantPersonasReservasAsync(System.DateTime fecha, short idResta) {
            return base.Channel.GetCantPersonasReservasAsync(fecha, idResta);
        }
    }
}
