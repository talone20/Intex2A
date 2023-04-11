using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex2A.Models
{
    public partial class PublicNewsarticle
    {
        public byte[] Id { get; set; }
        public byte[] Description { get; set; }
        public byte[] Author { get; set; }
        public byte[] Title { get; set; }
        public byte[] Urltoimage { get; set; }
        public byte[] Url { get; set; }
    }
}
