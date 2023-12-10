using System;
using System.Collections.Generic;

namespace SuggestImprovements;

public partial class Proposal
{
    public int Number { get; set; }

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

    public virtual Area AreaNavigation { get; set; } = null!;

    public virtual Author AuthorNavigation { get; set; } = null!;

    public virtual Judgment JudgmentNavigation { get; set; } = null!;

    public virtual Loss LossNavigation { get; set; } = null!;
}
