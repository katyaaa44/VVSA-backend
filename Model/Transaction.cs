namespace VVSA_backend.Model;

public class Transaction
{
    public int TransactionId { set; get; }
    public string Fullname {set; get; }
    public TransactionType TransactionType { set; get; }
    public string AccountNumber { set; get; }
    public string BankCode { set; get; }
    public DateTime IssueDate { set; get; }
    public decimal Amount { set; get; }

}

public enum TransactionType
{
    Incoming = 0,
    Outgoing = 1,
    Withdraw = 2,
}