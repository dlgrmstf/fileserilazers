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
    public class ReadWriteXmlFile : IReadWriteFile
    {
        public string FormatName => "Xml File";

        public string DefaultExtension => ".xml";

        public BindingList<person> ReadFile(string path)
        {

           StreamReader file = null;
           XmlSerializer reader = null;
           BindingList<person> readpersons = null;
           try
           {
               file = new StreamReader(path);
               reader = new XmlSerializer(typeof(BindingList<person>));
               readpersons = (BindingList<person>)reader.Deserialize(file);
               file.Close();
               return readpersons;

           }
           
           catch (Exception exe)
           {
               return null;
           
               
           }
           finally
           {
               if (file != null)
                   file.Dispose();
           }
        
        }

        public bool WriteFile(BindingList<person> persons, string path)
        {
            FileStream file = null;
            try
            {
                /**var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
                saveFileDialog.ShowDialog();
                var path = saveFileDialog.FileName;**/
                file = File.Create(path);
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<person>));
                serializer.Serialize(file, persons);
                file.Close();
                return true;
                /**StreamWriter _writer = new StreamWriter(@"c:\Users\Dulger\Documents\SerializationOverview.xml");
                _writer.Write(persons);
                _writer.Close(); **/
            }
            catch
            {
                return false;
            }
            finally
            {
                if (file != null)
                    file.Dispose();
            }

        }
    }
}
   



       

