namespace AtataTest1.Components;

using _ = ChildHomePage;

[Url("https://google.com")]
public class ChildHomePage : BasePage<_>
{
    [FindByXPath("//h2[contains(.,'Static caravan')]/following-sibling::button"), ClicksUsingScript]
    public Input<string, _> E1 { get; private set; }
    [FindByXPath("//h2[contains(.,'Touring caravan')]/following-sibling::button"), ClicksUsingScript]
    public Text<_> E2 { get; private set; }
    [FindByXPath("//h2[contains(.,'Static caravan')]/following-sibling::button"), ClicksUsingScript]
    public Select<string, _> E3 { get; private set; }
}