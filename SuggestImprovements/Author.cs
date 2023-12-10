using System;
using System.Collections.Generic;

namespace SuggestImprovements;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Position { get; set; }

    public int Department { get; set; }

    public virtual Department DepartmentNavigation { get; set; } = null!;

    public virtual Position PositionNavigation { get; set; } = null!;

    public virtual ICollection<ProposalKeys> Proposals { get; set; } = new List<ProposalKeys>();
}
