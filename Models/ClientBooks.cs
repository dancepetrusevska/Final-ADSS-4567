using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final4567.Models
{
    public class ClientBooks
    {
        public Book Book { get; set; }
        public List<Client> Clients { get; set; }
        public int SelectedClientId { get; set; }
        public int BookId { get; set; }
    }
}