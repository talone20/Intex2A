using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex2A.Views.Home.Data
{
    public class CustomIdentityUser: IdentityUser
    {
        [Column(TypeName = "boolean")]
        public override bool TwoFactorEnabled { get; set; }
    }
}
