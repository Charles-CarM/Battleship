﻿
namespace ConsoleBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Destroyer d1 = new Destroyer();
            Destroyer d2 = new Destroyer();

            Submarine s1 = new Submarine();
            Submarine s2 = new Submarine();

            Cruiser c1 = new Cruiser();
            Cruiser c2 = new Cruiser();

            Battleship b1 = new Battleship();
            Battleship b2 = new Battleship();

            Carrier ca1 = new Carrier();
            Carrier ca2 = new Carrier();

            GameBoard playerA = new GameBoard();
            GameBoard playerB = new GameBoard();
            GameBoard playerAGuesses = new GameBoard();
            GameBoard playerBGuesses = new GameBoard();
            bool sunk = false;
            string message;

            Welcome();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");

            while (true)
            {
                Console.WriteLine(playerA.AddShip());
                Console.ReadLine();
                //playerB.AddShip();
                while(!sunk)
                {

                try
                {
                    Console.WriteLine("Enter your guess: X, Y");
                    string guess = Console.ReadLine();
                    int xPos = Convert.ToInt32(guess.Split(',')[0]) - 1;
                    int yPos = Convert.ToInt32(guess.Split(',')[1]) - 1;

                    if (xPos > 9 || yPos > 9)
                    {
                        Console.WriteLine(message = "You are off the board, try again!");
                    }
                    playerA.CheckGuess(xPos, yPos);                   
                }
                catch
                {
                    Console.WriteLine(message = "Unable to process coordinates");
                }
                Console.ReadLine();
                //finished = true;
                }

                Console.WriteLine(message = "You sunk the ship!");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }   
        }
        private static void Welcome()
        {
            Console.WriteLine("Welcome to Console Battle!");
            //Console.ReadLine();
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username} press Enter!");
            Console.ReadLine();
        }
        public abstract class Ship
        {
            public abstract string Name { get; }
            public abstract int Length { get; }
        }
        public class Destroyer : Ship
        {
            public override string Name { get => "Destroyer"; }
            public override int Length { get => 2; }
        }
        public class Submarine : Ship
        {
            public override string Name { get => "Submarine"; }
            public override int Length { get => 3; }
        }
        public class Cruiser : Ship
        {
            public override string Name { get => "Cruiser"; }
            public override int Length { get => 3; }
        }
        public class Battleship : Ship
        {
            public override string Name { get => "Battleship"; }
            public override int Length { get => 4; }
        }
        public class Carrier : Ship
        {
            public override string Name { get => "Carrier"; }
            public override int Length { get => 5; }
        }

        //static void Bomb()
        //{
        //
        //}

    }
}


