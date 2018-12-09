namespace Depo.Core.Entities
{
    /// <summary>
    /// Bin domain entity, describes where
    /// items are stored. Its id is a unique
    /// barcode id
    /// </summary>
    public class Bin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// This can be a separate entity with its
        /// properties
        /// </summary>
        public string Address { get; set; }

        public string HallId { get; set; }
        public Hall Hall { get; set; }
    }
}
