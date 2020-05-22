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
    /// Message
    /// </summary>
    [DataContract]
    public partial class MessageBatch : IEquatable<MessageBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageBatch() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatch" /> class.
        /// </summary>
        /// <param name="messageType">Indicates the type of message to create.</param>
        /// <param name="contentType">Indicates the content included within the message.</param>
        /// <param name="name">Name of the message. Must be 100 or fewer characters. For Content Builder messages, use this format: content name-unique identifier. For example: 'my test content message-0debaa7a11e11b0a00b12345ef384b1z'.</param>
        /// <param name="application">App used to send message.</param>
        public MessageBatch(List<string> deviceTokens = default(List<string>), List<string> subscriberKeys = default(List<string>), MessageBatchMessage message = default(MessageBatchMessage))
        {
            // to ensure "deviceTokens" or "subscriberKeys" is required (not null)
            if (deviceTokens == null && subscriberKeys == null)
            {
                throw new InvalidDataException("Either deviceTokens or subscriberKeys are required properties for MessageBatch and cannot be null");
            }
            else
            {
                this.DeviceTokens = deviceTokens;
                this.SubscriberKeys = subscriberKeys;
            }

            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for MessageBatch and cannot be null");
            }
            else
            {
                this.Message = message;
            }
        }

        [DataMember(Name = "deviceTokens", EmitDefaultValue = false)]
        public List<string> DeviceTokens { get; set; }

        [DataMember(Name = "subscriberKeys", EmitDefaultValue = false)]
        public List<string> SubscriberKeys { get; set; }

        [DataMember(Name = "inclusionTags", EmitDefaultValue = false)]
        public List<string> InclusionTags { get; set; }

        [DataMember(Name = "exclusionTags", EmitDefaultValue = false)]
        public List<string> ExclusionTags { get; set; }

        [DataMember(Name = "sendTime", EmitDefaultValue = false)]
        public DateTime SendTime { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false)]
        public MessageBatchMessage Message { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        [DataMember(Name = "mutable-content", EmitDefaultValue = false)]
        public bool MutableContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageBatch {\n");
            sb.Append("  DeviceTokens: ").Append(DeviceTokens).Append("\n");
            sb.Append("  SubscriberKeys: ").Append(SubscriberKeys).Append("\n");
            sb.Append("  InclusionTags: ").Append(InclusionTags).Append("\n");
            sb.Append("  ExclusionTags: ").Append(ExclusionTags).Append("\n");
            sb.Append("  SendTime: ").Append(SendTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  MutableContent: ").Append(MutableContent).Append("\n");
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
            return this.Equals(input as MessageBatch);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageBatch input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeviceTokens == input.DeviceTokens ||
                    (this.DeviceTokens != null &&
                    this.DeviceTokens.Equals(input.DeviceTokens))
                ) &&
                (
                    this.SubscriberKeys == input.SubscriberKeys ||
                    (this.SubscriberKeys != null &&
                    this.SubscriberKeys.Equals(input.SubscriberKeys))
                ) &&
                (
                    this.InclusionTags == input.InclusionTags ||
                    (this.InclusionTags != null &&
                    this.InclusionTags.Equals(input.InclusionTags))
                ) &&
                (
                    this.ExclusionTags == input.ExclusionTags ||
                    (this.ExclusionTags != null &&
                    this.ExclusionTags.Equals(input.ExclusionTags))
                ) &&
                (
                    this.SendTime == input.SendTime ||
                    (this.SendTime != null &&
                    this.SendTime.Equals(input.SendTime))
                ) &&
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.Subtitle == input.Subtitle ||
                    (this.Subtitle != null &&
                    this.Subtitle.Equals(input.Subtitle))
                ) &&
                (
                    this.MutableContent == input.MutableContent ||
                    (this.MutableContent != null &&
                    this.MutableContent.Equals(input.MutableContent))
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
                if (this.DeviceTokens != null)
                    hashCode = hashCode * 59 + this.DeviceTokens.GetHashCode();
                if (this.SubscriberKeys != null)
                    hashCode = hashCode * 59 + this.SubscriberKeys.GetHashCode();
                if (this.InclusionTags != null)
                    hashCode = hashCode * 59 + this.InclusionTags.GetHashCode();
                if (this.ExclusionTags != null)
                    hashCode = hashCode * 59 + this.ExclusionTags.GetHashCode();
                if (this.SendTime != null)
                    hashCode = hashCode * 59 + this.SendTime.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Subtitle != null)
                    hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
                if (this.MutableContent != null)
                    hashCode = hashCode * 59 + this.MutableContent.GetHashCode();
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
