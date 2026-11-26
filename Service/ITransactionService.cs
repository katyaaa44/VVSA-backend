using VVSA_backend.ViewModel;
namespace VVSA_backend.Service;

public interface ITransactionService
{
    List<TransactionViewModel> GetAllTransactions();
    TransactionViewModel GetTransactionById(int id);
}