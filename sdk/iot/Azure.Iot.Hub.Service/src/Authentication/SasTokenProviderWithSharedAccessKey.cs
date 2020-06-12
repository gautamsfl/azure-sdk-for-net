// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Iot.Hub.Service.Authentication
{
    /// <summary>
    /// Implementation of a shared access signature provider with token caching and refresh.
    /// </summary>
    internal class SasTokenProviderWithSharedAccessKey : ISasTokenProvider
    {
        private static readonly TimeSpan s_defaultTimeToLive = TimeSpan.FromMinutes(30);
        private readonly object _lock = new object();

        private readonly string _hostname;
        private readonly string _sharedAccessPolicy;
        private readonly string _sharedAccessKey;
        private readonly TimeSpan _timeToLive;

        private string _cachedSasToken;
        private DateTimeOffset _tokenExpiryTime;

        // Private constructor to prevent accidental initialzation.
        private SasTokenProviderWithSharedAccessKey()
        {
        }

        public SasTokenProviderWithSharedAccessKey(string hostname, string sharedAccessPolicy, string sharedAccessKey, TimeSpan? timeToLive = null)
        {
            _hostname = hostname;
            _sharedAccessPolicy = sharedAccessPolicy;
            _sharedAccessKey = sharedAccessKey;
            _timeToLive = timeToLive ?? s_defaultTimeToLive;

            _cachedSasToken = null;
        }

        public string GetSasToken()
        {
            lock (_lock)
            {
                if (IsTokenExpired())
                {
                    var builder = new SharedAccessSignatureBuilder
                    {
                        Target = _hostname,
                        KeyName = _sharedAccessPolicy,
                        Key = _sharedAccessKey,
                        TimeToLive = _timeToLive,
                    };

                    _tokenExpiryTime = DateTimeOffset.UtcNow.Add(builder.TimeToLive);
                    _cachedSasToken = builder.ToSignature();
                }

                return _cachedSasToken;
            }
        }

        private bool IsTokenExpired()
        {
            // The token is considered expired if this is the first time it is being accessed (not cached yet)
            // or the current time is greater than or equal to the token expiry time.
            return _cachedSasToken == null || DateTimeOffset.UtcNow.CompareTo(_tokenExpiryTime) >= 0;
        }
    }
}
