using System.Collections.Generic;

namespace HINVenture.Shared.Models.ViewModels
{
   public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
