namespace Festivalcompanion.Models;

public class Wristband
{
    public enum status
    {
        
    }
    
    public int Id { get; set; }
    public string NfcUid { get; set; }
    public status Status {get; set;}
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;

}