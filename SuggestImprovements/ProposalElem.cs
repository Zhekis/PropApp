using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestImprovements
{
    internal class ProposalElem
    {
        public int Number { get; set; }

        public DateOnly Date { get; set; }

        public string Author { get; set; }

        public string Department { get; set; }

        public string Area { get; set; }

        public string Loss { get; set; }

        public string Judgment { get; set; }

        public string Description { get; set; } = null!;

        public int? Costs { get; set; }

        public int? ActualCosts { get; set; }

        public int? EconomicEffect { get; set; }

        public bool IsCompleted { get; set; }

        public DateOnly? DateComplete { get; set; }
    }
}
