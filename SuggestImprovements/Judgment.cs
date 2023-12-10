using System;
using System.Collections.Generic;

namespace SuggestImprovements;

public partial class Judgment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProposalKeys> Proposals { get; set; } = new List<ProposalKeys>();
}
