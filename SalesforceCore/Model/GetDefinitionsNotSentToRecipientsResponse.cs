/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SalesforceCore.Client.SwaggerDateConverter;

namespace SalesforceCore.Model
{
    /// <summary>
    /// GetDefinitionsNotSentToRecipientsResponse
    /// </summary>
    [DataContract]
    public partial class GetDefinitionsNotSentToRecipientsResponse :  IEquatable<GetDefinitionsNotSentToRecipientsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDefinitionsNotSentToRecipientsResponse" /> class.
        /// </summary>
        /// <param name="lastEventID">Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest.</param>
        /// <param name="messages">messages.</param>
        /// <param name="count">Number of pages.</param>
        /// <param name="pageSize">Number of definitions, which are array elements, to return per paged response..</param>
        public GetDefinitionsNotSentToRecipientsResponse(int? lastEventID = default(int?), List<GetDefinitionsNotSentToRecipientsMessage> messages = default(List<GetDefinitionsNotSentToRecipientsMessage>), int? count = default(int?), int? pageSize = default(int?))
        {
            this.LastEventID = lastEventID;
            this.Messages = messages;
            this.Count = count;
            this.PageSize = pageSize;
        }
        
        /// <summary>
        /// Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest
        /// </summary>
        /// <value>Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest</value>
        [DataMember(Name="lastEventID", EmitDefaultValue=false)]
        public int? LastEventID { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<GetDefinitionsNotSentToRecipientsMessage> Messages { get; set; }

        /// <summary>
        /// Number of pages
        /// </summary>
        /// <value>Number of pages</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; private set; }

        /// <summary>
        /// Number of definitions, which are array elements, to return per paged response.
        /// </summary>
        /// <value>Number of definitions, which are array elements, to return per paged response.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDefinitionsNotSentToRecipientsResponse {\n");
            sb.Append("  LastEventID: ").Append(LastEventID).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as GetDefinitionsNotSentToRecipientsResponse);
        }

        /// <summary>
        /// Returns true if GetDefinitionsNotSentToRecipientsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDefinitionsNotSentToRecipientsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDefinitionsNotSentToRecipientsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastEventID == input.LastEventID ||
                    (this.LastEventID != null &&
                    this.LastEventID.Equals(input.LastEventID))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
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
                if (this.LastEventID != null)
                    hashCode = hashCode * 59 + this.LastEventID.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
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
