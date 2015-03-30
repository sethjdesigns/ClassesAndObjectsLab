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

    public int FinishedProgram(int programs)
    {
        points += 1;
        points *= programs;
        RankCheck();
        return points;
    }

    public int HelpedStudent(int studentsHelped)
    {
        points += 10;
        points *= studentsHelped;
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
        else if (this.points >= 10 && this.points < 15) 
        {
            currentRank = Rank.Rockstar;
        }
        else if (this.points >= 15 && this.points < 20) 
        {
            currentRank = Rank.Ninja;
        }
        else if (this.points >= 20) 
        {
            currentRank = Rank.Jedi;
        }
        return currentRank;
    }

    public override string ToString() 
    {
        return "Name: " + this.name + "\r\n" + "Points: " 
            + this.points + "\r\n" + "Rank: " + this.currentRank + "\r\n";
    }
}