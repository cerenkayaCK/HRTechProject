using ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Entities
{
    public class Adres : BaseEntity
    {
        public string Il { get; set; } = null!;
        public string Ilce { get; set; } = null!;
        public string Mahalle { get; set; } = null!;
        public string Sokak { get; set;} = null!;
        public int KapiNo { get; set; }
        public int DaireNo { get; set; }
        public List<Personel> Personeller { get; set; } = new();

    }
}
