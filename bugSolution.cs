public class ExampleClass{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void SetValueAndDoSomething(int newValue)
    {
        _value = newValue; 
        // Perform additional operations here
    }

    public void SomeMethod()
    {
        if (_value == 0) 
        {
            //Some code
        }
    }
}