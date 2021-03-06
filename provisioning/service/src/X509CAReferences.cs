﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    public class X509CAReferences
    {
        /// <summary>
        /// Primary reference.
        /// </summary>
        [JsonProperty(PropertyName = "primary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Primary { get; set; }

        /// <summary>
        /// Secondary reference.
        /// </summary>
        [JsonProperty(PropertyName = "secondary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secondary { get; set; }
    }
}
