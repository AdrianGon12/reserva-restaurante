using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRestaurantes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioRestaurantes
    {
        [OperationContract]
        List<RestauranteBE> GetAllRestaurantes();

        [OperationContract]
        List<RestauranteBE> GetAllRestaurantesActivo();

        [OperationContract]
        RestauranteBE GetRestaurante(Int16 idResta);

        [OperationContract]
        Boolean InsertRestaurante(RestauranteBE objRestauranteBE);

        [OperationContract]
        Boolean UpdateRestaurante(RestauranteBE objRestauranteBE);

        [OperationContract]
        List<RestauranteBE> GetAllRestaurantesPorDistrito(Int16 idDistri);

        [OperationContract]
        List<RestauranteBE> GetAllRestaurantesPorCategoria(Int16 idCate);

        [OperationContract]
        List<RestauranteBE> GetAllRestaurantesPorCategoriaDistrito(Int16 idCate, Int16 idDistri);

        [OperationContract]
        List<RestauranteBE> GetAllDistritos();

        [OperationContract]
        List<RestauranteBE> GetAllCategorias();
    }

    [DataContract]
    [Serializable]
    public class RestauranteBE
    {
        private Int16 idRestaurante;
        private Int16 cateRestaurante;
        private Int16 distriRestaurante;
        private String nomRestaurante;
        private String direcRestaurante;
        private String teleRestaurante;
        private DateTime fecRegistroRestaurante;
        private String usuRegistroRestaurante;
        private DateTime fecUltModiRestaurante;
        private String usuUltModiRestaurante;
        private Int16 estadoRestaurante;

        private String nomCategoriaRestaurante;
        private String nomDistritoRestaurante;
        private String nomEstadoRestaurante;

        [DataMember]
        public Int16 Id_Restaurante
        {
            get { return idRestaurante; }
            set { idRestaurante = value; }
        }

        [DataMember]
        public Int16 Cate_Restaurante
        {
            get { return cateRestaurante; }
            set { cateRestaurante = value; }
        }

        [DataMember]
        public Int16 Distri_Restaurante
        {
            get { return distriRestaurante; }
            set { distriRestaurante = value; }
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
        public String Tele_Restaurante
        {
            get { return teleRestaurante; }
            set { teleRestaurante = value; }
        }

        [DataMember]
        public DateTime FecRegistro_Restaurante
        {
            get { return fecRegistroRestaurante; }
            set { fecRegistroRestaurante = value; }
        }

        [DataMember]
        public String UsuRegistro_Restaurante
        {
            get { return usuRegistroRestaurante; }
            set { usuRegistroRestaurante = value; }
        }

        [DataMember]
        public DateTime FecUltModi_Restaurante
        {
            get { return fecUltModiRestaurante; }
            set { fecUltModiRestaurante = value; }
        }

        [DataMember]
        public String UsuUltModi_Restaurante
        {
            get { return usuUltModiRestaurante; }
            set { usuUltModiRestaurante = value; }
        }

        [DataMember]
        public Int16 Estado_Restaurante
        {
            get { return estadoRestaurante; }
            set { estadoRestaurante = value; }
        }

        [DataMember]
        public String Nom_CategoriaRestaurante
        {
            get { return nomCategoriaRestaurante; }
            set { nomCategoriaRestaurante = value; }
        }

        [DataMember]
        public String Nom_DistritoRestaurante
        {
            get { return nomDistritoRestaurante; }
            set { nomDistritoRestaurante = value; }
        }

        [DataMember]
        public String Nom_EstadoRestaurante
        {
            get { return nomEstadoRestaurante; }
            set { nomEstadoRestaurante = value; }
        }
    }
}
