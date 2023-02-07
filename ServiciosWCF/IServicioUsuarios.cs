using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuarios
    {
        [OperationContract]
        UsuarioBE GetUsuario(String correo);
    }

    [DataContract]
    [Serializable]
    public class UsuarioBE
    {
        private Int16 idUsuario;
        private String correoUsuario;
        private String contraUsuario;
        private String dniUsuario;
        private String nomUsuario;
        private String apeUsuario;
        private String teleUsuario;
        private DateTime naciUsuario;
        private Int16 nivelUsuario;
        private DateTime fecRegistroUsuario;

        [DataMember]
        public Int16 Id_Usuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        [DataMember]
        public String Correo_Usuario
        {
            get { return correoUsuario; }
            set { correoUsuario = value; }
        }

        [DataMember]
        public String Contra_Usuario
        {
            get { return contraUsuario; }
            set { contraUsuario = value; }
        }

        [DataMember]
        public String Dni_Usuario
        {
            get { return dniUsuario; }
            set { dniUsuario = value; }
        }

        [DataMember]
        public String Nom_Usuario
        {
            get { return nomUsuario; }
            set { nomUsuario = value; }
        }

        [DataMember]
        public String Ape_Usuario
        {
            get { return apeUsuario; }
            set { apeUsuario = value; }
        }

        [DataMember]
        public String Tele_Usuario
        {
            get { return teleUsuario; }
            set { teleUsuario = value; }
        }

        [DataMember]
        public DateTime Naci_Usuario
        {
            get { return naciUsuario; }
            set { naciUsuario = value; }
        }

        [DataMember]
        public Int16 Nivel_Usuario
        {
            get { return nivelUsuario; }
            set { nivelUsuario = value; }
        }

        [DataMember]
        public DateTime FecRegistro_Usuario
        {
            get { return fecRegistroUsuario; }
            set { fecRegistroUsuario = value; }
        }
    }
}
