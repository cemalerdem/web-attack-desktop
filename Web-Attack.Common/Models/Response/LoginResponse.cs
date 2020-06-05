using System;
using System.Collections.Generic;

namespace Web_Attack.Common.Models.Response
{
    public class LoginResponse
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
        public Dictionary<string, string> UserInfo { get; set; }
        public DateTime? ExpireDate { get; set; }
    }

}