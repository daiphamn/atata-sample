namespace AtataTest1.Components;

public class BasePage<TOwner> : Page<TOwner> where TOwner : BasePage<TOwner>
{
    public TOwner WaitForSmt()
    {
        return (TOwner) this;
    }
}