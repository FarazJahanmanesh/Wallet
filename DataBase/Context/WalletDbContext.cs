using Microsoft.EntityFrameworkCore;

namespace DataBase.Context;
public class WalletDbContext:DbContext
{
	public WalletDbContext(DbContextOptions<WalletDbContext>options):base(options)
	{
	}
}
