Random random = new Random();

bool ShouldPlay(){
    Console.WriteLine("Would you like to play? (Y/N)");
    string? response = Console.ReadLine();
    if (response == null) {
        return false;
    }else {
        return response.ToLower().Equals("y");
    }//End if
}//End ShouldPlay

string WinOrLose(int _target, int _value){
    return (_value>_target)?"You are the winner":"You are the loser";
}//End WinOrLose

void PlayGame() {
    var play = true;

    while (play){
        var target = random.Next(1,6);
        var roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }//End while
}//End PlayGame

if (ShouldPlay()) {
    PlayGame();
}//End if