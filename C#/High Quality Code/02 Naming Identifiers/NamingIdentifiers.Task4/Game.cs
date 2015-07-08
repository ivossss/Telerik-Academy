﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingIdentifiers.Task4
{
    public class Game
    {
        private const int NumberOfRows = 5;
        private const int NumberOfCols = 10;
        private const string GreetingMessage = "Let's play \"mines\". Try to guess the boxes without mines." +
                            "\nCommands:\n\"scores\": shows highscores\n\"restart\": starts a new game\n\"exit\": ends the game";

        private PlayingBoard playingBoard;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private bool mineIsHit = false;
        private bool commandIsExit = false;
        private bool gameIsWon = false;
        private bool showGreetingMessage = true;
        private int correctGuessesCounter = 0;
        private Highscores highscores = new Highscores();
        private const int max = 35;


        public void Start()
        {
            if (showGreetingMessage)
            {
                Console.WriteLine(GreetingMessage);
            }

            this.playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols);
            this.playingBoard.PrintBoardWithHiddenMines();
            string command;

            while (!this.mineIsHit && !this.commandIsExit && !this.gameIsWon)
            {
                Console.Write("Please enter command or row and column: ");
                command = Console.ReadLine();
                this.ProcessCommand(command);
            }

            if (this.mineIsHit)
            {
                this.playingBoard.PrintBoardWithMines();
                Console.Write("You hit a mine. Your score is: {0} ", correctGuessesCounter);
                this.HandlePlayer();
                this.RestartGame();
            }

            if (this.gameIsWon)
            {
                this.playingBoard.PrintBoardWithMines();
                Console.WriteLine("You win.");
                this.HandlePlayer();
                this.RestartGame();
            }
        }

        private void ProcessCommand(string command)
        {
            if (CheckForValidRowAndCol(command))
            {
                if (this.playingBoard.BoardWithMines[selectedRow, selectedCol] == '*')
                {
                    mineIsHit = true;
                }
                else
                {
                    CalculateNumberOfBombs();
                    correctGuessesCounter++;

                    if (max == correctGuessesCounter)
                    {
                        gameIsWon = true;
                    }
                    else
                    {
                        playingBoard.PrintBoardWithHiddenMines();
                    }
                }
            }
            else
            {
                switch (command)
                {
                    case "scores":
                        this.highscores.PrintPlayersHighscores();
                        break;
                    case "restart":
                        this.RestartGame();
                        break;
                    case "exit":
                        commandIsExit = true;
                        Console.WriteLine("Thank you for playing.");
                        break;
                    default:
                        Console.WriteLine("Invalid command or row or column.");
                        break;
                }
            }
        }

        private bool CheckForValidRowAndCol(string command)
        {
            char[] validSeparators = { ' ', ',', '-' };
            var numbers = command.Split(validSeparators, StringSplitOptions.RemoveEmptyEntries);
            bool isValidRowAndCol = numbers.Length == 2 &&
                                    int.TryParse(numbers[0], out this.selectedRow) &&
                                    int.TryParse(numbers[1], out this.selectedCol) &&
                                    this.selectedRow <= this.playingBoard.Rows &&
                                    this.selectedCol <= playingBoard.Cols;

            return isValidRowAndCol;
        }

        private void CalculateNumberOfBombs()
        {
            int numberOfBombs = 0;

            if (this.selectedRow - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedRow + 1 < this.playingBoard.Rows)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedCol - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedCol + 1 < this.playingBoard.Cols)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow - 1 >= 0) && (this.selectedCol - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow - 1 >= 0) && (this.selectedCol + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow + 1 < this.playingBoard.Rows) && (this.selectedCol - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow + 1 < this.playingBoard.Rows) && (this.selectedCol + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
            this.playingBoard.BoardWithHiddenMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
        }

        private void RestartGame()
        {
            this.mineIsHit = false;
            this.showGreetingMessage = false;
            this.gameIsWon = false;
            this.correctGuessesCounter = 0;
            this.Start();
        }

        private void HandlePlayer()
        {
            this.highscores.AddPlayerToScoreBoard(correctGuessesCounter);
            this.highscores.PrintPlayersHighscores();
        }
    }
}
