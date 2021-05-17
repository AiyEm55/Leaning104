using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace CH54_ReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypName = txtTypeName.Text;
            Type T = Type.GetType(TypName);

            lsMethods.Items.Clear();
            lsProperties.Items.Clear();
            lsConstructors.Items.Clear();


            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lsMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo Property in properties)
            {
                lsProperties.Items.Add(Property.PropertyType.Name + " " + Property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lsConstructors.Items.Add(constructor.ToString());
            }
        }
    }
}
