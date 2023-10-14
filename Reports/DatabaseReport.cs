using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DatabaseReport : IDisciplineReport
    {
        public void GenerateTitlePage()
        {
            Console.WriteLine("Cover letter for a database report");
        }

        public void GenerateObjective()
        {
            Console.WriteLine("Objective of the database report");
        }

        public void GenerateTasks()
        {
            Console.WriteLine("Tasks for the database report");
        }

        public void GenerateTheory()
        {
            Console.WriteLine("Theoretical background for the database report");
        }

        public void GenerateExecution()
        {
            Console.WriteLine("Description of the implementation/program code for the database report");
        }

        public void GenerateResults()
        {
            Console.WriteLine("Results of the database report");
        }

        public void GenerateAnalysis()
        {
            Console.WriteLine("Analysis of the results for the database report");
        }

        public void GenerateConclusion()
        {
            Console.WriteLine("Conclusion for the database report");
        }
        public void GenerateAttachment()
        {
            Console.WriteLine("Diagram for the database report");
        }

    }
}
