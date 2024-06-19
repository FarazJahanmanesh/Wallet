using Domain.Commons;
namespace Domain.Entities;

public class User: BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime EntryDate { get; set; }
    public List<Account> Accounts { get; set; }
}
