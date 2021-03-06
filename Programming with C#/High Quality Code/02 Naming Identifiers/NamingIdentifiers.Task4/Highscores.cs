﻿namespace NamingIdentifiers.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NamingIdentifiers.Task4.Interfaces;

    public class Highscores : IHighscores
    {
        private const int MaxPlayersOnScoreBoard = 5;
        private readonly List<IPlayer> players;

        public Highscores(List<IPlayer> players)
        {
            this.players = players;
        }

        public void PrintPlayersHighscores()
        {
            if (this.players.Any())
            {
                Console.WriteLine("\nHighScores:");
                for (int i = 0; i < this.players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, this.players[i].Name, this.players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores yet.\n");
            }
        }

        public void AddPlayerToScoreBoard(int correctGuessesCounter)
        {
            Console.Write("Please enter your nickname: ");
            string nickName = Console.ReadLine();
            if (!this.CheckIfPlayerExists(nickName))
            {
                var currentPlayer = new Player(nickName, correctGuessesCounter);
                this.AddNewPlayerToScoreboard(currentPlayer);                
            }
            else
            {
                this.AddScoreToExistingPlayer(nickName, correctGuessesCounter);
            }

            this.players.Sort((IPlayer p1, IPlayer p2) => p2.Name.CompareTo(p1.Name));
            this.players.Sort((IPlayer p1, IPlayer p2) => p2.Points.CompareTo(p1.Points));
        }

        private bool CheckIfPlayerExists(string nickName)
        {
            foreach (var player in this.players)
            {
                if (player.Name == nickName)
                {
                    return true;
                }
            }

            return false;
        }

        private void AddNewPlayerToScoreboard(IPlayer currentPlayer)
        {
            if (this.players.Count < MaxPlayersOnScoreBoard)
            {
                this.players.Add(currentPlayer);
            }
            else
            {
                for (int i = 0; i < this.players.Count; i++)
                {
                    if (this.players[i].Points < currentPlayer.Points)
                    {
                        this.players.Insert(i, currentPlayer);
                        this.players.RemoveAt(this.players.Count - 1);
                        break;
                    }
                }
            }
        }

        // This method adds the score olny if it is higher than the current one the player has.
        private void AddScoreToExistingPlayer(string nickName, int correctGuessesCounter)
        {
            foreach (var player in this.players)
            {
                if (player.Name == nickName && player.Points < correctGuessesCounter)
                {
                    player.Points = correctGuessesCounter;
                }
            }
        }
    }
}
