using System.Collections.Generic;

namespace VoteSystem.Entity{
    public class Account{

        public int Id { get; set; }
        public string  userName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public int password { get; set; }

        public List<Election> Elections { get; set; }


    }
}