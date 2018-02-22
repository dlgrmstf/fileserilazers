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
    public class ReadWriteCsvFile : IReadWriteFile
    {

        public string FormatName => "Csv File";
        public string DefaultExtension => ".csv";

        public BindingList<person> ReadFile(string path)
        {
            StreamReader csvstreamreader = null;
            BindingList<person> csvreadpersons = new BindingList<person>();
            try
            {
                csvstreamreader = new StreamReader(path);
                person csvreadperson;
                string line = null;
                while ((line = csvstreamreader.ReadLine()) != null)
                {
                    string[] dizi = line.Split(';');
                    csvreadperson = new person { id = int.Parse(dizi[0]), name = dizi[1], surname = dizi[2], dateofBirth = DateTime.Parse(dizi[3]), gender = dizi[4], married = dizi[5] };
                    csvreadpersons.Add(csvreadperson);
                    //MessageBox.Show(line[0] + line.Split(';')[1] + line.Split(';')[2] + DateTime.Parse(line.Split(';')[3]));
                }
                csvstreamreader.Close();
                csvstreamreader = null;
                return csvreadpersons;
                /**foreach (person item in csvreadpersons)
                {
                    persons.Add(item);
                }**/
            }
            catch (Exception exe)
            {
               
                return null;
            }
            finally
            {
                if (csvstreamreader != null)
                    csvstreamreader.Dispose();
            }

        }

    public bool WriteFile(BindingList<person> persons, string path)
    {
            StreamWriter theWriter = null;
            StringBuilder theBuilder = new StringBuilder();
            try
            {

                foreach (person csvwriteperson in persons)
                {
                    theBuilder.Append(csvwriteperson.id);
                    theBuilder.Append(";");
                    theBuilder.Append(csvwriteperson.name);
                    theBuilder.Append(";");
                    theBuilder.Append(csvwriteperson.surname);
                    theBuilder.Append(";");
                    theBuilder.Append(csvwriteperson.dateofBirth);
                    theBuilder.Append(";");
                    theBuilder.Append(csvwriteperson.gender);
                    theBuilder.Append(";");
                    theBuilder.Append(csvwriteperson.married);
                    theBuilder.Append("\n");
                }
                theWriter = new StreamWriter(path);
                theWriter.Write(theBuilder.ToString());
                theWriter.Close();
                return true;

            }
            catch 
            {
                return false ;
            }
            finally
            {
                if (theWriter != null)
                    theWriter.Dispose();
            }
        }
}

        

    
}


       

