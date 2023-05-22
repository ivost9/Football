using Football;
using System.ComponentModel;


Coach coach1 = new Coach("Georgi Dermendzhiev",56);
List<FootballPlayer> players1 = new List<FootballPlayer>();
FootballPlayer footballPlayer1 = new Goalkeeper("Georgi Petkov", 23, 1, 1.85);
FootballPlayer footballPlayer2 = new Defender("Ivan Petrov", 23, 3, 1.76);
FootballPlayer footballPlayer3 = new Defender("Deyan Lozev", 27, 7, 1.73);
FootballPlayer footballPlayer4 = new Defender("Ivaylo Chochev", 25, 8, 1.90);
FootballPlayer footballPlayer5 = new Striker("Georgi Yomov", 29, 9, 1.74);
FootballPlayer footballPlayer6 = new Striker("Kiril Despodov", 28, 10, 1.81);
FootballPlayer footballPlayer7 = new Striker("Todor Nedelev", 32, 11, 1.86);
FootballPlayer footballPlayer8 = new Defender("Antonio Vutov", 25, 17, 1.76);
FootballPlayer footballPlayer9 = new Midfielder("Filip Krustev", 19, 18, 1.71);
FootballPlayer footballPlayer10 = new Midfielder("Dimitar Iliev", 33, 22, 1.79);
FootballPlayer footballPlayer11 = new Midfielder("Ivelin Popov", 32, 88, 1.74);

players1.Add(footballPlayer1);
players1.Add(footballPlayer2);
players1.Add(footballPlayer3);
players1.Add(footballPlayer4);
players1.Add(footballPlayer5);
players1.Add(footballPlayer6);
players1.Add(footballPlayer7);
players1.Add(footballPlayer8);
players1.Add(footballPlayer9);
players1.Add(footballPlayer10);
players1.Add(footballPlayer11);


Team team1 = new Team(coach1,players1);
Console.WriteLine("Team 1 Coach:");
Console.WriteLine(team1.Coach.Name+" "+team1.Coach.Age);
Console.WriteLine();
Console.WriteLine("Team 1 Squad:");
foreach (var item in players1)
{
    Console.WriteLine("№" + item.Number + " " + item.Name);
}
Console.WriteLine();
Console.WriteLine("Average Age in Team 1 is: "+team1.AverageAge(players1)+" age");

Coach coach2 = new Coach("Plamen Mladenov",52);
List<FootballPlayer> players2 = new List<FootballPlayer>();
FootballPlayer footballPlayer12 = new Goalkeeper("Valeri Bojinov", 29, 1, 1.76);
FootballPlayer footballPlayer13 = new Defender("Martin Toshev", 27, 2, 1.73);
FootballPlayer footballPlayer14 = new Defender("Toni Ivanov", 28, 3, 1.81);
FootballPlayer footballPlayer15 = new Defender("Kaloyan Ivanov", 32, 4, 1.86);
FootballPlayer footballPlayer16 = new Midfielder("Filip Krustev", 25, 6, 1.71);
FootballPlayer footballPlayer17 = new Midfielder("Hristiyan Vasilev", 32, 8, 1.74);
FootballPlayer footballPlayer18 = new Midfielder("Svetoslav Dikov", 29, 10, 1.85);
FootballPlayer footballPlayer19 = new Striker("Georgi Angelov", 30, 11, 1.90);
FootballPlayer footballPlayer20 = new Striker("Martin Sorakov", 29, 17, 1.74);
FootballPlayer footballPlayer21 = new Midfielder("Stefan Hristov", 33, 22, 1.79);
FootballPlayer footballPlayer22 = new Defender("Martin Ivanov", 32, 31, 1.76);

players2.Add(footballPlayer12);
players2.Add(footballPlayer13);
players2.Add(footballPlayer14);
players2.Add(footballPlayer15);
players2.Add(footballPlayer16);
players2.Add(footballPlayer17);
players2.Add(footballPlayer18);
players2.Add(footballPlayer19);
players2.Add(footballPlayer20);
players2.Add(footballPlayer21);
players2.Add(footballPlayer22);

Team team2 = new Team(coach2,players2);
Console.WriteLine();
Console.WriteLine("Team 2 coach:");
Console.WriteLine(team2.Coach.Name+" "+team2.Coach.Age);
Console.WriteLine();
Console.WriteLine("Team 2 Squad:");
foreach (var item in team2.Players)
{
    Console.WriteLine("№"+item.Number + " " + item.Name);
}
Console.WriteLine();
Console.WriteLine("Average Age in Team 2 is: " + team2.AverageAge(players2) + " age");
Console.WriteLine();
Referee referee = new Referee("Georgi Yankov", 32);
Referee assistantReferee1 = new Referee("Bojidar Nikolov", 29);
Referee assistantReferee2 = new Referee("Valentin Angelov", 30);

List<Referee> referees = new List<Referee>();
referees.Add(referee);
referees.Add(assistantReferee1);
referees.Add(assistantReferee2);

Console.WriteLine("The Referees for the match are:");
foreach (var item in referees)
{
    Console.WriteLine(item.Name + " " + item.Age);
}

Goal goal1 = new Goal(footballPlayer6, 22);
Goal goal2 = new Goal(footballPlayer19, 70);
Goal goal3 = new Goal(footballPlayer11, 88);

List<Goal> goals = new List<Goal>();
goals.Add(goal1);
goals.Add(goal2);
goals.Add(goal3);

int team1Goals = 0;
int team2Goals = 0;

Console.WriteLine();
foreach (var item in goals)
{
    if (team1.Players.Contains(item.Player))
    {
        team1Goals++;
        Console.WriteLine(item.ToString());
        Console.WriteLine($"Result is {team1Goals}:{team2Goals}");
    }
    else
    {
        team2Goals++;
        Console.WriteLine(item.ToString());
        Console.WriteLine($"Result is {team1Goals}:{team2Goals}");
    }
}
Console.WriteLine();
Console.WriteLine($"Final Result is {team1Goals}:{team2Goals}!");
if (team1Goals > team2Goals)
{
    Console.WriteLine("Winner is Team 1!");
}
else if (team1Goals < team2Goals)
{
    Console.WriteLine("Winner is Team 2!");
}
else
{
    Console.WriteLine("Draw!");
}

