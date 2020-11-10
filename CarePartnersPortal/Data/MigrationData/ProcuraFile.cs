using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ProcuraFile
    {
        public int ID { get; set; }
        public string Source_DB_Name { get; set; }
        public ulong client_number { get; set; }
        public string File_Name { get; set; }
        public DateTime File_Date { get; set; }
        public string File_Type { get; set; }
        public string DEF_SUBJECT { get; set; }
        public string File_Path { get; set; }
        public long ZIP_File_Size { get; set; }
        public Byte[] ZIP_File_Image { get; set; }
        public long File_Size { get; set; }
    }
}
