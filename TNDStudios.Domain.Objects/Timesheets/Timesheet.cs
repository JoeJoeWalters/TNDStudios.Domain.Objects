using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Object to represent a timesheet object
    /// </summary>
    [JsonObject(Description = "Timesheet Object", MemberSerialization = MemberSerialization.OptOut)]
    public class Timesheet : DomainObject<Guid>
    {
        /// <summary>
        /// The start date of the timesheet
        /// </summary>
        [JsonProperty]
        public virtual DateTime StartDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// The end date of the timesheet
        /// </summary>
        [JsonProperty]
        public virtual DateTime EndDate { get; set; } = DateTime.MaxValue;

        /// <summary>
        /// The person this timesheet is for
        /// </summary>
        [JsonProperty]
        public virtual Person Worker { get; set; } = new Person() { };

        /// <summary>
        /// Empty list of timesheet lines by default
        /// </summary>
        [JsonProperty]
        public virtual List<TimesheetLine> Lines { get; set; } = new List<TimesheetLine>() { };

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Timesheet()
        {
            PKId = Guid.NewGuid(); // Default Id
        }
    }
}
