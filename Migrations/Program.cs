using Migrations.Context;
using System.Data.Entity;
using System.Linq;
using static System.Console;

namespace Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MigrationDbContext())
            {
                var users = context.Users.Include(i => i.Accounts).ToList();

                foreach (var user in users)
                {
                    WriteLine($"Name : {user.Name} | Password : {user.Password}");
                    foreach (var account in user.Accounts)
                    {
                        WriteLine($"Account Type : {account.Type.Description}");
                    }
                    WriteLine("------------------------------------------");
                }
                ReadLine();
            }
        }
    }
}
