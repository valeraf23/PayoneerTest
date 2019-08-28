using System.Linq;

namespace PayoneerTest.Helpers.Macroses
{
    public static class Macros
    {
        private static readonly IMacros[] Macroses =
        {
            new MacrosDate(),
            new MacrosString()
        };

        public static string Process(string value) =>
            Macroses.Aggregate(value, (current, macrose) => macrose.Process(current));
    }
}
