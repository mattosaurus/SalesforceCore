using RestSharp;
using SalesforceCore.Client;
using SalesforceCore.Model.Push;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesforceCore.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPushApi
    {
        #region Synchronous Operations
        /// <summary>
        /// createPushMessage
        /// </summary>
        /// <remarks>
        /// Creates a push message template for sending to a list of subscribers or an audience inclusion list or data extension. You can personalize each message for each subscriber using personalization strings or AMPscript lookups from a data extension within a single push message definition. You can also pass the text of the message to override the message contents specified in the definition for API-driven personalization.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        Message CreateMessage(Message body);

        /// <summary>
        /// createPushMessage
        /// </summary>
        /// <remarks>
        /// Creates a push message template for sending to a list of subscribers or an audience inclusion list or data extension. You can personalize each message for each subscriber using personalization strings or AMPscript lookups from a data extension within a single push message definition. You can also pass the text of the message to override the message contents specified in the definition for API-driven personalization.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Message</returns>
        ApiResponse<Message> CreateMessageWithHttpInfo(Message body);

        /// <summary>
        /// sendMessageBatch
        /// </summary>
        /// <remarks>
        /// Sends unique messages to devices within the same API call. Each batch can include a maximum of 5000 subscriber key or device token values, depending on which value the call uses.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The ID of the message to send</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        MessageBatch SendMessageBatch(string messageId, MessageBatch body);

        /// <summary>
        /// sendMessageBatch
        /// </summary>
        /// <remarks>
        /// Sends unique messages to devices within the same API call. Each batch can include a maximum of 5000 subscriber key or device token values, depending on which value the call uses.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The ID of the message to send</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Message</returns>
        ApiResponse<MessageBatch> SendMessageBatchWithHttpInfo(string messageId, MessageBatch body);
        #endregion Synchronous Operations

        #region Asynchronous Operations
        /// <summary>
        /// createPushMessage
        /// </summary>
        /// <remarks>
        /// Creates a push message template for sending to a list of subscribers or an audience inclusion list or data extension. You can personalize each message for each subscriber using personalization strings or AMPscript lookups from a data extension within a single push message definition. You can also pass the text of the message to override the message contents specified in the definition for API-driven personalization.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<Message> CreateMessageAsync(Message body);

        /// <summary>
        /// createPushMessage
        /// </summary>
        /// <remarks>
        /// Creates a push message template for sending to a list of subscribers or an audience inclusion list or data extension. You can personalize each message for each subscriber using personalization strings or AMPscript lookups from a data extension within a single push message definition. You can also pass the text of the message to override the message contents specified in the definition for API-driven personalization.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<ApiResponse<Message>> CreateMessageAsyncWithHttpInfo(Message body);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PushApi : BaseApi, IPushApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignApi"/> class.
        /// </summary>
        /// <returns></returns>
        internal PushApi(string authBaseUrl, string clientId, string clientSecret, string accountId, string scope)
            : base(authBaseUrl, clientId, clientSecret, accountId, scope)
        {
        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        public Message CreateMessage(Message body)
        {
            ApiResponse<Message> localVarResponse = CreateMessageWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// createCampaign Creates a campaign.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse<Message> CreateMessageWithHttpInfo(Message body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PushApi->CreateMessage");

            var localVarPath = "/push/v1/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
        }

        /// <summary>
        /// createMessage Creates a Message.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Message</returns>
        public async System.Threading.Tasks.Task<Message> CreateMessageAsync(Message body)
        {
            ApiResponse<Message> localVarResponse = await CreateMessageAsyncWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// createMessage Creates a Message.
        /// </summary>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Message>> CreateMessageAsyncWithHttpInfo(Message body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PushApi->CreateMessage");

            var localVarPath = "/push/v1/message";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
        }

        /// <summary>
        /// sendMessageBatch
        /// </summary>
        /// <remarks>
        /// Sends unique messages to devices within the same API call. Each batch can include a maximum of 5000 subscriber key or device token values, depending on which value the call uses.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The ID of the message to send</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Campaign</returns>
        public MessageBatch SendMessageBatch(string messageId, MessageBatch body)
        {
            ApiResponse<MessageBatch> localVarResponse = SendMessageBatchWithHttpInfo(messageId, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// sendMessageBatch
        /// </summary>
        /// <remarks>
        /// Sends unique messages to devices within the same API call. Each batch can include a maximum of 5000 subscriber key or device token values, depending on which value the call uses.
        /// </remarks>
        /// <exception cref="SalesforceCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The ID of the message to send</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Message</returns>
        public ApiResponse<MessageBatch> SendMessageBatchWithHttpInfo(string messageId, MessageBatch body)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling PushApi->SendMessageBatch");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PushApi->SendMessageBatch");

            var localVarPath = "/push/v1/messageBatch/{messageId}/send";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId)); // path parameter

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendMessageBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    }
}
