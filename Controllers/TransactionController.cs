using Microsoft.AspNetCore.Mvc;
using VVSA_backend.Service;
using VVSA_backend.DatabaseModel;

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
    public List<Transaction> GetAll()
    {
        return transactionService.GetAllTransactions();
    }

    [HttpGet("{id}", Name = "GetTransactionById")]
    public Transaction Get(int id)
    {
        return transactionService.GetTransactionById(id);
    }
}