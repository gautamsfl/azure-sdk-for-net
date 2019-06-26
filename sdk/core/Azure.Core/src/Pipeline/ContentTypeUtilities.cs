﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text;

namespace Azure.Core.Pipeline
{
    public class ContentTypeUtilities
    {
        public static bool TryGetTextEncoding(string contentType, out Encoding encoding)
        {
            const string charsetMarker = "; charset=";
            const string utf8Charset = "utf-8";
            const string textContentTypePrefix = "text/";
            const string jsonSuffix = "json";
            const string xmlSuffix = "xml";
            const string urlEncodedSuffix = "-urlencoded";

            if (contentType == null)
            {
                encoding = null;
                return false;
            }

            var charsetIndex = contentType.IndexOf(charsetMarker, StringComparison.InvariantCultureIgnoreCase);
            if (charsetIndex != -1)
            {
                ReadOnlySpan<char> charset = contentType.AsSpan().Slice(charsetIndex + charsetMarker.Length);
                if (charset.StartsWith(utf8Charset.AsSpan(), StringComparison.OrdinalIgnoreCase))
                {
                    encoding = Encoding.UTF8;
                    return true;
                }
            }

            if (contentType.StartsWith(textContentTypePrefix) ||
                contentType.EndsWith(jsonSuffix) ||
                contentType.EndsWith(xmlSuffix) ||
                contentType.EndsWith(urlEncodedSuffix))
            {
                encoding = Encoding.UTF8;
                return true;
            }

            encoding = null;
            return false;
        }
    }
}
