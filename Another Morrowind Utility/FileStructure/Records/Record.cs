using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    class Record
    {
        public RecordHeader Header { get; set; }
        //public byte[] Data { get; }
        public List<Subrecord> Subrecords { get; set; }

        public Record(RecordHeader header, List<Subrecord> subrecords)
        {
            Header = header;
            Subrecords = subrecords;
        }
    }
}
