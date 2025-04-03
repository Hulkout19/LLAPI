class Game
{
    public Deck newDeck {get; set;}
    public Player player1 {get; set;}
    public Player computer;

    public List<Player> players{get; set;}

    public List<Turn> turns = new List<Turn>();

    public string myValue;
    public Game()
    {
        players = new List<Player> (); 
        this.myValue = "98";
        this.player1 = new Player("Sven", false);
        this.computer = new Player("Haleigh", true);
        this.players.Add(this.player1);
        this.players.Add(this.computer);
        this.newDeck = new Deck(players);
        check();
    }

    public string getMyValue(){
        return "hello";
    }

    public void playGame(){
        while(check()){

        }
    }

    public List<string> getShuffledDeck(){
        return newDeck.GetShuffledPile();
    }

    public string getShuffleDeck(){
        return newDeck.getShuffledDeck();
    }

    public bool check(){
        bool keepPlaying = true;

        for (int i = 0; i < players.Count; i++)
        {
            if(this.players[i].getActive() == false ||  newDeck.getCardsLeft() == 0){
                keepPlaying = false;
                return keepPlaying;
            }
        }
        return true;
        
    }
    
}