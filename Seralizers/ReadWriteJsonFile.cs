using _deneme1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace _deneme1
{
    public class ReadWriteJsonFile : IReadWriteFile
    {
       
        public string FormatName => "Json File";

        public string DefaultExtension => ".json";

        public BindingList<person> ReadFile(string path)
        {
            JsonSerializer serializer = null;
            StreamReader file = null;
            try
            {
                BindingList<person> readjsonpersons = JsonConvert.DeserializeObject<BindingList<person>>(File.ReadAllText(path));
                file = File.OpenText(path);
                serializer = new JsonSerializer();
                BindingList<person> jsonreadpersons = (BindingList<person>)serializer.Deserialize(file, typeof(BindingList<person>));
                file.Close();
                //MessageBox.Show(jsonreadpersons[0].name);
                return jsonreadpersons;
            }
            catch (Exception exe)
            {
               
                return null;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
        public bool WriteFile(BindingList<person> persons, string path)
        {
            StreamWriter _writer = null;
            string json = JsonConvert.SerializeObject(persons);
            try
            {
                //writer varsa siler yoksa oluşturur.
                _writer = new StreamWriter(path);
                _writer.Write(json);
                _writer.Close();
                //new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Arrays };
                return true;
            }
            catch
            {
                return false ;
            }
            finally
            {
                if (_writer != null)
                    _writer.Dispose();
            }

        }
    }   
}


       

