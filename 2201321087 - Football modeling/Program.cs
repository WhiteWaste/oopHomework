// See https://aka.ms/new-console-template for more information
using _2201321087___Football_modeling;

ManOfTheFoot[] t1Players =
{
    new Striker("t1Str", 21, 0, 1.81),  //1
    new Striker("t1Str", 21, 0, 1.81),  //2
    new Striker("t1Str", 21, 0, 1.81),  //3
    new Striker("t1Str", 21, 0, 1.81),  //4
    new Striker("t1Str", 21, 0, 1.81),  //5
    new Striker("t1Str", 21, 0, 1.81),  //6
    new Striker("t1Str", 21, 0, 1.81),  //7
    new Striker("t1Str", 21, 0, 1.81),  //8
    new Striker("t1Str", 21, 0, 1.81),  //9
    new Striker("t1Str", 21, 0, 1.81),  //10
    new Striker("t1Str", 21, 0, 1.81),  //11
};

ManOfTheFoot[] t2Players =
{
    new Striker("t2Str", 22, 0, 1.82),  //1
    new Striker("t2Str", 22, 0, 1.82),  //2
    new Striker("t2Str", 22, 0, 1.82),  //3
    new Striker("t2Str", 22, 0, 1.82),  //4
    new Striker("t2Str", 22, 0, 1.82),  //5
    new Striker("t2Str", 22, 0, 1.82),  //6
    new Striker("t2Str", 22, 0, 1.82),  //7
    new Striker("t2Str", 22, 0, 1.82),  //8
    new Striker("t2Str", 22, 0, 1.82),  //9
    new Striker("t2Str", 22, 0, 1.82),  //10
    new Striker("t2Str", 22, 0, 1.82),  //11
};

Team tem1 = new Team(new Coach("t1Coach", 21), t1Players); tem1.TeamName = "t1";
Team tem2 = new Team(new Coach("t2Coach", 22), t2Players); tem2.TeamName = "t2";

Referee mainRef = new Referee();
Referee assRef1 = new Referee("a1", 32);
Referee assRef2 = new Referee("a2", 33);

Console.WriteLine(mainRef.Name);

Game gam = new Game(tem1, tem2, mainRef, assRef1, assRef2);