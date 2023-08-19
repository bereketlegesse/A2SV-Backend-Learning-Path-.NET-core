using System;
using System.Collections.Generic;
using System.Text;
using day10.Domain.Common;

namespace day10.Domain
{
    public class PostType : BaseDomainEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
