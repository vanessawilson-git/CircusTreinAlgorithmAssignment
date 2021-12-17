using System.ComponentModel.DataAnnotations;
using Logic;
using Logic.Classes;

namespace CircusTreinView.Models
{
    public class AnimalModel 
    {
        public int Id { get; set; }

        public int OwnerId { get; internal set; }

        [StringLength(maximumLength: 255, ErrorMessage = "Password must be between 1 and 255 characters long.", MinimumLength = 1)]
        [Required] 
        public string Name { get; set; }

        [Required] public Diet Diet { get; set; }

        [Required] public Size Size { get; set; }


    }
}