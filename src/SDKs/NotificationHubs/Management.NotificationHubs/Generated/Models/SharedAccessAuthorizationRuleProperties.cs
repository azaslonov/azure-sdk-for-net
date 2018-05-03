// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SharedAccessAuthorizationRule properties.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        /// <param name="primaryKey">The primary key that was used.</param>
        /// <param name="secondaryKey">The secondary key that was used.</param>
        /// <param name="keyName">The name of the key that was used.</param>
        /// <param name="claimType">The type of the claim.</param>
        /// <param name="claimValue">The value of the claim.</param>
        /// <param name="rights">The rights associated with the rule.</param>
        /// <param name="createdTime">The time at which the authorization rule
        /// was created.</param>
        /// <param name="modifiedTime">The most recent time the rule was
        /// updated.</param>
        /// <param name="revision">The revision number for the rule.</param>
        public SharedAccessAuthorizationRuleProperties(string primaryKey = default(string), string secondaryKey = default(string), string keyName = default(string), string claimType = default(string), string claimValue = default(string), IList<AccessRights?> rights = default(IList<AccessRights?>), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? modifiedTime = default(System.DateTime?), int? revision = default(int?))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            ClaimType = claimType;
            ClaimValue = claimValue;
            Rights = rights;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets the secondary key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the key that was used.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Gets or sets the type of the claim.
        /// </summary>
        [JsonProperty(PropertyName = "claimType")]
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or sets the value of the claim.
        /// </summary>
        [JsonProperty(PropertyName = "claimValue")]
        public string ClaimValue { get; set; }

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Gets or sets the time at which the authorization rule was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the most recent time the rule was updated.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public System.DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the revision number for the rule.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

    }
}
