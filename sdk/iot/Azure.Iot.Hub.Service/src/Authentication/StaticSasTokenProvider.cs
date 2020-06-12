// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Iot.Hub.Service.Authentication
{
    public class StaticSasTokenProvider : ISasTokenProvider
    {
        private readonly string _sharedAccessSignature;

        // Private constructor to prevent accidental initialzation.
        private StaticSasTokenProvider()
        {
        }

        public StaticSasTokenProvider(string sharedAccessSignature)
        {
            _sharedAccessSignature = sharedAccessSignature;
        }

        public string GetSasToken()
        {
            return _sharedAccessSignature;
        }
    }
}
