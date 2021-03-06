// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PredictionOperations.
    /// </summary>
    public static partial class PredictionOperationsExtensions
    {
            /// <summary>
            /// Gets the predictions for an application version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The application version ID.
            /// </param>
            /// <param name='predictionRequest'>
            /// The prediction request parameters.
            /// </param>
            /// <param name='verbose'>
            /// Indicates whether to get extra metadata for the entities predictions or
            /// not.
            /// </param>
            /// <param name='showAllIntents'>
            /// Indicates whether to return all the intents in the response or just the top
            /// intent.
            /// </param>
            /// <param name='log'>
            /// Indicates whether to log the endpoint query or not.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PredictionResponse> GetVersionPredictionAsync(this IPredictionOperations operations, System.Guid appId, string versionId, PredictionRequest predictionRequest, bool? verbose = default(bool?), bool? showAllIntents = default(bool?), bool? log = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVersionPredictionWithHttpMessagesAsync(appId, versionId, predictionRequest, verbose, showAllIntents, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the predictions for an application slot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='slotName'>
            /// The application slot name.
            /// </param>
            /// <param name='predictionRequest'>
            /// The prediction request parameters.
            /// </param>
            /// <param name='verbose'>
            /// Indicates whether to get extra metadata for the entities predictions or
            /// not.
            /// </param>
            /// <param name='showAllIntents'>
            /// Indicates whether to return all the intents in the response or just the top
            /// intent.
            /// </param>
            /// <param name='log'>
            /// Indicates whether to log the endpoint query or not.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PredictionResponse> GetSlotPredictionAsync(this IPredictionOperations operations, System.Guid appId, string slotName, PredictionRequest predictionRequest, bool? verbose = default(bool?), bool? showAllIntents = default(bool?), bool? log = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSlotPredictionWithHttpMessagesAsync(appId, slotName, predictionRequest, verbose, showAllIntents, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
