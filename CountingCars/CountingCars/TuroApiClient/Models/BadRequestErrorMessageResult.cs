﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TuroApi.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class BadRequestErrorMessageResult
    {
        /// <summary>
        /// Initializes a new instance of the BadRequestErrorMessageResult
        /// class.
        /// </summary>
        public BadRequestErrorMessageResult() { }

        /// <summary>
        /// Initializes a new instance of the BadRequestErrorMessageResult
        /// class.
        /// </summary>
        public BadRequestErrorMessageResult(string message = default(string), object contentNegotiator = default(object), object request = default(object), IList<MediaTypeFormatter> formatters = default(IList<MediaTypeFormatter>))
        {
            Message = message;
            ContentNegotiator = contentNegotiator;
            Request = request;
            Formatters = formatters;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContentNegotiator")]
        public object ContentNegotiator { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Request")]
        public object Request { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Formatters")]
        public IList<MediaTypeFormatter> Formatters { get; private set; }

    }
}
