using System;
using System.Configuration;

namespace HelloWorldLib
{
    public interface IOutput
    {
        void WriteData(string data);
    }

    public abstract class Output : IOutput
    {
        private const string SELECTED_TYPE = "SelectedType";
        private static Type _selectedType;

        static Output()
        {
            var selected = ConfigurationManager.AppSettings[SELECTED_TYPE];

            if(selected == null)
            {
                selected = "HelloWorldLib.ConsoleOutput";
            }

            _selectedType = Type.GetType(selected, true, true);
        }

        public static IOutput OutputFactory()
        {
            var obj = Activator.CreateInstance(_selectedType);
            return obj as IOutput;
        }

        public abstract void WriteData(string data);
    }

    public class ConsoleOutput : Output
    {
        public ConsoleOutput() : base()
        { }

        public override void WriteData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
