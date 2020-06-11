// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.ResourceManager.DigitalTwins.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Azure.ResourceManager.DigitalTwins.Tests
{
    public class DigitalTwinInstanceLifecycleTests : E2eTestBase
    {
        public DigitalTwinInstanceLifecycleTests(bool isAsync)
            : base(isAsync)
        {
        }

        [Test]
        public async Task DigitalTwinInstance_Lifecycle()
        {
            string dtInstanceName = $"DtInstanceLifecycle_{Rand.Next(1000)}";

            try
            {
                DigitalTwinsCreateOrUpdateOperation createResponse = await Client
                    .StartCreateOrUpdateAsync(
                        TestEnvironment.ResourceGroup,
                        dtInstanceName,
                        new DigitalTwinsDescription(TestEnvironment.Location))
                    .ConfigureAwait(false);

                createResponse.GetRawResponse().Status.Should().Be(201);

                Response<DigitalTwinsDescription> createdResponse = await WaitForCompletionAsync(createResponse).ConfigureAwait(false);
                createdResponse.GetRawResponse().Status.Should().Be(200);

                DigitalTwinsDescription createdDtInstance = createdResponse.Value;
                createdDtInstance.Name.Should().Be(dtInstanceName);
                createdDtInstance.Location.Should().Be(TestEnvironment.Location);

            }
            finally
            {
                DigitalTwinsDeleteOperation deleteResponse = await Client
                    .StartDeleteAsync(
                        TestEnvironment.ResourceGroup,
                        dtInstanceName)
                    .ConfigureAwait(false);

                deleteResponse.GetRawResponse().Status.Should().Be(202);

                Response<Response> deletedResponse = await WaitForCompletionAsync(deleteResponse).ConfigureAwait(false);
                deletedResponse.GetRawResponse().Status.Should().Be(204);
            }
        }
    }
}
