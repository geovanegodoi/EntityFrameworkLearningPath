using System;

namespace Migrations.Domain
{
    public class Account
    {
        public int Id { get; set; }

        public DateTime Subscribe { get; set; }

        public DateTime ExpireDate { get; set; }

        public AccountType Type { get; set; }

        public User User { get; set; }
    }
}
