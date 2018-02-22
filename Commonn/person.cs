using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _deneme1
{
    public partial class person:INotifyPropertyChanged
    {
        public person()
        {
            m_name = "mustafa";
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public int id {get;set; }

        private string m_name;
        public string name
        {
            get
            {
                
                return m_name;
            }
            set
            {
                if (m_name == value)
                    return;
                m_name = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }
        private string m_surname;
        public string surname
        {
            get
            {
                
                return m_surname;
            }
            set
            {
                if (m_surname == value)
                    return;
                m_surname = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(surname)));
                }
            }
        }
        private DateTime m_dateofBirth;
        public DateTime dateofBirth
        {
            get
            {

                return m_dateofBirth;
            }
            set
            {
                if (m_dateofBirth == value)
                    return;
                m_dateofBirth = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs((nameof(dateofBirth))));
                }
            }
        }
        // public Gender gender { get; set; }
        // public Married married { get; set; }
        private string m_gender;
        public string gender
        {
           
            get
            {
                
                return m_gender;
            }
            set
            {
                if (m_gender == value)
                    return;
                m_gender = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(gender)));
                }
            }
        }
        private string m_marired;
        public string married
        {
            get
            {
                return m_marired;
            }
            set
            {
                if (m_marired == value)
                    return;
                m_marired = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(married)));
                }
            }

        }


    }
}
