using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ProgrammingReport : IDisciplineReport
    {
        public void GenerateTitlePage()
        {
            Console.WriteLine("Cover letter for a programming report");
        }

        public void GenerateObjective()
        {
            Console.WriteLine("Objective of the programming report");
        }

        public void GenerateTasks()
        {
            Console.WriteLine("Tasks for the programming report");
        }

        public void GenerateTheory()
        {
            Console.WriteLine("Theoretical background for the programming report");
        }

        public void GenerateExecution()
        {
            Console.WriteLine("Description of the implementation/program code for the programming report");
        }

        public void GenerateResults()
        {
            Console.WriteLine("Results of the programming report");
        }

        public void GenerateAnalysis()
        {
            Console.WriteLine("Analysis of the results for the programming report");
        }

        public void GenerateConclusion()
        {
            Console.WriteLine("Conclusion for the programming report");
        }

        public void GenerateAttachment()
        {
            Console.WriteLine("Programe code for the programming report");
        }
    }
}
