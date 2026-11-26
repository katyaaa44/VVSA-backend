using VVSA_backend.Model;
namespace VVSA_backend.Repository;

public class TransactionRepository(Whies5oContext context) : ITransactionRepository
{
    private List<Transaction> transactions;

    public List<Transaction> GetAllTransactions()
    {
        return context.Transactions.ToList();
    }

    public Transaction GetTransactionById(int id)
    {
        return context.Transactions.FirstOrDefault(t => t.TransactionId == id);
    }

}