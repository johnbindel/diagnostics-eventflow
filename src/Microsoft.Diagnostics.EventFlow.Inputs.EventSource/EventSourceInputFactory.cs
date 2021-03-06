﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Diagnostics.EventFlow.Configuration;
using Validation;

namespace Microsoft.Diagnostics.EventFlow.Inputs
{
    public class EventSourceInputFactory: IPipelineItemFactory<EventSourceInput>
    {
        public EventSourceInput CreateItem(IConfiguration configuration, IHealthReporter healthReporter)
        {
            Requires.NotNull(configuration, nameof(configuration));
            Requires.NotNull(healthReporter, nameof(healthReporter));

            return new EventSourceInput(configuration, healthReporter);
        }
    }
}
