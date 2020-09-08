namespace BlackJack.Properties
{
    public class Card: ICard
    {
        private Suit CardSuit;
        private Face CardFace;

        public Card()
        {
        }

        public Suit CardSuit1
        {
            get => CardSuit;
            private set => CardSuit = value;
        }

        public Face CardFace1
        {
            get => CardFace;
           private set => CardFace = value;
        }

        public string face { get; }
        public string suit { get; }
        public void draw(int cardOne, int cardTwo)
        {
            throw new System.NotImplementedException();
        }
    }
}