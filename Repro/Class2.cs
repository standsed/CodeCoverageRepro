public class Class2
{
    public string Method4(object val)
    {
        if (val is string x) { return new Class3().Method5(val); }
        throw new NotSupportedException();
    }

    public string Method6(object val)
    {
        if (val is string x) { return new Class3().Method5(val); }
        throw new NotSupportedException();
    }
    private class Class3
    {
        public string Method5(object val)
        {
            if (val is string x) { return x; }
            throw new NotSupportedException();
        }
    }
}