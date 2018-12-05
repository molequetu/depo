using System.Runtime.InteropServices.ComTypes;
using Depo.Core.Enums;

namespace Depo.Core.Entities
{
    /// <summary>
    /// Defines the transaction of importing
    /// or exporting items from a bin. Basic
    /// table for these functionality
    /// </summary>
    public class Action
    {
        // auto generated uuid
        public string Id { get; set; }

        public ActionType Type { get; set; }

        public string BinId { get; set; }
        
        public string ItemId { get; set; }

        public string UserId { get; set; } 

        public int Quantity { get; set; }

        public Bin Bin { get; set; }

        public Item Item { get; set; }

    }
}
