namespace VVSA_backend.ViewModel;

public class TransactionViewModel
{
    public decimal TransactionId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public TransactionType TransactionType { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public string BankCode { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
    public decimal Amount { get; set; }
}
