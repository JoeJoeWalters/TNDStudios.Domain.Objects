using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Definition of a timesheet line
    /// </summary>
    [JsonObject(Description = "Timesheet Line Object", MemberSerialization = MemberSerialization.OptOut)]
    public class TimesheetLine : DomainObject<Guid>
    {
        /// <summary>
        /// The role this timesheet line is for
        /// </summary>
        [JsonProperty]
        public virtual Role Role { get; set; } = new Role();

        /// <summary>
        /// The rate code used by the organisation
        /// </summary>
        [JsonProperty]
        public virtual String InternalRateCode { get; set; } = String.Empty;

        /// <summary>
        /// The rate code used by the client
        /// </summary>
        [JsonProperty]
        public virtual String ExternalRateCode { get; set; } = String.Empty;

        /// <summary>
        /// The volume of the rate for the timesheet line
        /// </summary>
        [JsonProperty]
        public virtual Decimal Volume { get; set; } = (Decimal)0;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TimesheetLine()
        {
            PKId = Guid.NewGuid(); // Default New Id for the line Id
        }
    }
}
