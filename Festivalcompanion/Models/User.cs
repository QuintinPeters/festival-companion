using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Festivalcompanion.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    
    [NotMapped]
    [Required(ErrorMessage = "Herhaal je wachtwoord.")]
    [Compare(nameof(Password), ErrorMessage = "De wachtwoorden komen niet overeen.")]
    public string ConfirmPassword { get; set; } = string.Empty;
    public bool Verified { get; set; }
    
}