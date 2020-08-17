using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoggerAssistant.API.Model
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public string Password { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public string AccountName { get; set; }
        public string Country { get; set; }
        public DateTime LastVisited { get; set; }
        public List<Log> Logs { get; set; }
    }
}
