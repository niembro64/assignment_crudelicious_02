using System;
using System.ComponentModel.DataAnnotations;

namespace assignment_crudelicious_02.Models
{

  public class Pet
  {

    [Key]
    public int PetId { get; set; }

    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Species { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }

}