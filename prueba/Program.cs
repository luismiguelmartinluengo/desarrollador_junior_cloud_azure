Random random = new();
int herohealth = 20;
int monsterhealth = 20;
bool isHeroTurn = true;
int damage;

do {
    damage = random.Next(1,11);
    if (isHeroTurn){
        monsterhealth -= damage;
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterhealth} health.");
    }else{
        herohealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {herohealth} health.");
    }//End if
    isHeroTurn = !isHeroTurn;
    Console.ReadKey();
}while(herohealth>0 && monsterhealth>0);
Console.WriteLine($"{((herohealth <= 0)?"Monster":"Hero")} wins!!!");