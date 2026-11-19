using VVSA_backend.Model;
namespace VVSA_backend.Repository;

public interface ITransactionRepository
{
    List<Transaction> GetAllTransactions();
    int getTransactionById(int id);
}