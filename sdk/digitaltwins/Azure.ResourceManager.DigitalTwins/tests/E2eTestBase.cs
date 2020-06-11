// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;

namespace Azure.ResourceManager.DigitalTwins.Tests
{
    [ClientTestFixture]
    public abstract class E2eTestBase : RecordedTestBase<DigitalTwinsManagementTestEnvironment>
    {
        private static readonly TimeSpan ZeroPollingInterval = TimeSpan.FromSeconds(0);

        protected DigitalTwinsManagementClient MainClient { get; private set; }
        protected DigitalTwinsClient Client { get; private set; }
        protected Random Rand { get; private set; }

        protected E2eTestBase(bool isAsync)
            : base(isAsync)
        {
            MainClient = GetClient();
            Client = MainClient.GetDigitalTwinsClient();
        }

        protected E2eTestBase(bool isAsync, RecordedTestMode mode)
            : base(isAsync, mode)
        {
            MainClient = GetClient();
            Client = MainClient.GetDigitalTwinsClient();
        }

        protected DigitalTwinsManagementClient GetClient()
        {
            return CreateClient<DigitalTwinsManagementClient>(
                TestEnvironment.SubscriptionId,
                TestEnvironment.Credential);
        }

        protected ValueTask<Response<T>> WaitForCompletionAsync<T>(Operation<T> operation)
        {
            if (Mode == RecordedTestMode.Playback)
            {
                return operation.WaitForCompletionAsync(ZeroPollingInterval, default);
            }

            return operation.WaitForCompletionAsync();
        }
    }
}
