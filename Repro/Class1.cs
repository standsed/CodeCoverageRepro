namespace Repro;

public static class Class1
{
    public static async Task<string> Method1() { return "asdf"; }

    public static async Task<string> Method2<T>(T val) { if (val is string x) { return x; } throw new NotSupportedException(); }

    public static async Task<string> Method3<T, TU>(T val) { return "asdf"; }
}
