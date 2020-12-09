using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoApp1.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoApp1.App(), args);
            host.Run();
        }
    }
}
