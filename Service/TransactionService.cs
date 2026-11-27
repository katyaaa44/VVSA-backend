using VVSA_backend.Repository;
namespace VVSA_backend.Service;
using VVSA_backend.ViewModel;
public class TransactionService(ITransactionRepository transactionRepository) : ITransactionService
{
    public List<TransactionViewModel> GetAllTransactions()
    {
        List<TransactionViewModel> transactionViewModels = new List<TransactionViewModel>();
        var transactions = transactionRepository.GetAllTransactions();

        foreach (var transaction in transactions)
        {
            var transactionViewModel = new TransactionViewModel
            {
                TransactionId = transaction.Id,
                FullName = transaction.User.Name,
                TransactionType = (TransactionType)transaction.TransactionType.Id,
                AccountNumber = transaction.AccountNumber,
                BankCode = transaction.BankCode,
                IssueDate = transaction.IssueDate,
                Amount = transaction.Amount
            };

            transactionViewModels.Add(transactionViewModel);
        }

        return transactionViewModels;
    }

    public TransactionViewModel  GetTransactionById(int id)
    {
        var transaction = transactionRepository.GetTransactionById(id);

        if (transaction == null)
            return null;

        return new TransactionViewModel
            {
                TransactionId = transaction.Id,
                FullName = transaction.User.Name,
                TransactionType = (TransactionType)transaction.TransactionType.Id,
                AccountNumber = transaction.AccountNumber,
                BankCode = transaction.BankCode,
                IssueDate = transaction.IssueDate,
                Amount = transaction.Amount
            };
    }

}