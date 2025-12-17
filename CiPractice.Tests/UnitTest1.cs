
using Xunit;

namespace CiPractice.Tests;

public class UnitTest1
{
    [Fact]
    public void ThisTestWillFail_OnPurpose()
    {
        // This is intentionally wrong to simulate a CI failure
        Assert.Equal(3, 1 + 1 + 1);

    }
}
