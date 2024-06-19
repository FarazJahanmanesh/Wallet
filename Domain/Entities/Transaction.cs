using Domain.Commons;
namespace Domain.Entities;

public class Transaction : BaseEntity
{
    public Account Account { get; set; }
    public string Amount { get; set; }
    //public Operation{get;set;} use enum for that
}
