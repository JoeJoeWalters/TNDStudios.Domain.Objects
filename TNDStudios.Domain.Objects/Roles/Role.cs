using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Implementation of a Job / Role
    /// </summary>
    [JsonObject(Description = "Role Object", MemberSerialization = MemberSerialization.OptOut)]
    public class Role : DomainObject<Guid>
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Role()
        {
            PKId = Guid.NewGuid(); // Default Primary Key Id
        }
    }
}
