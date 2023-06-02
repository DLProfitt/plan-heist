using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Plan Your Heist!");
        Team heistTeam = new Team();

        heistTeam.AddMember(new TeamMember("John", 5, .25));
        heistTeam.AddMember(new TeamMember("Sarah", 7, .75));
        heistTeam.AddMember(new TeamMember("Bob", 4, .55));
        heistTeam.AddMember(new TeamMember("Alice", 8, .65));

        foreach (TeamMember member in heistTeam.Members)
        {
            Console.WriteLine($"Name: {member.Name}, Skill Level: {member.SkillLevel}, Courage Factor: {member.CourageFactor}");
        }
    }

    public class TeamMember
    {
        public string Name { get; private set; }
        public int SkillLevel { get; private set; }
        public double CourageFactor { get; private set; }

        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }

    public class Team
    {
        public List<TeamMember> Members { get; private set; }

        public Team()
        {
            Members = new List<TeamMember>();
        }

        public void AddMember(TeamMember member)
        {
            Members.Add(member);
        }
    }
}
