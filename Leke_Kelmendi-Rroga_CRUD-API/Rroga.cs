using System.ComponentModel.DataAnnotations;

namespace Leke_Kelmendi_Rroga_CRUD_API
{
    public class Rroga
    {
        [Key]
        public int ID_Puntori { get; set; }
        public String Emri_Puntorit { get; set; } = string.Empty;
        public String Mbiemri_Puntorit { get; set; } = string.Empty;
        public String Kompania { get; set; } = string.Empty;
        public String Pozita_Punes { get; set; } = string.Empty;    
        public double Rroga_Puntorit { get; set; }  



    }
}
