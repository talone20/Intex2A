using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex2A.Models
{
    public partial class PublicBooks
    {
        public byte[] Id { get; set; }
        public byte[] Description { get; set; }
        public byte[] Title { get; set; }
        public byte[] Author { get; set; }
        public byte[] Link { get; set; }
    }
}
