using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLab
{

    //This is a simple program that creates a student profile, 
    //assigns them points and sets a rank for them based on the
    //# of points they have.

    //enumerate the available ranks
    public enum Rank
    {
        Grasshopper,
        Journeyman,
        Rockstar,
        Ninja,
        Jedi
    }

    //create a Student class
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

        //They get one point once they finish a program 
        public int FinishedProgram()
        {
            points += 1;
            RankCheck();
            return points;
        }

        //They get 10 points if they help a fellow student
        public int HelpedStudent()
        {
            points += 10;
            RankCheck();
            return points;
        }


        //This functions checks how many points they have and changes their rank based on the # of points they have
        public void RankCheck()
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
        }
    }

    //I am trying to create an instance of student, but I keep getting an error that
    //says "seth" does not exist in the current context. I am trying to create a new
    //instance of Student and passing it in the inital name value of seth.
    //WHY WONT IT WORK GODDAMMIT!
    
    class Program
    {
        Student newStudent = new Student();
    }
}
