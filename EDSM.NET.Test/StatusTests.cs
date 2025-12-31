using EDSM.NET;

namespace EDSM.NET.Test;

public class UnitTest1
{
    [Fact]
    public async Task GetServerStatusAsync_ReturnsStatusModel()
    {
        // Act
        var result = await EDSMClient.GetServerStatusAsync();

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
        await Assert.ThrowsAsync<TaskCanceledException>(
            async () => await EDSMClient.GetServerStatusAsync(cts.Token));
    }
}
