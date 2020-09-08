namespace BlackJack.Properties
{
    public interface ICard
    {
        string face
        {
            get;
            
        }

        string suit
        {
            get;
        }

        void draw(int cardOne, int cardTwo);



    }
    
}