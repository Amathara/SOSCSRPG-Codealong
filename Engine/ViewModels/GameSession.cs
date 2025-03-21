using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer {  get; set; }

        public GameSession()
        {
            // We want to create a new player and put that info into CurrentPlayer
            //When we use a single "=" is evaluates what's on on the right side and adds it into what's on the left side.
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Hilda";
            CurrentPlayer.CharacterClass = "Rogue";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000; //Rich boi
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

        }
    }
}
