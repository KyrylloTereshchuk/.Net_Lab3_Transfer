using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            ReportFactory factory1 = new ProgrammingReportFactory();
            IDisciplineReport report1 = factory1.CreateReport();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Example of programming report:\n");
            Console.ResetColor();

            report1.GenerateTitlePage();
            report1.GenerateObjective();
            report1.GenerateTasks();
            report1.GenerateTheory();
            report1.GenerateExecution();
            report1.GenerateResults();
            report1.GenerateAnalysis();
            report1.GenerateConclusion();
            report1.GenerateAttachment();


            ReportFactory factory2 = new DatabaseReportFactory();
            IDisciplineReport report2 = factory2.CreateReport();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nExample of database report:\n");
            Console.ResetColor();

            report2.GenerateTitlePage();
            report2.GenerateObjective();
            report2.GenerateTasks();
            report2.GenerateTheory();
            report2.GenerateExecution();
            report2.GenerateResults();
            report2.GenerateAnalysis();
            report2.GenerateConclusion();
            report2.GenerateAttachment();


            ReportFactory factory3 = new ComputerNetworksReportFactory();
            IDisciplineReport report3 = factory3.CreateReport();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nExample of computer networks report:\n");
            Console.ResetColor();

            report3.GenerateTitlePage();
            report3.GenerateObjective();
            report3.GenerateTasks();
            report3.GenerateTheory();
            report3.GenerateExecution();
            report3.GenerateResults();
            report3.GenerateAnalysis();
            report3.GenerateConclusion();
            report3.GenerateAttachment();
        }

    }

}

