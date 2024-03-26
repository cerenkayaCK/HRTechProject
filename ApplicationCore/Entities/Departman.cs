using ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRTechProject.Entities
{
    public class Departman : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public List<Meslek> Meslekler { get; set; } = [];
        public List<Sirket> Sirketler { get; set; } = [];
    }
}
