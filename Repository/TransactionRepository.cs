using VVSA_backend.Model;
namespace VVSA_backend.Repository;

public class TransactionRepository : ITransactionRepository
{
    private List<Transaction> transactions;

    public TransactionRepository()
    {
        transactions = new List<Transaction>();

        Transaction transaction1 = new Transaction
        {
            TransactionId = 1
        };
        transactions.Add(transaction1);
        Transaction transaction2 = new Transaction
        {
            TransactionId = 2
        };
        transactions.Add(transaction2);
    }

    public List<Transaction> GetAllTransactions()
    {
        return transactions;
    }

    public Transaction GetTransactionById(int id)
    {
        return transactions.FirstOrDefault(t => t.TransactionId == id);
    }

}