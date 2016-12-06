using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public virtual int MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}