using AtataTest1.Components;

namespace AtataTest1
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void SampleTest()
        {
            Go.To<ChildHomePage>()
                .E1.Set("1")
                .E3.Set("35")
                .E2.Click()
                .E1.WaitTo.BeHidden()
                .E2.Should.Contain()
                .WaitForSmt();

        }
    }
}
