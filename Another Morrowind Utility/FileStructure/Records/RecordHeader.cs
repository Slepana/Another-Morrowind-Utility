using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    class RecordHeader
    {
        public byte[] Raw { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Unknown { get; set; }
        public int Flags { get; set; }   

        public RecordHeader(byte[] rawHeader)
        {
            Raw = rawHeader;
            Type = Encoding.ASCII.GetString(rawHeader, 0, 4);
            Size = BitConverter.ToInt32(rawHeader, 4);
            Unknown = BitConverter.ToInt32(rawHeader, 8);
            Flags = BitConverter.ToInt32(rawHeader, 12);
        }
    }
}