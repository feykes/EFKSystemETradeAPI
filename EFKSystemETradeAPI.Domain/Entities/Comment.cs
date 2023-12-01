using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public int Score { get; set; }
    }
}
