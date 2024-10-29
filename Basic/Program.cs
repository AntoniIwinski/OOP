using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

Group g1 = new Group("5c", 20, "Obsti",new string[20]);
Group g2 = new Group("5b", 23, "Radar",new string[23]);

enum GameChoices
{
    PAPER, ROCK, SCISSORS 
}
class Group(string name,int count,string mainTeacher, Array students)
{
    public string Name = name;
    public int Count = count;
    public string MainTeacher = mainTeacher;
    public Array Students = students;

    
     
}

