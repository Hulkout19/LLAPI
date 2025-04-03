class Player
{

private string? name;
private string heldCard = "";

private string drawnCard = "";

private int confidenceScore;

private bool isBot;

private bool isActive;

public Player(string name, bool bot)
{
    this.name = name;
    this.isBot = bot;
}

public void setActive(bool newActive){
    this.isActive = newActive;
}

public bool getActive(){
    return this.isActive;
}
public void setHeldCard(string card){
    this.heldCard = card;
}

public string getHeldCard(){
    return this.heldCard;
}

public void DrawCard(string card){
    this.drawnCard = card;
}

public string getDrawnCard(){
    return this.drawnCard;
}

public string playCard(string playedCard){

    if(playedCard == this.heldCard){
        this.heldCard = drawnCard;
    }
    
    return this.heldCard;
}
}