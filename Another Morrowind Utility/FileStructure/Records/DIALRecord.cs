using System.Collections.Generic;

namespace Another_Morrowind_Utility.FileStructure
{
    class DIALRecord : Record
    {
        public DIALRecord(RecordHeader header, List<Subrecord> subrecords) : base(header, subrecords)
        {

        }
    }
}
