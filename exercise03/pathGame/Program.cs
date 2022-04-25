using System;
using System.Collections.Generic;

namespace pathGame {
    //Write a game program that starts a game represented by an N x N square.The player(P) could
    //at any turn move one position in either direction(up, down, left, and right). If she hits a wall(W) -
    //game over.The goal is for the player to get to the exit (X) which is always located at lower right
    //end. Let the player always start at upper left end.At each step, display the current state on the
    //board and ask the player for a command for the next step.At the beginning of the game, ask for
    //square size (up to 15).

    class Program {
        static char[,] StartGame(int col, int row) {
            var r = new Random();
            var field = new char[col, row];
            for (var i = 0; i < field.GetLength(0); i++) {
                for (var j = 0; j < field.GetLength(1); j++) {
                    field[i, j] = '*';
                }
            }

            for (var i = 0; i < 6; i++) {
                field[r.Next(0, col - 1), r.Next(0, row - 1)] = 'W';
            }

            field[0, 0] = 'P';
            field[col - 1, row - 1] = 'X';
            return field;
        }

        static void PrintCurrent(char[,] array) {
            for (var i = 0; i < array.GetLength(0); i++) {
                for (var j = 0; j < array.GetLength(1); j++) {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void MoveDown(char[,] array) {
            int arrayI = 0;
            int arrayJ = 0;
            for (var i = 0; i < array.GetLength(0); i++) {
                for (var j = 0; j < array.GetLength(1); j++) {
                    if (array[i, j] == 'P') {
                        arrayI = i;
                        arrayJ = j;
                    }
                }
            }

            if (array[arrayI + 1, arrayJ] == 'W') {
                Console.WriteLine("cant hit a wall");
            }
            else if (array[arrayI + 1, arrayJ] == 'X') {
                Console.WriteLine("You found the path!");
            }
            else {
                array[arrayI, arrayJ] = '*';
                array[arrayI + 1, arrayJ] = 'P';
            }
        }

        static void MoveUp(char[,] array) {
            var arrayI = 0;
            var arrayJ = 0;
            for (var i = 0; i < array.GetLength(0); i++) {
                for (var j = 0; j < array.GetLength(1); j++) {
                    if (array[i, j] == 'P') {
                        arrayI = i;
                        arrayJ = j;
                    }
                }
            }

            if (array[arrayI - 1, arrayJ] == 'W') {
                Console.WriteLine("Cant hit a wall");
            }
            else if (array[arrayI - 1, arrayJ] == 'X') {
                Console.WriteLine("You found the path!");
            }
            else {
                array[arrayI, arrayJ] = '*';
                array[arrayI - 1, arrayJ] = 'P';
            }
        }

        static void MoveRight(char[,] array) {
            int arrayI = 0;
            int arrayJ = 0;
            for (var i = 0; i < array.GetLength(0); i++) {
                for (var j = 0; j < array.GetLength(1); j++) {
                    if (array[i, j] == 'P') {
                        arrayI = i;
                        arrayJ = j;
                    }
                }
            }

            if (array[arrayI, arrayJ + 1] == 'W') {
                Console.WriteLine("Cant hit a wall");
            }
            else if (array[arrayI, arrayJ + 1] == 'X') {
                Console.WriteLine("You found the path!");
            }
            else {
                array[arrayI, arrayJ] = '*';
                array[arrayI, arrayJ + 1] = 'P';
            }
        }

        static void MoveLeft(char[,] array) {
            for (var i = 0; i < array.GetLength(0); i++) {
                for (var j = 0; j < array.GetLength(1); j++) {
                    if (array[i, j] == 'P') {
                        if (j == 0) {
                            Console.WriteLine("Invalid move");
                        }
                        else {
                            array[i, j] = '*';
                            array[i, j - 1] = 'P';
                        }
                    }
                }
            }
        }

        static void Main(string[] args) {
            var isRunning = true;
            var field = StartGame(15, 15);
            PrintCurrent(field);

            while (isRunning) {
                var input = "";
                Console.WriteLine("input:");
                input = Console.ReadLine().ToUpper();


                switch (input) {
                    case "S":
                        MoveDown(field);
                        PrintCurrent(field);
                        break;
                    case "A":
                        MoveLeft(field);
                        PrintCurrent(field);
                        break;
                    case "D":
                        MoveRight(field);
                        PrintCurrent(field);
                        break;
                    case "W":
                        MoveUp(field);
                        PrintCurrent(field);
                        break;
                    default:
                        isRunning = false;
                        PrintCurrent(field);
                        break;
                }
            }
        }
    }
}