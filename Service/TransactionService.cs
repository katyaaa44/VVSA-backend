using VVSA_backend.Model;
using VVSA_backend.Repository;
namespace VVSA_backend.Service;
public class TransactionService(ITransactionRepository transactionRepository) : ITransactionService
{
    public List<Transaction> GetAllTransactions()
    {
        return transactionRepository.GetAllTransactions();
    }

    public Transaction GetTransactionById(int id)
    {
        return transactionRepository.GetTransactionById(id);
    }

}