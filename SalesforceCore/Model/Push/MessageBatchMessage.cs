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
    /// MessageBatchMessage
    /// </summary>
    [DataContract]
    public partial class MessageBatchMessage : IEquatable<MessageBatchMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageBatchMessage() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchMessage" /> class.
        /// </summary>
        /// <param name="messageType">Indicates the type of message to create.</param>
        /// <param name="contentType">Indicates the content included within the message.</param>
        /// <param name="name">Name of the message. Must be 100 or fewer characters. For Content Builder messages, use this format: content name-unique identifier. For example: 'my test content message-0debaa7a11e11b0a00b12345ef384b1z'.</param>
        /// <param name="application">App used to send message.</param>
        public MessageBatchMessage(string alert = default(string))
        {
            // to ensure "messageType" is required (not null)
            if (alert == null)
            {
                throw new InvalidDataException("alert is a required property for MessageBatchMessage and cannot be null");
            }
            else
            {
                this.Alert = alert;
            }
        }

        [DataMember(Name = "alert", EmitDefaultValue = false)]
        public string Alert { get; set; }

        [DataMember(Name = "sound", EmitDefaultValue = false)]
        public string Sound { get; set; }

        [DataMember(Name = "badge", EmitDefaultValue = false)]
        public string Badge { get; set; }

        [DataMember(Name = "content-available", EmitDefaultValue = false)]
        public int? ContentAvailable { get; set; }

        [DataMember(Name = "openDirect", EmitDefaultValue = false)]
        public string OpenDirect { get; set; }

        [DataMember(Name = "keys", EmitDefaultValue = false)]
        public List<MessageKey> Keys { get; set; }

        [DataMember(Name = "custom", EmitDefaultValue = false)]
        public Dictionary<string, object> Custom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Alert: ").Append(Alert).Append("\n");
            sb.Append("  Sound: ").Append(Sound).Append("\n");
            sb.Append("  Badge: ").Append(Badge).Append("\n");
            sb.Append("  ContentAvailable: ").Append(ContentAvailable).Append("\n");
            sb.Append("  OpenDirect: ").Append(OpenDirect).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
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
            return this.Equals(input as MessageBatchMessage);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageBatchMessage input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Sound == input.Sound ||
                    (this.Sound != null &&
                    this.Sound.Equals(input.Sound))
                ) &&
                (
                    this.Badge == input.Badge ||
                    (this.Badge != null &&
                    this.Badge.Equals(input.Badge))
                ) &&
                (
                    this.ContentAvailable == input.ContentAvailable ||
                    (this.ContentAvailable != null &&
                    this.ContentAvailable.Equals(input.ContentAvailable))
                ) &&
                (
                    this.OpenDirect == input.OpenDirect ||
                    (this.OpenDirect != null &&
                    this.OpenDirect.Equals(input.OpenDirect))
                ) &&
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))
                ) &&
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
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
                if (this.Alert != null)
                    hashCode = hashCode * 59 + this.Alert.GetHashCode();
                if (this.Sound != null)
                    hashCode = hashCode * 59 + this.Sound.GetHashCode();
                if (this.Badge != null)
                    hashCode = hashCode * 59 + this.Badge.GetHashCode();
                if (this.ContentAvailable != null)
                    hashCode = hashCode * 59 + this.ContentAvailable.GetHashCode();
                if (this.OpenDirect != null)
                    hashCode = hashCode * 59 + this.OpenDirect.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
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
