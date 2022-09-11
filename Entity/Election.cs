using System;

namespace VoteSystem.Entity{

    // Birden fazla seçenek var seçim nasıl gelebilir tıklayacak string olarak gelsin 
    public class Election{

        public int Id { get; set; }
        public string party { get; set; }
        public int numberOfVote { get; set; }
        public long totalOfVote { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string neighborhood { get; set; }
        public int AccountId { get; set; }

        
    }
}