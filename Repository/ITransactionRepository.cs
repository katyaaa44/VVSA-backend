namespace VVSA_backend.Repository;
using VVSA_backend.DatabaseModel;

public interface ITransactionRepository
{
    List<Transaction> GetAllTransactions();
    Transaction GetTransactionById(int id);
}