﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TuroApi
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Search operations.
    /// </summary>
    public partial interface ISearch
    {
        /// <summary>
        /// Get all cars in a given location
        /// </summary>
        /// <param name='qlocation'>
        /// SoFL= 26.16,-80.20
        /// </param>
        /// <param name='qmake'>
        /// Car make
        /// </param>
        /// <param name='qmodel'>
        /// Car model
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Car>>> GetByLocationWithHttpMessagesAsync(string qlocation, string qmake = default(string), string qmodel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
