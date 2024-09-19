Random random = new();
string[] names = ["Hero","Monster"];
int[] healths = [20,20];
int indexDamageTurn = 1;
int damage;

do {
    damage = random.Next(1,11);
    healths[indexDamageTurn] -= damage;
    Console.WriteLine($"{names[indexDamageTurn]} was damaged and lost {damage} health and now has {healths[indexDamageTurn]} health.");
    indexDamageTurn = Math.Abs(indexDamageTurn-1);
    Console.ReadKey();
}while(healths[0]>0 && healths[1]>0);
Console.WriteLine($"{names[indexDamageTurn]} wins!!!");