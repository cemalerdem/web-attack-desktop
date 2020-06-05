using System.Collections.Generic;

namespace Web_Attack.Common.Models.Response
{
    public class UserRegisterResponse
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}