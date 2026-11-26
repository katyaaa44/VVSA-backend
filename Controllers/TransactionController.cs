using Microsoft.AspNetCore.Mvc;
using VVSA_backend.Service;
using VVSA_backend.ViewModel;

namespace VVSA_backend.Controllers;

[ApiController]
[Route("api/transaction")]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{

    [HttpGet(Name = "GetTransaction")]
    public string Get()
    {
        return "First controller request";
    }

    [HttpGet("all", Name = "GetAllTransactions")]
    public List<TransactionViewModel> GetAll()
    {
        return transactionService.GetAllTransactions();
    }

    [HttpGet("{id}", Name = "GetTransactionById")]
    public TransactionViewModel Get(int id)
    {
        return transactionService.GetTransactionById(id);
    }
}