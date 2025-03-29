using MMOFromScratch;
using Silk.NET.Windowing;

class Program()
{
    private static readonly WindowManager  _WindowManager = new();
    static void Main(string[] args)
    {
        _WindowManager.CreateGameWindow();
    }
}