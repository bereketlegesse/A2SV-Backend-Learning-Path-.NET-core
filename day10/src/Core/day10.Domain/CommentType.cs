using System;
using System.Collections.Generic;
using System.Text;
using day10.Domain.Common;

namespace day10.Domain
{
    public class CommentType : BaseDomainEntity
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }
}
