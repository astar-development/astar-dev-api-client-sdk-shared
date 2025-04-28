namespace AStar.Dev.Api.Client.Sdk.Shared.Tests;

internal sealed class MockApiConfiguration :  IApiConfiguration
{
    /// <inheritdoc />
    public Uri      BaseUrl { get; set; } = new ("https://not.set.com");

    /// <inheritdoc />
    public string[] Scopes  { get; set; } = [];
}