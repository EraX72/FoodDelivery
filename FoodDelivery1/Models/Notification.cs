using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Last.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int RecipientId { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
