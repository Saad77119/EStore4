using System;
using System.Collections.Generic;



namespace EStore.Server.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Is_role { get; set; }
        public bool Is_verified { get; set; }
        public string Is_token { get; set; }
    }
}
