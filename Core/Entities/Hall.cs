using System;
using System.Collections.Generic;
using System.Text;

namespace Depo.Core.Entities
{
    /// <summary>
    /// A hall describes a hall in
    /// warehouse where bins are located
    /// over the place
    /// </summary>
    public class Hall
    {
        public Hall()
        {
            Bins = new HashSet<Bin>();
        }
        // auto generated
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Bin> Bins { get; private set; }
    }
}
