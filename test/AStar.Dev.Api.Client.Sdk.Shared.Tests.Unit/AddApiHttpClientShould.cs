using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CA1716
namespace AStar.Dev.Api.Client.Sdk.Shared.Tests.Unit;
#pragma warning restore CA1716

[TestSubject(typeof(AddApiHttpClient))]
public class AddApiHttpClientShould
{
    [Fact]
    public void IncludeTheAddApiHttpClientMethod()
    {
        var sut                 = new ServiceCollection();
        var initialServiceCount = sut.Count;

        sut.AddApiClient<MockApiClient, MockApiConfiguration>(["Scope Does Not Matter Here"]);

        sut.Count.ShouldBe(initialServiceCount + 44);
    }
}