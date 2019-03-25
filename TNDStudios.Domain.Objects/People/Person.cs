using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects
{
    /// <summary>
    /// Implementation of a "person"
    /// </summary>
    [JsonObject(Description = "Person Object", MemberSerialization = MemberSerialization.OptOut)]
    public class Person : DomainObject<Guid>
    {
        /// <summary>
        /// The title of the person
        /// </summary>
        [JsonProperty]
        public virtual String Title { get; set; } = String.Empty;

        /// <summary>
        /// Forename of the person
        /// </summary>
        [JsonProperty]
        public virtual String Forename { get; set; } = String.Empty;

        /// <summary>
        /// Middlename of the person
        /// </summary>
        [JsonProperty]
        public virtual String Middlenames { get; set; } = String.Empty;

        /// <summary>
        /// Surname of the person
        /// </summary>
        [JsonProperty]
        public virtual String Surname { get; set; } = String.Empty;

        /// <summary>
        /// Date of Birth
        /// </summary>
        [JsonProperty]
        public virtual DateTime DOB { get; set; } = DateTime.MinValue;

        /// <summary>
        /// National Identification Number / Social Securoty Number
        /// </summary>
        [JsonProperty]
        public virtual String NINumber { get; set; } = String.Empty;
    }
}
