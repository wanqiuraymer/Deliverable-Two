// See https://aka.ms/new-console-template for more information
bool wrongInput = false;
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!\nWhat is your name?");
string userName = Console.ReadLine();
while (wrongInput== false) 
{
    wrongInput = true;
   
    Console.WriteLine($"Welcome, {userName}! Do you want to do the COIN FLIP CHALLENGE? Yes/No");
    string userResponse = Console.ReadLine();
    userResponse = userResponse.ToLower();
    string[] choices = new string[2] { "heads", "tails" };

    Random random = new Random();
    int score = 0;
    int life = 5;
    if (userResponse == "no")
    {
        Console.WriteLine($"You are a coward {userName}");
    }
    else if (userResponse == "yes")
    {
        while (life > 0)
        {
            int selectRandom = random.Next(0, choices.Length);
            Console.WriteLine("Heads or Tails?");
            string userSelect = Console.ReadLine().ToLower();

            if (userSelect == choices[selectRandom])
            {
                score += 1;
                Console.WriteLine("Correct!");
            }
            else { Console.WriteLine("Wrong!"); }
            life--;
        }
        Console.WriteLine($"Thank you, {userName}! You got a total score of {score}.");
        break;
    }
    else 
    { 
        Console.WriteLine("Input has to be Yes or No. Try again, please!");  
        wrongInput= false;
       
    }

}


Console.Read();

