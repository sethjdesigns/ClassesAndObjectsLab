using System;

public enum Rank 
{
    Grasshopper,
    Journeyman,
    Rockstar,
    Ninja,
    Jedi
}

public class Student
{
    private int points;
    private string name;
    private Rank currentRank = Rank.Grasshopper;

    public Student(string name) 
    {
        points = 0;
        this.name = name;
    }

    public int FinishedProgram()
    {
        points += 1;
        RankCheck();
        return points;
    }

    public int HelpedStudent()
    {
        points += 10;
        RankCheck();
        return points;
    }

    public Rank RankCheck() 
    {
        if (this.points < 5) 
        {
            currentRank = Rank.Grasshopper;
        }
        else if (this.points > 5 && this.points < 10) 
        {
            currentRank = Rank.Journeyman;
        }
        else if (this.points > 10 && this.points < 15) 
        {
            currentRank = Rank.Rockstar;
        }
        else if (this.points > 15 && this.points < 20) 
        {
            currentRank = Rank.Ninja;
        }
        else if (this.points > 25 && this.points < 30) 
        {
            currentRank = Rank.Jedi;
        }
        return currentRank;
    }

    public string ToString() 
    {
        return this.name + " " + this.points + " " + this.currentRank; 
    }
}
