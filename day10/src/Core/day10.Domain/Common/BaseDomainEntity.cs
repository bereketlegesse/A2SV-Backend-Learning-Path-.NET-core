using System;
using System.Collections.Generic;
using System.Text;

namespace day10.Domain.Common;

public abstract class BaseDomainEntity
{
    public int PostId { get; set; }
    public DateTime CreatedAt { get; set; }
}
