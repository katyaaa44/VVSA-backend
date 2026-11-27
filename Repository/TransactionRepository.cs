namespace VVSA_backend.Repository;
using VVSA_backend.DatabaseModel;
using Microsoft.EntityFrameworkCore;

public class TransactionRepository(Whiyes5oContext context) : ITransactionRepository
{
    public List<Transaction> GetAllTransactions()
    {
        var result = context.Transactions
            .Include(p => p.User)
            .Include(p => p.TransactionType)
            .ToList();

        return result;
    }

    public Transaction GetTransactionById(int id)
    {
         var result = context.Transactions
            .Include(p => p.User)
            .Include(p => p.TransactionType)
            .FirstOrDefault(p => p.Id == id);

        return result;
    }
}