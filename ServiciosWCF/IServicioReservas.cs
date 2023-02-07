using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReservas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReservas
    {
        [OperationContract]
        List<ReservaBE> GetAllReservasCliente(Int16 idUsua);

        [OperationContract]
        List<ReservaBE> GetAllReservasPorDia(DateTime fecha);

        [OperationContract]
        List<ReservaBE> GetAllReservasPorDiaRestaurante(DateTime fecha, Int16 idResta);

        [OperationContract]
        Boolean InsertReserva(ReservaBE objReservaBE);

        [OperationContract]
        Boolean CancelReserva(Int16 idUsua, Int16 idReser);

        [OperationContract]
        List<ReservaBE> GetAllReservasRestaurante(Int16 idResta);

        [OperationContract]
        void UpdateEstadoReserva(Int16 idUsua);

        [OperationContract]
        List<ReservaBE> GetTopUsuariosReservasRestaurante(Int16 idResta);

        [OperationContract]
        Int16 GetCantPersonasReservas(DateTime fecha, Int16 idResta);
    }

    [DataContract]
    [Serializable]
    public class ReservaBE
    {
        private Int16 idReserva;
        private Int16 idUsuario;
        private Int16 idRestaurante;
        private DateTime fechaReserva;
        private Int16 cantPersonas;
        private String estadoReserva;
        private String nomRestaurante;
        private String direcRestaurante;
        private String nomDistritoRestaurante;

        private String usuaDni;
        private String usuaCorreo;
        private String usuaNombre;
        private String usuaApellido;

        private Int16 cantVeces;


        [DataMember]
        public Int16 Id_Reserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        [DataMember]
        public Int16 Id_Usuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        [DataMember]
        public Int16 Id_Restaurante
        {
            get { return idRestaurante; }
            set { idRestaurante = value; }
        }

        [DataMember]
        public DateTime Fecha_Reserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; }
        }

        [DataMember]
        public Int16 Cant_Personas
        {
            get { return cantPersonas; }
            set { cantPersonas = value; }
        }

        [DataMember]
        public String Estado_Reserva
        {
            get { return estadoReserva; }
            set { estadoReserva = value; }
        }

        [DataMember]
        public String Nom_Restaurante
        {
            get { return nomRestaurante; }
            set { nomRestaurante = value; }
        }

        [DataMember]
        public String Direc_Restaurante
        {
            get { return direcRestaurante; }
            set { direcRestaurante = value; }
        }

        [DataMember]
        public String Nom_DistritoRestaurante
        {
            get { return nomDistritoRestaurante; }
            set { nomDistritoRestaurante = value; }
        }

        [DataMember]
        public String Usua_Dni
        {
            get { return usuaDni; }
            set { usuaDni = value; }
        }

        [DataMember]
        public String Usua_Correo
        {
            get { return usuaCorreo; }
            set { usuaCorreo = value; }
        }

        [DataMember]
        public String Usua_Nombre
        {
            get { return usuaNombre; }
            set { usuaNombre = value; }
        }

        [DataMember]
        public String Usua_Apellido
        {
            get { return usuaApellido; }
            set { usuaApellido = value; }
        }

        [DataMember]
        public Int16 Cant_Veces
        {
            get { return cantVeces; }
            set { cantVeces = value; }
        }

    }
}
