using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex2A.Models
{
    public partial class PublicBurialmain
    {
        [Key]
        [Required]
        public double Id { get; set; }
        public byte[] Squarenorthsouth { get; set; }
        public byte[] Headdirection { get; set; }
        public string Sex { get; set; }
        public byte[] Northsouth { get; set; }
        public byte[] Depth { get; set; }
        public byte[] Eastwest { get; set; }
        public byte[] Adultsubadult { get; set; }
        public string Facebundles { get; set; }
        public byte[] Southtohead { get; set; }
        public string Preservation { get; set; }
        public byte[] Fieldbookpage { get; set; }
        public byte[] Squareeastwest { get; set; }
        public byte[] Goods { get; set; }
        public string Text { get; set; }
        public string Wrapping { get; set; }
        public string Haircolor { get; set; }
        public byte[] Westtohead { get; set; }
        public byte[] Samplescollected { get; set; }
        public byte[] Area { get; set; }
        public byte[] Burialid { get; set; }
        public byte[] Length { get; set; }
        public byte[] Burialnumber { get; set; }
        public byte[] Dataexpertinitials { get; set; }
        public byte[] Westtofeet { get; set; }
        public string Ageatdeath { get; set; }
        public byte[] Southtofeet { get; set; }
        public byte[] Excavationrecorder { get; set; }
        public byte[] Photos { get; set; }
        public byte[] Hair { get; set; }
        public byte[] Burialmaterials { get; set; }
        public byte[] Dateofexcavation { get; set; }
        public byte[] Fieldbookexcavationyear { get; set; }
        public byte[] Clusternumber { get; set; }
        public byte[] Shaftnumber { get; set; }
    }
}
