using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRegistrationServer.Models
{
    public class GameRegistration
    {
        List<Game> gameList;
        static GameRegistration stdregd = null;

        private GameRegistration()
        {
            gameList = new List<Game>();
        }

        public static GameRegistration getInstance()
        {
            if (stdregd == null)
            {
                stdregd = new GameRegistration();
                return stdregd;
            }
            else
            {
                return stdregd;
            }
        }

        public void Add(Game game)
        {
            gameList.Add(game);
        }

        public String Remove(String registrationNumber)
        {
            for (int i = 0; i < gameList.Count; i++)
            {
                Game stdn = gameList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(registrationNumber))
                {
                    gameList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }

            return "Delete un-successful";
        }

        public List<Game> getAllGame()
        {
            return gameList;
        }

        public String UpdateGame(Game std)
        {
            for (int i = 0; i < gameList.Count; i++)
            {
                Game stdn = gameList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(std.RegistrationNumber))
                {
                    gameList[i] = std;//update the new record
                    return "Update successful";
                }
            }

            return "Update un-successful";
        }


    }
}
