/*
C# Coding :Player Rating
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement
Create a class "Player" with the following members:

firstName: string
lastName: string
Player(firstName: string, lastName: string)
getName(): string
abstract getRating(): int
The method getName() should return the fullname of the player which is a combination of firstName and lastName separated by a single space.

Create a subclass "CricketPlayer" with the following members:

averageRuns: double
CricketPlayer(firstName: string, lastName: string, averageRuns: double)
getRating(): int
The rating of a cricket player is based on the following slab:

if averageRuns > 55 then 7
if averageRuns > 50 then 6
if averageRuns > 40 then 5
if averageRuns > 30 then 3
if averageRuns > 20 then 2
if averageRuns <=20 then 1
Create a subclss of Player class "FootballPlayer" with the following members:

goals: int
FootballPlayer(firstName: string, lastName: string, goals: int)
getRating(): int
The rating of a football player is based on the following slab:

if goals > 20 then 5
if goals > 15 then 4
if goals > 10 then 3
if goals > 5 then 2
if goals <=5 then 1


Note : Do not define the Main() method

EXECUTION TIME LIMIT
Default.

*/

using System;

public abstract class Player
{
    public string firstName, lastName;
    
    public Player(){
        
    }
    
    Player(string firstName, string lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }
    
    public string getName(){
        return firstName + " " + lastName;
    }
    
    public abstract int getRating();
}

class CricketPlayer : Player
{
    double averageRuns;
    
    public CricketPlayer(string firstName, string lastName, double averageRuns){
        this.firstName = firstName;
        this.lastName = lastName;
        this.averageRuns = averageRuns;
    }
    
    public override int getRating(){
        if(averageRuns > 55) return 7;
        else if(averageRuns > 50) return 6;
        else if(averageRuns > 40) return 5;
        else if(averageRuns > 30) return 3;
        else if(averageRuns > 20) return 2;
        else return 1;
    }
}

class FootballPlayer : Player{
    int goals;
    
    public FootballPlayer(string firstName, string lastName, int goals){
        this.firstName = firstName;
        this.lastName = lastName;
        this.goals = goals;
    }
    
    public override int getRating(){
        if(goals > 20) return 5;
        else if(goals > 15) return 4;
        else if(goals > 10) return 3;
        else if(goals > 5) return 2;
        else return 1;
    }
}