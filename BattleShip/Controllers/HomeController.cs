using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleShip.Models;

namespace BattleShip.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //play another person or the computer
        public IActionResult RequestPlayers(string players, string side)
        {
            //good and bad ship list needed
            if (players =="Friend")//have the 2nd player place ships after player 1
            {
                if (side == "Light") 
                {
                    PlacePlayer1Ships(ShipTypes); //user1 enters
                    NextTurn();         //wait for user2 control
                    List<int> Player2Ships = new List<int>();
                    PlacePlayer2Ships(true, Player2Ships); //user2 enters ships
                }
                else if (side == "Dark") 
                {
                    PlacePlayer1Ships(); //user1 enters
                    NextTurn();         //wait for user2 control
                    List<int> Player2Ships = new List<int>();
                    PlacePlayer2Ships(true, Player2Ships); //user2 enters ships
                }
            }
            else if (players=="Computer")//have the ships be placed randomly on the 2nd board
            {
                PlacePlayer1Ships();
            }
           
        }

        //players place ships on board
        public IActionResult PlacePlayer1Ships()
        {
            return View();
        }

        //place the 2nd players ships on board
        public IActionResult PlacePlayer2Ships(bool player2, List<int> Player2Ships)
        {
            if (player2)//if there is a second player they place there ships on the 2nd board
            {
                //player2 list 
            }
            else if (player2 == false)//the computer will fill the second board
            {
                //player2 list
            }
            return View();
        }

        //player guesses where opponents ships are
        public IActionResult Attack()
        {
            return View();
        }

        //waiting page while players change control
        public IActionResult NextTurn()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
