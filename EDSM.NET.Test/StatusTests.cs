using EDSM.NET;

namespace EDSM.NET.Test;

public class UnitTest1
{
    [Fact]
    public async Task GetServerStatusAsync_ReturnsStatusModel()
    {
        // Act
        var result = await EdsmClient.GetServerStatusAsync();

        // Assert
        Assert.NotNull(result);
        Assert.NotNull(result.LastUpdate);
        Assert.NotNull(result.Type);
        Assert.NotNull(result.Message);
    }

    [Fact]
    public async Task GetServerStatusAsync_WithCancellationToken_CanBeCancelled()
    {
        // Arrange
        using var cts = new CancellationTokenSource();
        cts.Cancel();

        // Act & Assert
        await Assert.ThrowsAsync<OperationCanceledException>(
            async () => await EdsmClient.GetServerStatusAsync(cts.Token));
    }

    [Fact]
    public async Task GetServerStatusAsync_ReturnsValidStatusCode()
    {
        // Act
        var result = await EdsmClient.GetServerStatusAsync();

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Status >= 0, "Status code should be non-negative");
    }

    [Fact]
    public async Task GetServerStatusAsync_MultipleCallsSucceed()
    {
        // Act
        var result1 = await EdsmClient.GetServerStatusAsync();
        var result2 = await EdsmClient.GetServerStatusAsync();

        // Assert
        Assert.NotNull(result1);
        Assert.NotNull(result2);
    }
}
