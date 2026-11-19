using VVSA_backend.Model;
namespace VVSA_backend.Service;

public interface ITransactionService
{
    List<Transaction> GetAllTransactions();
    Transaction GetTransactionById(int id);
}