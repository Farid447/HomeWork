using Newtonsoft.Json;
using System.Xml.Linq;

namespace FileStream;
internal class FileHelper
{
    List<string> list  = [];
    string str;

    public string path { get; set; }
    public FileHelper(string path)
    {
        this.path = path;
    }
    public void Add(string name)
    {
        using StreamReader sr = new StreamReader(path);

        list = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());
        
        list.Add(name);
        
        sr.Close();
        
        using StreamWriter sw = new StreamWriter(path, false);
        sw.Write(JsonConvert.SerializeObject(list));
    }
    public bool Exist(string name)
    {
        using StreamReader sr = new StreamReader(path);

        list = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());

        return list.Contains(name);
    }
    public void Update(int index, string name)
    {
        if (index >= 0 && index < list.Count)
        {
            using StreamReader sr = new StreamReader(path);

            list = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());

            list[index] = name;

            sr.Close();

            using StreamWriter sw = new StreamWriter(path, false);
            sw.Write(JsonConvert.SerializeObject(list));
        }
        else
        {
            Console.WriteLine("indexi duzgun daxil edin");
        }
    }
    public void Delete(int index)
    {
        if (index >= 0 && index < list.Count)
        {
            using StreamReader sr = new StreamReader(path);

            list = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());

            list.RemoveAt(index);

            sr.Close();

            using StreamWriter sw = new StreamWriter(path, false);
            sw.Write(JsonConvert.SerializeObject(list));
        }
        else
        {
            Console.WriteLine("indexi duzgun daxil edin");
        }
    }
}