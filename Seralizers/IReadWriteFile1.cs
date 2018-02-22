using System.ComponentModel;

namespace _deneme1
{
    public interface IReadWriteFile
    {
        BindingList<person> ReadFile(string path);
        bool WriteFile(BindingList<person> persons, string path);
        string FormatName { get;  }
        string DefaultExtension {  get; }
    }
}