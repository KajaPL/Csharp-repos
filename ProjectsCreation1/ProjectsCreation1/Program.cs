using System;

namespace ProjectsCreation1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string project = Console.ReadLine();
            int numberOfprojects = 3 * int.Parse(project);

            Console.WriteLine($"The architect {name} will need {numberOfprojects} hours to complete {project} project/s.");

        }
    }
}