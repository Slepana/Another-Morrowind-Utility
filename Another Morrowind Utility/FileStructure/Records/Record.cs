using System.Collections.Generic;

namespace Another_Morrowind_Utility.FileStructure
{
    class Record
    {
        public RecordHeader Header { get; set; }
        public List<Subrecord> Subrecords { get; set; }

        public Record(RecordHeader header, List<Subrecord> subrecords)
        {
            Header = header;
            Subrecords = subrecords;
        }
    }
}
