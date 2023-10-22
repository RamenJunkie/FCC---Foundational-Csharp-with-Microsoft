// Role playing game battle challenge

// In some role playing games, the player's character battles non-player characters, which are usually monsters
// or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and
// that value is subtracted from the opponent's health score. Once either character's health reaches zero, they
// lose the game.

// In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same
// health score. During the hero's turn, they'll generate a random value which will be subtracted from the monster's
// health. If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as
// both the hero and the monster have health greater than zero, the battle will resume.

// Code challenge - write code to implement the game rules

// Here are the rules for the battle game that you need to implement in your code project:

//     You must use either the do-while statement or the while statement as an outer game loop.
//     The hero and the monster will start with 10 health points.
//     All attacks will be a value between 1 and 10.
//     The hero will attack first.
//     Print the amount of health the monster lost and their remaining health.
//     If the monster's health is greater than 0, it can attack the hero.
//     Print the amount of health the hero lost and their remaining health.
//     Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
//     Print the winner.

int heroHealth = 10;
int monsterHealth = 10;
string winner = "";

Random random = new Random();
int damage = random.Next(1, 11);

do{
    damage = random.Next(1, 11);
    monsterHealth -= damage;
    Console.WriteLine($"Hero does {damage} damage to the monster.");
    if(monsterHealth <0 ) { monsterHealth = 0; }
    Console.WriteLine($"Monster has {monsterHealth} HP remaining.");

    if(monsterHealth > 0)
    {
    damage = random.Next(1, 11);
    heroHealth -= damage;
    Console.WriteLine($"Monster does {damage} damage to the hero.");
    if(heroHealth < 0 ) { heroHealth = 0; }
    Console.WriteLine($"Player has {heroHealth} HP remaining.");
    }

    if(heroHealth == 0) { winner = "Monster";}
    if(monsterHealth == 0) { winner = "Hero";}

} while(winner == "");

Console.WriteLine($"{winner} has won the battle!");