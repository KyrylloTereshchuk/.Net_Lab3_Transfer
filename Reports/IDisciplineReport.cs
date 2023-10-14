using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IDisciplineReport
    {
        void GenerateTitlePage();
        void GenerateObjective();
        void GenerateTasks();
        void GenerateTheory();
        void GenerateExecution();
        void GenerateResults();
        void GenerateAnalysis();
        void GenerateConclusion();
        void GenerateAttachment();
    }
}
