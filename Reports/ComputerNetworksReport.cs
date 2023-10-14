using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ComputerNetworksReport : IDisciplineReport
    {
        public void GenerateTitlePage()
        {
            Console.WriteLine("Cover letter for a computer networks report");
        }

        public void GenerateObjective()
        {
            Console.WriteLine("Objective of the computer networks report");
        }

        public void GenerateTasks()
        {
            Console.WriteLine("Tasks for the computer networks report");
        }

        public void GenerateTheory()
        {
            Console.WriteLine("Theoretical background for the computer networks report");
        }

        public void GenerateExecution()
        {
            Console.WriteLine("Description of the implementation/program code for the computer networks report");
        }

        public void GenerateResults()
        {
            Console.WriteLine("Results of the computer networks report");
        }

        public void GenerateAnalysis()
        {
            Console.WriteLine("Analysis of the results for the computer networks report");
        }

        public void GenerateConclusion()
        {
            Console.WriteLine("Conclusion for the computer networks report");
        }

        public void GenerateAttachment()
        {
            Console.WriteLine("Networks scheme for the computer networks report");
        }

    }
}
