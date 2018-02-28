using _deneme1;
using log4net;
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
using System.Windows.Forms;
using System.Xml.Serialization;



namespace _deneme1
{
    public partial class Frmbase : Form

    {
        BindingList<person> persons = new BindingList<person>();
        SaveFileDialog saveFileDialog=new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        ReadWriteCsvFile readWriteCsvFile = new ReadWriteCsvFile();
        ReadWriteJsonFile readWriteJsonFile = new ReadWriteJsonFile();
        ReadWriteXmlFile readWriteXmlFile = new ReadWriteXmlFile();
        List<IReadWriteFile> m_Formats = new List<IReadWriteFile>();
        private static readonly ILog logger = LogManager.GetLogger(typeof(BindingList<person>));
        int lastID = 0;


        public Frmbase()
        {
            InitializeComponent();
            dataGridViewBindingList.AutoGenerateColumns = false;
            if (File.Exists(@"c:\Users\Dulger\Documents\SerializationOverview.xml"))
            {
                FileInfo filesize = new FileInfo(@"c:\Users\Dulger\Documents\SerializationOverview.xml");
                if (filesize.Length > 10)
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(@"c:\Users\Dulger\Documents\SerializationOverview.xml");
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(BindingList<person>));
                    BindingList<person> readpersons = (BindingList<person>)reader.Deserialize(file);
                    file.Close();
                    persons = readpersons;
                    logger.Debug("Xml dosyasindan okuma yapildi");
                }
            }
            dataGridViewBindingList.DataSource = persons;

            m_Formats.Add(new ReadWriteXmlFile());
            m_Formats.Add(new ReadWriteJsonFile());
            m_Formats.Add(new ReadWriteCsvFile());
            comboBoxFileFormat.DisplayMember = "FormatName";
            comboBoxFileFormat.ValueMember = "FormatName";
            comboBoxFileFormat.DataSource = m_Formats;
        }

        private void Add()
        {
            person _newPerson = new person();
            _newPerson.name = "Ad giriniz";
            _newPerson.surname = "Soyad giriniz";
            _newPerson.dateofBirth = DateTime.Now;
            Frmadd FormAdd = new Frmadd(_newPerson);
            if (FormAdd.ShowDialog() == DialogResult.OK)
            {
                foreach (person lastperson in persons)
                {
                    lastID = lastperson.id + 1;
                }
                _newPerson.id = lastID;
                persons.Add(_newPerson);
                logger.Debug("Person eklendi");
            }
        }

        private void Remove()
        {
            //persons.RemoveAt(dataGridViewBindingList.SelectedRows[0].Index);
            foreach (DataGridViewRow row in this.dataGridViewBindingList.SelectedRows)
            {
                person _selectedPerson = row.DataBoundItem as person;
                persons.Remove(_selectedPerson);
                logger.Debug("Person silindi");
            }

        }

        private void Edit()
        {
            if (this.dataGridViewBindingList.SelectedRows.Count > 0)
            {
                person _selectedPerson = (person)this.dataGridViewBindingList.SelectedRows[0].DataBoundItem;
                Frmadd FormAdd = new Frmadd(_selectedPerson);
                FormAdd.ShowDialog();
            }
        }

        private  string  getNewFilePath(string filter)
        {
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                return saveFileDialog.FileName;
            return null;  
        }

        private string selectFile(string filter)
        {
            openFileDialog.Filter = filter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            return  null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void _newPerson_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show("property degisti");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxFileFormat.SelectedItem == null)
                MessageBox.Show("Bos");
           
            else
            {
                 IReadWriteFile write = (IReadWriteFile)comboBoxFileFormat.SelectedItem;
                string myFilter = write.FormatName + "|*" + write.DefaultExtension;
                string mypath = getNewFilePath(myFilter);
                if (mypath != null)
                    write.WriteFile(persons, mypath);}
             }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxFileFormat.SelectedItem == null)
                MessageBox.Show("Bos");

            else
            {
                IReadWriteFile read = (IReadWriteFile)comboBoxFileFormat.SelectedItem;
                string myFilter = read.FormatName + "|*" + read.DefaultExtension;
                string mypath = selectFile(myFilter);
                if (mypath != null)
                {
                    persons = read.ReadFile(mypath);
                    if (persons != null)
                    {
                        dataGridViewBindingList.DataSource = persons;
                    }
                }
                   

                        
            }
        }

        
    }
}






