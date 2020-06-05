using System;

namespace Web_Attack.Common.Models.Response
{
    public class UserListDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}