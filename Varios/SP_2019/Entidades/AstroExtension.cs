using System;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\planeta.txt";

            try
            {
                StreamWriter f = new StreamWriter(pathEscritorio, true);
                f.WriteLine(plan);
                f.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool GuardarXML(this Satelite sat)
        {
            string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\planeta.xml";

            try
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Satelite));

                FileStream fStream = File.Open(pathEscritorio, FileMode.Create);

                serializer.Serialize(fStream, sat);

                fStream.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
