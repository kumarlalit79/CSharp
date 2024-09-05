using System;


namespace CSharp
{
    class Sports
    {
        public string rules;
        public int players;
        public string ground;
        public int totalMatches;

        public void PrintSports()
        {
            Console.WriteLine("I Love Sports");
            Console.WriteLine("Rules : " +  rules);
            Console.WriteLine("Players : " +  players);
            Console.WriteLine("Ground : " +  ground);
            Console.WriteLine("TotalMatches : " +  totalMatches);
        }
    }

    class Cricket : Sports
    {
        public string place;
        public int TotalPlayer;
        public string capton;
        public void PrintCricket()
        {
            Console.WriteLine("Sachin Tendulkar");
            Console.WriteLine("Place : " +  place);
            Console.WriteLine("TotalPlayer : " +  TotalPlayer);
            Console.WriteLine("Capton : " +  capton);
        }
    }

    class Football : Sports 
    {
        public string place;
        public int TotalPlayer;
        public string capton;
        public void PrintFootball()
        {
            Console.WriteLine("Sunil Chetri");
            Console.WriteLine("Place : " + place);
            Console.WriteLine("TotalPlayer : " + TotalPlayer);
            Console.WriteLine("Capton : " + capton);
        }
    }

    class Hockey : Sports
    {
        public string place;
        public int TotalPlayer;
        public string capton;
        public void PrintHockey()
        {
            Console.WriteLine("Hockey in National Game of India");
            Console.WriteLine("Place : " + place);
            Console.WriteLine("TotalPlayer : " + TotalPlayer);
            Console.WriteLine("Capton : " + capton);
        }

        // Main Class
        public static void main(string[] args)
        {
            // cricket object se mai sirf cricket class or sports class ko access kar skta hoon
            Cricket cricket = new Cricket();
            cricket.rules = "No Cheating";
            cricket.players = 11;
            cricket.ground = "Indira Gandhi Stadium";
            cricket.totalMatches = 10;
            cricket.PrintSports();

            Console.WriteLine(" ");

            cricket.place = "Chinna Swami Stadium";
            cricket.TotalPlayer = 11;
            cricket.capton = "Rohit Sharma";
            cricket.PrintCricket();

            Console.WriteLine(" ");

            Football football = new Football();
            football.place = "Mohali";
            football.TotalPlayer = 11;
            football.capton = "Ronaldo";
            football.PrintFootball();

            Console.WriteLine(" ");

            Hockey hockey = new Hockey();
            hockey.place = "Nehru Stadium";
            hockey.TotalPlayer = 11;
            hockey.capton = "Pajji";
            hockey.PrintHockey();
        }
    }
}
