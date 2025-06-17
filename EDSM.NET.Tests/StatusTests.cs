namespace EDSM.NET.Tests;

public class StatusTests
{
    [Fact]
    public async Task Status_should_be_returned()
    {
        await Status.Status.GetStatus().ContinueWith(task =>
        {
            if (task.IsCompletedSuccessfully)
            {
                Assert.NotNull(task.Result);
            }
            else
            {
                Assert.Fail("Failed to get status from EDSM API");
            }
        });
    }
}
