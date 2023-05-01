namespace CerbiSharp.Infrastructure.BaseInfrastructure.Logger
{
    public interface IGeneralLogable
    {
        public bool CanMakeLog { get; }

        public IGeneralLogger Logger { get; }

        public bool TryWriteLine(string input);
    }
}
