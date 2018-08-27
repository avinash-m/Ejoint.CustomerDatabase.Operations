using System;

namespace Ejoint.CustomerDatabase.Model
{
    public class Login
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int MaxAttempts { get; set; }
    }
}
