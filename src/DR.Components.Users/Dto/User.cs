using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Users.Dto
{
    [Serializable]
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public int Salutation { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
