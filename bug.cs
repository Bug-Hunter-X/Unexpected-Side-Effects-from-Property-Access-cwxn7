public class ExampleClass{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void SomeMethod()
    {
        if (Value == 0)
        {
            // Some code
        }
    }
}