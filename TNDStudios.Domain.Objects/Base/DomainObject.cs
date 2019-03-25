using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Implementation of the base domain object class
    /// </summary>
    /// <typeparam name="PKType">The primary key data type</typeparam>
    [JsonObject(Description = "Domain Object", MemberSerialization = MemberSerialization.OptOut)]
    public abstract class DomainObject<PKType> : IDomainObject<PKType>
    {
        /// <summary>
        /// The primary key for the domain object (for wherever it is held locally etc.)
        /// </summary>
        [JsonProperty]
        public virtual PKType PKId { get; set; }

        /// <summary>
        /// Internal Id for the domain object item (Used by our organisation)
        /// </summary>
        [JsonProperty]
        public virtual String InternalId { get; set; }

        /// <summary>
        /// External Id for the domain object item (Used by the client)
        /// </summary>
        [JsonProperty]
        public virtual String ExternalId { get; set; }
    }
}
