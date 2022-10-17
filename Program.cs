// Jacob Dekok
// 10/17/2022
// Git Hub Tansfer - Mini Challenge #5 Mab lib
// This is a conosle project that will ask the user for their input to 
// replace certain words in a story, then it will read the story back to the user.

/* 
Ken(N) is a cool(Adj)  guy(N). He teaches coding(verb) to people(n plural) who
want to learn how. One day his pet rock(N) asks if he wants to go to the moon(N).
He gets(verb) into his spaceship(N) and blasts off. Once he gets to the moon, he
gets out of his spaceship, and says "Wow, this place looks like a big(Adj) cheese wheel(N)."
*/
string playAgain = "YES";

while(playAgain == "YES"){

    Console.Clear();

Console.Write("Please enter a name: ");
string Ken = Console.ReadLine();
Console.Write("Please enter a adjetive: ");
string cool = Console.ReadLine();
Console.Write("Please enter a noun: ");
string guy = Console.ReadLine();
Console.Write("Please enter a verb ending with -ing: ");
string coding = Console.ReadLine();
Console.Write("Please enter a noun plural: ");
string people = Console.ReadLine();
Console.Write("Please enter a noun: ");
string rock = Console.ReadLine();
Console.Write("Please enter a noun: ");
string moon = Console.ReadLine();
Console.Write("Please enter a verb ending with -s: ");
string gets = Console.ReadLine();
Console.Write("Please enter a noun: ");
string spaceship = Console.ReadLine();
Console.Write("Please enter a adjetive: ");
string big = Console.ReadLine();
Console.Write("Please enter a noun: ");
string cheeseWheel = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine($"{Ken} is a {cool} guy. He teaches {coding} to {people} who");
Console.WriteLine($"want to learn how. One day his pet {rock} asks if he wants to go to the {moon}.");
Console.WriteLine($"He {gets} into his {spaceship} and blasts off. Once he gets to the {moon}, he");
Console.WriteLine($"gets out of his {spaceship}, and says 'Wow, this place looks like a {big} {cheeseWheel}.'");

Console.WriteLine("");
Console.WriteLine("Would you like to play again? 'YES' 'NO'");
playAgain = Console.ReadLine().ToUpper();

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

}

