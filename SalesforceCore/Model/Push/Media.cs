using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace SalesforceCore.Model.Push
{
    /// <summary>
    /// Media
    /// </summary>
    [DataContract]
    public partial class Media : IEquatable<Media>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Media() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media" /> class.
        /// </summary>
        /// <param name="androidUrl">URL for the media to send to Android devices.</param>
        /// <param name="iosUrl">URL for the media to send to iOS devices.</param>
        /// <param name="alt">Text to display if the message cannot include the specified rich media.</param>
        public Media(string androidUrl = default(string), string iosUrl = default(string), string alt = default(string))
        {
            this.AndroidUrl = androidUrl;
            this.IosUrl = iosUrl;
            this.Alt = alt;
        }

        /// <summary>
        /// URL for the media to send to Android devices
        /// </summary>
        [DataMember(Name = "androidUrl", EmitDefaultValue = false)]
        public string AndroidUrl { get; set; }

        /// <summary>
        /// URL for the media to send to iOS devices
        /// </summary>
        [DataMember(Name = "iosUrl", EmitDefaultValue = false)]
        public string IosUrl { get; set; }

        /// <summary>
        /// Text to display if the message cannot include the specified rich media
        /// </summary>
        [DataMember(Name = "alt", EmitDefaultValue = false)]
        public string Alt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Media {\n");
            sb.Append("  AndroidUrl: ").Append(AndroidUrl).Append("\n");
            sb.Append("  IosUrl: ").Append(IosUrl).Append("\n");
            sb.Append("  Alt: ").Append(Alt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Media);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Media input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AndroidUrl == input.AndroidUrl ||
                    (this.AndroidUrl != null &&
                    this.AndroidUrl.Equals(input.AndroidUrl))
                ) &&
                (
                    this.IosUrl == input.IosUrl ||
                    (this.IosUrl != null &&
                    this.IosUrl.Equals(input.IosUrl))
                ) &&
                (
                    this.Alt == input.Alt ||
                    (this.Alt != null &&
                    this.Alt.Equals(input.Alt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AndroidUrl != null)
                    hashCode = hashCode * 59 + this.AndroidUrl.GetHashCode();
                if (this.IosUrl != null)
                    hashCode = hashCode * 59 + this.IosUrl.GetHashCode();
                if (this.Alt != null)
                    hashCode = hashCode * 59 + this.Alt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
