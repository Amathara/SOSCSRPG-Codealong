using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer {  get; set; }

        public GameSession()
        {
            // We want to create a new player and put that info into CurrentPlayer
            //When we use a single "=" is evaluates what's on on the right side and adds it into what's on the left side.
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Hilda";
            CurrentPlayer.Gold = 1000000;
        }
    }
}
