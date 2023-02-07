using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReseñas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioResenas
    {
        [OperationContract]
        List<ReseñaBE> GetAllReseñas();

        [OperationContract]
        List<ReseñaBE> GetAllReseñasRestaurante(Int16 idResta);

        [OperationContract]
        List<ReseñaBE> GetAllReseñasUsuario(Int16 idUsua);

        [OperationContract]
        ReseñaBE GetReseña(Int16 idRese);

        [OperationContract]
        Boolean UpdateReseña(ReseñaBE objReseñaBE, Int16 idRese);

        [OperationContract]
        Boolean InsertReseña(ReseñaBE objReseñaBE, Int16 idUsua, Int16 idResta);

        [OperationContract]
        Boolean DeleteReseña(Int16 idRese);
    }

    [DataContract]
    [Serializable]
    public class ReseñaBE
    {
        private Int16 idReseña;
        private Int16 idUsuario;
        private Int16 idRestaurante;
        private String tituloReseña;
        private String contenidoReseña;
        private DateTime fecRegistroReseña;
        private String nomRestaurante;

        [DataMember]
        public Int16 Id_Reseña
        {
            get { return idReseña; }
            set { idReseña = value; }
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
        public String Titulo_Reseña
        {
            get { return tituloReseña; }
            set { tituloReseña = value; }
        }

        [DataMember]
        public String Contenido_Reseña
        {
            get { return contenidoReseña; }
            set { contenidoReseña = value; }
        }

        [DataMember]
        public DateTime Fecha_RegistroReseña
        {
            get { return fecRegistroReseña; }
            set { fecRegistroReseña = value; }
        }

        [DataMember]
        public String Nom_Restaurante
        {
            get { return nomRestaurante; }
            set { nomRestaurante = value; }
        }
    }
}
