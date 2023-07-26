class Card
    {
        public string Rank;
        public string Suit;
        public Card(string id){
            Rank=id.Split('-')[0];
            Suit=id.Split('-')[1];
        }
        public override string ToString()
        {
            return Rank +"-"+Suit;
        }
    }
