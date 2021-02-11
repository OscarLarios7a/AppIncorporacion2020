using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFamiliasIncorporacion.Logica
{
    class lFamIncorporacion
    {
        //creacion del constructor
        public lFamIncorporacion() { }
        //Declaracion de las variables de entorno
        private int IdIncorporacion;
        private int FamiliaId;
        private string FolioEncuesta;
        private string Tutora;
        private string TutoraPaterno;
        private string TutoraMaterno;
        private string TutoraCurp;
        private string FolioAvisoCobro;
        private string ObsCris;
        private string ObsNoti;
        private string ObsAviso;

        //Declaracion de Procedimientos
        public int idIncorporacion { get { return IdIncorporacion; } set { IdIncorporacion = value; } }
        public int familiaId { get { return FamiliaId; } set { FamiliaId = value; } }
        public string folioEncuesta { get { return FolioEncuesta; } set { FolioEncuesta = value; } }
        public string tutora { get { return Tutora; } set { Tutora = value; } }
        public string tutoraPaterno { get { return TutoraPaterno; } set { TutoraPaterno = value; } }
        public string tutoraMaterno { get { return TutoraMaterno; } set { TutoraMaterno = value; } }
        public string tutoraCurp { get { return TutoraCurp; } set { TutoraCurp = value; } }
        public string folioAvisoCobro { get { return FolioAvisoCobro; } set { FolioAvisoCobro = value; } }
        public string obsCris { get { return ObsCris; } set { ObsCris = value; } }
        public string obsNoti { get { return ObsNoti; } set { ObsNoti = value; } }
        public string obsAviso { get { return ObsAviso; } set { ObsAviso = value; } }
  
        //ahora se pasan los valores de las valiables a los procedimientos
        public lFamIncorporacion(int IdIncorporacion, int FamiliaId, string FolioEncuesta, string Tutora, string TutoraPaterno, string TutoraMaterno, string TutoraCurp, string FolioAvisoCobro, string ObsCris, string ObsNoti, string ObsAviso)
        {
            idIncorporacion= IdIncorporacion;
            familiaId=FamiliaId;
            folioEncuesta=FolioEncuesta;
            tutora=Tutora;
            tutoraPaterno= TutoraPaterno;
            tutoraMaterno=TutoraMaterno;
            tutoraCurp=TutoraCurp;
            folioAvisoCobro=FolioAvisoCobro;
            obsCris=ObsCris;
            obsNoti=ObsNoti;
            obsAviso = ObsAviso;
    }

    }
}
