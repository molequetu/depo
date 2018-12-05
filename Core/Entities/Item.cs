namespace Depo.Core.Entities
{
    /// <summary>
    /// Represents an item in the
    /// warehouse. Can be anything,
    /// its id is a barcode unique id
    /// </summary>
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
