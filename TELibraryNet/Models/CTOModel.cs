

namespace TELibraryNet.Models
{
    public class CTOModel
    {
        private int id;
        private string material;
        private string materialDescription;
        private string catalogNumber;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string MaterialDescription
        {
            get { return materialDescription; }
            set { materialDescription = value; }
        }
        public string CatalogNumber
        {
            get { return catalogNumber; }
            set { catalogNumber = value; }
        }
        public void ParseCTO(string line)
        {
            Material = line.Substring(4, 18);
            MaterialDescription = line.Substring(36, 40);
            CatalogNumber = line.Substring(242, 30);
        }
    }
}
