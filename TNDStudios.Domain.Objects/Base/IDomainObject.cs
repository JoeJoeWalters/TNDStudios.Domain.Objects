using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Interface to define a domain object
    /// </summary>
    /// <typeparam name="PKType">The data type of the primary key</typeparam>
    public interface IDomainObject<PKType>
    {
        /// <summary>
        /// The Primary key type
        /// </summary>
        PKType PKId { get; set; }

        /// <summary>
        /// Internal Id for the domain object item (Used by our organisation)
        /// </summary>
        String InternalId { get; set; }

        /// <summary>
        /// External Id for the domain object item (Used by the client)
        /// </summary>
        String ExternalId { get; set; }
    }
}
