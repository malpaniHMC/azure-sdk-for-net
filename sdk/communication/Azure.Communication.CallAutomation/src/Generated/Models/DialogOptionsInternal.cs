// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogOptions. </summary>
    internal partial class DialogOptionsInternal
    {
        /// <summary> Initializes a new instance of DialogOptionsInternal. </summary>
        /// <param name="dialogContext"> Dialog context. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dialogContext"/> is null. </exception>
        public DialogOptionsInternal(IDictionary<string, object> dialogContext)
        {
            Argument.AssertNotNull(dialogContext, nameof(dialogContext));

            DialogContext = dialogContext;
        }

        /// <summary> Initializes a new instance of DialogOptionsInternal. </summary>
        /// <param name="botAppId"> Bot identifier. </param>
        /// <param name="dialogContext"> Dialog context. </param>
        internal DialogOptionsInternal(string botAppId, IDictionary<string, object> dialogContext)
        {
            BotAppId = botAppId;
            DialogContext = dialogContext;
        }

        /// <summary> Bot identifier. </summary>
        public string BotAppId { get; set; }
        /// <summary> Dialog context. </summary>
        public IDictionary<string, object> DialogContext { get; }
    }
}
