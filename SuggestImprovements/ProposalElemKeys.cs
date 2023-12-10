using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestImprovements
{
    public class ProposalElemKeys
    {
        public int NumberKey { get; set; }

        public DateOnly Date { get; set; }

        public int Author { get; set; }

        public int Area { get; set; }

        public int Loss { get; set; }

        public int Judgment { get; set; }

        public string Description { get; set; } = null!;

        public int? Costs { get; set; }

        public int? ActualCosts { get; set; }

        public int? EconomicEffect { get; set; }

        public bool IsCompleted { get; set; }

        public DateOnly? DateComplete { get; set; }
    }
}
