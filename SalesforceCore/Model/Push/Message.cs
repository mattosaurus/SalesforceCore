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
    public partial class Message : IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Message() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="messageType">Indicates the type of message to create.</param>
        /// <param name="contentType">Indicates the content included within the message.</param>
        /// <param name="name">Name of the message. Must be 100 or fewer characters. For Content Builder messages, use this format: content name-unique identifier. For example: 'my test content message-0debaa7a11e11b0a00b12345ef384b1z'.</param>
        /// <param name="application">App used to send message.</param>
        public Message(MessageType messageType = default(MessageType), ContentType contentType = default(ContentType), string name = default(string), Application application = default(Application))
        {
            // to ensure "messageType" is required (not null)
            if (messageType == null)
            {
                throw new InvalidDataException("messageType is a required property for Message and cannot be null");
            }
            else
            {
                this.MessageType = messageType;
            }

            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new InvalidDataException("contentType is a required property for Message and cannot be null");
            }
            else
            {
                this.ContentType = contentType;
            }

            // to ensure "messageType" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Message and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "messageType" is required (not null)
            if (application == null)
            {
                throw new InvalidDataException("application is a required property for Message and cannot be null");
            }
            else
            {
                this.Application = application;
            }
        }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "messageType", EmitDefaultValue = false)]
        public MessageType MessageType { get; set; }

        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public ContentType ContentType { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "application", EmitDefaultValue = false)]
        public Application Application { get; set; }

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

        [DataMember(Name = "sendInitiator", EmitDefaultValue = false)]
        public SendInitiatorType? SendInitiator { get; set; }

        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "periodType", EmitDefaultValue = false)]
        public PeriodType? PeriodType { get; set; }

        [DataMember(Name = "messagesPerPeriod", EmitDefaultValue = false)]
        public int? MessagesPerPeriod { get; set; }

        [DataMember(Name = "minutesPerPeriod", EmitDefaultValue = false)]
        public int? MinutesPerPeriod { get; set; }

        [DataMember(Name = "numberOfPeriods", EmitDefaultValue = false)]
        public int? NumberOfPeriods { get; set; }

        [DataMember(Name = "isRollingPeriod", EmitDefaultValue = false)]
        public bool? IsRollingPeriod { get; set; }

        [DataMember(Name = "messageLimit", EmitDefaultValue = false)]
        public int? MessageLimit { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        [DataMember(Name = "mutable-content", EmitDefaultValue = false)]
        public bool? MutableContent { get; set; }

        [DataMember(Name = "tzBased", EmitDefaultValue = false)]
        public bool? TzBased { get; set; }

        [DataMember(Name = "tzPastSendAction", EmitDefaultValue = false)]
        public TzPastSendActionType? TzPastSendAction { get; set; }

        [DataMember(Name = "scheduledTzOffset", EmitDefaultValue = false)]
        public int? ScheduledTzOffset { get; set; }

        [DataMember(Name = "scheduledTzSupportsDst", EmitDefaultValue = false)]
        public bool? ScheduledTzSupportsDst { get; set; }

        [DataMember(Name = "inclusionLists", EmitDefaultValue = false)]
        public List<ResponseId> InclusionLists { get; set; }

        [DataMember(Name = "exclusionLists", EmitDefaultValue = false)]
        public List<ResponseId> ExclusionLists { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusType? Status { get; set; }

        [DataMember(Name = "pageId", EmitDefaultValue = false)]
        public int? PageId { get; set; }

        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        [DataMember(Name = "media", EmitDefaultValue = false)]
        public Media Media { get; set; }

        [DataMember(Name = "geofences", EmitDefaultValue = false)]
        public List<ResponseId> Geofences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Alert: ").Append(Alert).Append("\n");
            sb.Append("  Sound: ").Append(Sound).Append("\n");
            sb.Append("  Badge: ").Append(Badge).Append("\n");
            sb.Append("  ContentAvailable: ").Append(ContentAvailable).Append("\n");
            sb.Append("  OpenDirect: ").Append(OpenDirect).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  SendInitiator: ").Append(SendInitiator).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  MessagesPerPeriod: ").Append(MessagesPerPeriod).Append("\n");
            sb.Append("  MinutesPerPeriod: ").Append(MinutesPerPeriod).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  IsRollingPeriod: ").Append(IsRollingPeriod).Append("\n");
            sb.Append("  MessageLimit: ").Append(MessageLimit).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  MutableContent: ").Append(MutableContent).Append("\n");
            sb.Append("  TzBased: ").Append(TzBased).Append("\n");
            sb.Append("  TzPastSendAction: ").Append(TzPastSendAction).Append("\n");
            sb.Append("  ScheduledTzOffset: ").Append(ScheduledTzOffset).Append("\n");
            sb.Append("  ScheduledTzSupportsDst: ").Append(ScheduledTzSupportsDst).Append("\n");
            sb.Append("  InclusionLists: ").Append(InclusionLists).Append("\n");
            sb.Append("  ExclusionLists: ").Append(ExclusionLists).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Geofences: ").Append(Geofences).Append("\n");
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
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) &&
                (
                    this.Alert == input.Alert ||
                    (this.Alert != null &&
                    this.Alert.Equals(input.Alert))
                ) &&
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
                ) &&
                (
                    this.SendInitiator == input.SendInitiator ||
                    (this.SendInitiator != null &&
                    this.SendInitiator.Equals(input.SendInitiator))
                ) &&
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) &&
                (
                    this.MessagesPerPeriod == input.MessagesPerPeriod ||
                    (this.MessagesPerPeriod != null &&
                    this.MessagesPerPeriod.Equals(input.MessagesPerPeriod))
                ) &&
                (
                    this.MinutesPerPeriod == input.MinutesPerPeriod ||
                    (this.MinutesPerPeriod != null &&
                    this.MinutesPerPeriod.Equals(input.MinutesPerPeriod))
                ) &&
                (
                    this.NumberOfPeriods == input.NumberOfPeriods ||
                    (this.NumberOfPeriods != null &&
                    this.NumberOfPeriods.Equals(input.NumberOfPeriods))
                ) &&
                (
                    this.IsRollingPeriod == input.IsRollingPeriod ||
                    (this.IsRollingPeriod != null &&
                    this.IsRollingPeriod.Equals(input.IsRollingPeriod))
                ) &&
                (
                    this.MessageLimit == input.MessageLimit ||
                    (this.MessageLimit != null &&
                    this.MessageLimit.Equals(input.MessageLimit))
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
                ) &&
                (
                    this.TzBased == input.TzBased ||
                    (this.TzBased != null &&
                    this.TzBased.Equals(input.TzBased))
                ) &&
                (
                    this.TzPastSendAction == input.TzPastSendAction ||
                    (this.TzPastSendAction != null &&
                    this.TzPastSendAction.Equals(input.TzPastSendAction))
                ) &&
                (
                    this.ScheduledTzOffset == input.ScheduledTzOffset ||
                    (this.ScheduledTzOffset != null &&
                    this.ScheduledTzOffset.Equals(input.ScheduledTzOffset))
                ) &&
                (
                    this.ScheduledTzSupportsDst == input.ScheduledTzSupportsDst ||
                    (this.ScheduledTzSupportsDst != null &&
                    this.ScheduledTzSupportsDst.Equals(input.ScheduledTzSupportsDst))
                ) &&
                (
                    this.InclusionLists == input.InclusionLists ||
                    (this.InclusionLists != null &&
                    this.InclusionLists.Equals(input.InclusionLists))
                ) &&
                (
                    this.ExclusionLists == input.ExclusionLists ||
                    (this.ExclusionLists != null &&
                    this.ExclusionLists.Equals(input.ExclusionLists))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) &&
                (
                    this.PageId == input.PageId ||
                    (this.PageId != null &&
                    this.PageId.Equals(input.PageId))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) &&
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) &&
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) &&
                (
                    this.Geofences == input.Geofences ||
                    (this.Geofences != null &&
                    this.Geofences.Equals(input.Geofences))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
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
                if (this.SendInitiator != null)
                    hashCode = hashCode * 59 + this.SendInitiator.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.MessagesPerPeriod != null)
                    hashCode = hashCode * 59 + this.MessagesPerPeriod.GetHashCode();
                if (this.MinutesPerPeriod != null)
                    hashCode = hashCode * 59 + this.MinutesPerPeriod.GetHashCode();
                if (this.NumberOfPeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfPeriods.GetHashCode();
                if (this.IsRollingPeriod != null)
                    hashCode = hashCode * 59 + this.IsRollingPeriod.GetHashCode();
                if (this.MessageLimit != null)
                    hashCode = hashCode * 59 + this.MessageLimit.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Subtitle != null)
                    hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
                if (this.MutableContent != null)
                    hashCode = hashCode * 59 + this.MutableContent.GetHashCode();
                if (this.TzBased != null)
                    hashCode = hashCode * 59 + this.TzBased.GetHashCode();
                if (this.TzPastSendAction != null)
                    hashCode = hashCode * 59 + this.TzPastSendAction.GetHashCode();
                if (this.ScheduledTzOffset != null)
                    hashCode = hashCode * 59 + this.ScheduledTzOffset.GetHashCode();
                if (this.ScheduledTzSupportsDst != null)
                    hashCode = hashCode * 59 + this.ScheduledTzSupportsDst.GetHashCode();
                if (this.InclusionLists != null)
                    hashCode = hashCode * 59 + this.InclusionLists.GetHashCode();
                if (this.ExclusionLists != null)
                    hashCode = hashCode * 59 + this.ExclusionLists.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PageId != null)
                    hashCode = hashCode * 59 + this.PageId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Geofences != null)
                    hashCode = hashCode * 59 + this.Geofences.GetHashCode();
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
