using System.ComponentModel.Design;
using System.Xml.Serialization;
using XMLToObjectApp.Model;

namespace XMLToObjectApp
{
    public partial class Form1 : Form
    {
        ItemInfo itemInfo;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(ItemInfo));
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    itemInfo = (ItemInfo)serializer.Deserialize(stream);
                    string textData = "Document " + Environment.NewLine + Environment.NewLine;

                    textData = textData + itemInfo.document.id + Environment.NewLine;
                    textData = textData + itemInfo.document.name + Environment.NewLine;
                    textData = textData + itemInfo.document.revision + Environment.NewLine;
                    textData = textData + itemInfo.document.type + Environment.NewLine;
                    foreach (var property in itemInfo.document.properties)
                    {
                        textData = textData + property.key + ": " + property.value + Environment.NewLine;
                    }

                    textData = textData + Environment.NewLine;
                    textData = textData + "Item" + Environment.NewLine + Environment.NewLine;
                    textData = textData + itemInfo.item.id + Environment.NewLine;
                    textData = textData + itemInfo.item.name + Environment.NewLine;
                    textData = textData + itemInfo.item.revision + Environment.NewLine;
                    textData = textData + itemInfo.item.type + Environment.NewLine;
                    textData = textData + itemInfo.item.type3DX + Environment.NewLine;
                    foreach (var property in itemInfo.item.properties)
                    {
                        textData = textData + property.key + ": " + property.value + Environment.NewLine;
                    }

                    textData = textData + Environment.NewLine;
                    textData = textData + "Projects" + Environment.NewLine + Environment.NewLine;
                    foreach (var project in itemInfo.projects)
                    {
                        textData = textData + project.id + Environment.NewLine;
                        textData = textData + project.name + Environment.NewLine;
                        foreach (var property in project.properties)
                        {
                            textData = textData + property.key + ": " + property.value + Environment.NewLine;
                        }
                        textData = textData + Environment.NewLine;


                    }
                    textBox1.Text = textData;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }

            }
            else
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox2.Text;
            bool found = false;
            string value = "No value found!";
            foreach (var property in itemInfo.document.properties)
            {
                if (property.key == key)
                {
                    found = true;
                    value = property.value;
                }
            }
            label7.Text = value;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;
            bool found = false;
            string value = "No value found!";
            foreach (var property in itemInfo.item.properties)
            {
                if (property.key == key)
                {
                    found = true;
                    value = property.value;
                }
            }
            label8.Text = value;

        }
    }

}
