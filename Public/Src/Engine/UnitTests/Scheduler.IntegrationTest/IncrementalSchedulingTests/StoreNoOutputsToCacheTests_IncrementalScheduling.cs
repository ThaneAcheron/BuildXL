// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Test.BuildXL.TestUtilities;
using Test.BuildXL.TestUtilities.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace IntegrationTest.BuildXL.Scheduler.IncrementalSchedulingTests
{
    [Trait("Category", "StoreNoOutputsToCacheTests")]
    [Feature(Features.IncrementalScheduling)]
    [TestClassIfSupported(requiresJournalScan: true)]
    public class StoreNoOutputsToCacheTests_IncrementalScheduling : StoreNoOutputsToCacheTests
    {
        public StoreNoOutputsToCacheTests_IncrementalScheduling(ITestOutputHelper output) : base(output)
        {
            Configuration.Schedule.IncrementalScheduling = true;
            Configuration.Schedule.SkipHashSourceFile = false;
        }
    }
}
