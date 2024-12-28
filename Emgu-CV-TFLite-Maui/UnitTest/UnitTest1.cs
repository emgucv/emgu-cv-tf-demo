namespace EmguMauiUnitTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        String buildInfo = EmguMauiApp.MainPage.GetBuildInfo();
    }
}
