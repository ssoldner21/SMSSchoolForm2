using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace SMSSchoolForm2
{
    public static class Program
    {
        public static School school1 = new School();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            DeserializeTheData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SerializeTheData();
        }

        public static void SerializeTheData()
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(School));
            TextWriter WriteFileStream = new StreamWriter(@"C:\Users\Sean\Desktop\VB.net\test.xml");
            //TextWriter WriteFileStream = new StreamWriter(@"U:\VB.net\test.xml");
            SerializerObj.Serialize(WriteFileStream, school1);
            WriteFileStream.Close();
        }

        public static void DeserializeTheData()
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(School));
            Stream reader = new FileStream(@"C:\Users\Sean\Desktop\VB.net\test.xml", FileMode.Open);
            //Stream reader = new FileStream(@"U:\VB.net\test.xml", FileMode.Open);
            school1 = (School)SerializerObj.Deserialize(reader);
            reader.Close();
        }
    }
}
