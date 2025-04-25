namespace EDSM.NET.Tests;

public class StatusTests
{
    [Fact]
    public async Task Status_should_be_returned()
    {
        await Status.GetStatus().ContinueWith(task =>
        {
            if (task.IsCompletedSuccessfully)
            {
                Assert.NotNull(task.Result);
            }
            else
            {
                Assert.True(false, "Failed to get status from EDSM API");
            }
        });
    }
}
