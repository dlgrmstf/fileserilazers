using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _deneme1
{
    public partial class Frmadd : Form
    {
        person m_person;
        public Frmadd()
        {
            InitializeComponent();
        }
        public Frmadd(person person):this()
        {
            
            m_person = person;
            txtName.Text = m_person.name;
            txSurname.Text = m_person.surname;
            datetimeDateofBirth.Value = m_person.dateofBirth;
            cbbGender.Text = m_person.gender;
            cbbMaried.Text = m_person.married;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_person.name = txtName.Text;
            m_person.surname = txSurname.Text;
            m_person.dateofBirth = datetimeDateofBirth.Value;
            m_person.gender = cbbGender.Text;
            m_person.married = cbbMaried.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txSurname_Click(object sender, EventArgs e)
        {
            txSurname.Clear();
        }
    }
}
