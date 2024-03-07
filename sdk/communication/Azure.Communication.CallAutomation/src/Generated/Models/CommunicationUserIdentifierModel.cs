// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.CallAutomation;

namespace Azure.Communication
{
    /// <summary> A user that got created with an Azure Communication Services resource. </summary>
    internal partial class CommunicationUserIdentifierModel
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationUserIdentifierModel"/>. </summary>
        /// <param name="id"> The Id of the communication user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CommunicationUserIdentifierModel(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> The Id of the communication user. </summary>
        public string Id { get; set; }
    }
}
