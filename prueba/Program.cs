Random dados = new();

for(int i = 0; i < 5; i++){
    Console.WriteLine(dados.Next(1,7));
}// End for

int firstValue = 500;
int secondValue = 600;
Console.WriteLine(Math.Max(firstValue, secondValue));

Random dice = new Random();

int[] rolls = new int[3];
for(int i = 0; i < 3; i++){
    rolls[i] = dice.Next(1,7);
}//End for

int bonus = 0;
if ((rolls[0] == rolls[1]) && (rolls[1] == rolls[2])){
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    bonus = 6;
} else if ((rolls[0] == rolls[1]) || (rolls[1] == rolls[2]) || (rolls[0] == rolls[2])){
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    bonus = 2;
}//End if

Console.WriteLine($"Dice roll bucle: {rolls[0]} + {rolls[1]} + {rolls[2]} + bonus = {rolls.Sum()+bonus}");


if (rolls.Sum() + bonus > 10){
    Console.WriteLine("You win!");
}else{
    Console.WriteLine("Sorry, you lose.");
}//End if