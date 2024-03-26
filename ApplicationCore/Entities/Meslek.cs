using ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Entities
{
    public class Meslek : BaseEntity
    {

        public string Ad { get; set; } = null!;
        public List<Personel> Personeller { get; set; } = [];
        public List<Departman> Departmanlar { get; set; } = [];
    }
}
