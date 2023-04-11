using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex2A.Models
{
    public partial class PublicBiological
    {
        public byte[] Id { get; set; }
        public byte[] Racknumber { get; set; }
        public byte[] Bagnumber { get; set; }
        public byte[] Previouslysampled { get; set; }
        public byte[] Initials { get; set; }
        public byte[] Clusternumber { get; set; }
        public byte[] Date { get; set; }
        public byte[] Notes { get; set; }
    }
}
