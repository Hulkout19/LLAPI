using System.Collections.Generic;


class Deck
{
    
    private String removedCard;
    private List<string> drawPile = new List<string>(18);

    private List<string> shuffledDeck = new List<string>(17);
    private List<string> discardedDeck = new List<string>(17);

    public List<Player> playerList = new List<Player>();

    private string shuffleDeck = "";

    public Deck()
    {
        Random rnd = new Random();
        int random  = rnd.Next(0, 18);
        this.drawPile = ["1","1","1","1","1","2","2","3","3","4","4","5","5","6","6","7","8","9"];

        this.removedCard = drawPile[random];
        drawPile.RemoveAt(random);
        Shuffle();

    }

    public Deck(List<Player> players)
    {
        this.playerList = players;
        Random rnd = new Random();
        int random  = rnd.Next(0, 18);
        this.drawPile = ["1","1","1","1","1","2","2","3","3","4","4","5","5","6","6","7","8","9"];

        this.removedCard = drawPile[random];
        drawPile.RemoveAt(random);
        Shuffle();
        Deal();

    }

    public void Deal(){
        for (int i = 0; i < playerList.Count; i++)
        {
            playerList[i].setHeldCard(Draw());
        }
    }
       

    public List<string> GetDiscardPile(){
        return discardedDeck;
    }

    public List<string> GetShuffledPile(){
        return shuffledDeck;
    }

    public string getShuffledDeck(){
        
        return this.shuffleDeck;
    }

    public string Draw(){
        string drawnCard;
        drawnCard = shuffledDeck[0];
        shuffledDeck.RemoveAt(0);
        Console.WriteLine("drawnCard:" + drawnCard);
        Console.WriteLine("The new start of the array:" + shuffledDeck[0]);
        this.shuffleDeck = "";
        for (int i = 0; i < shuffledDeck.Count; i++)
        {
            this.shuffleDeck += shuffledDeck[i] + " ";

        }
        // Console.WriteLine("Shuffled array: " + this.shuffledDeck);
        // foreach (var item in this.shuffledDeck)
        // {
        //     Console.WriteLine(item);
        // }
        Console.WriteLine("shuffled string: "+this.shuffleDeck);
        return drawnCard;
    }

    public string Draw(Player player){
        string drawnCard;
        drawnCard = shuffledDeck[0];
        shuffledDeck.RemoveAt(0);
        player.DrawCard(drawnCard);
        return drawnCard;
    }

    public void Discard(string card){
        discardedDeck.Add(card);
    }

    public void Shuffle(){
        Random rnd2 = new Random();
        int randomShuffle;
        
        while(drawPile.Count != 0){
            randomShuffle = rnd2.Next(0, drawPile.Count);
            shuffledDeck.Add(drawPile[randomShuffle]);
            // shuffleDeck += drawPile[randomShuffle] + " ";
            // System.Console.WriteLine("random Shuffle " + randomShuffle);
            // System.Console.WriteLine("The removed card is "+ this.removedCard);
            drawPile.RemoveAt(randomShuffle);
            
        }


    }

    public int getCardsLeft() { 
        return shuffledDeck.Count;
    }

    public string getRemovedCard(){
        return this.removedCard;
    }

}