

class Turn{

    Player playPlayer;

    Player opponent;

    public string? compareCard;


    public Turn(Player playPlayer, Player opponent, string playedCard, string? guess)
    {
        this.playPlayer = playPlayer;
        this.opponent = opponent;
        switch (playedCard) 
        {
        case "1":
            Guard(guess);
            break;
        case "2":
            this.compareCard = Priest();
            break;
        }
    }

    
    public string Guard(string? guess){
        if(guess == opponent.getHeldCard()){
            opponent.setActive(false);

        }
        return ("opponent is out!");
    }

    public string Priest(){
        return opponent.getHeldCard();
    }

}