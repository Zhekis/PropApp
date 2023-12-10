using System;
using System.Collections.Generic;

namespace SuggestImprovements;

public partial class Position
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
