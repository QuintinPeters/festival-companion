namespace Festivalcompanion.Models;

public class Transaction
{
    public enum TransactionStatus
    {

        Successful,
        Failed,
        Pending
}
    
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public TransactionStatus Status { get; set; }
    
    public int WalletId { get; set; }
    public Wallet Wallet { get; set; } = null!;
}