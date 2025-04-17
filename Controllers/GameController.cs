using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class api_test : ControllerBase
    {

        [HttpGet]
        public JsonResult getGame(){
            Game myGame = new Game();
            Dictionary<string,string> games = new Dictionary<string, string>();
            games.Add("Player1HeldCard",myGame.player1.getHeldCard());
            return new JsonResult(Ok(games));
        }

        [HttpGet]
        public JsonResult getGamePieces(){
            Game myGame = new Game();

            Dictionary<string,string> games = new Dictionary<string, string>();
            games.Add("Player1HeldCard",myGame.player1.getHeldCard());
            games.Add("Player2HeldCard",myGame.computer.getHeldCard());
            games.Add("Cards Left",myGame.newDeck.getCardsLeft().ToString());
            games.Add("ShuffledDeck", myGame.getShuffleDeck());
            games.Add("RemovedCard", myGame.newDeck.getRemovedCard());
            //string jsonString = JsonSerializer.Serialize(games);
            return new JsonResult(Ok(games));
        }
    }
}
