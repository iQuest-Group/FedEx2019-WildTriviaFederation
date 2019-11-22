using System.ComponentModel.DataAnnotations;

namespace FedEx2019.WTF.Models
{
    public class Player
    {
        [Required]
        [StringLength(16, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
}
