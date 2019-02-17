using System.Collections.Generic;

namespace Migrations.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
