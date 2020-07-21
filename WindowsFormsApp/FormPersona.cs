using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormPersona : Form
    {
        private BindingList<Person> PersonList = new BindingList<Person>();
        public FormPersona()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim().ToUpper();
            if (nome == "")
            {
                MessageBox.Show("Per favore inserire il nome della persona");
            }
            else
            {
                string padre = textBoxPadre.Text.Trim().ToUpper();

                PersonList.Add(new Person
                {
                    Name = nome,
                    FathersName = padre
                });

                dataGridViewLista.DataSource = PersonList;
                textBoxNome.Text = "";
                textBoxPadre.Text = "";
            }
        }

        private string FindAncestor(string name)
        {
            string ancestor = "";
            string father = "";

            foreach (var person in PersonList)
            {
                if (person.Name == name)
                {
                    father = person.FathersName;

                    if (father != "")
                    {
                        ancestor = FindAncestor(father);

                        if (ancestor == "")
                        {
                            ancestor = father;
                            return ancestor;
                        }
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            return ancestor;
        }

        private void buttonSearchAncestor_Click(object sender, EventArgs e)
        {
            string nameToFind = textBoxNomeCerca.Text.Trim().ToUpper();

            string ancestor = "";

            if (nameToFind == "")
            {
                MessageBox.Show("Per favore inserire il nome della persona");
            }
            else
            {
                foreach (var person in PersonList)
                {
                    if (nameToFind == person.Name)
                    {
                        ancestor = FindAncestor(nameToFind);
                    }

                }
            }

            textBoxAncestor.Text = ancestor;

        }
    }
}
