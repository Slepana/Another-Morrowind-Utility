using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    class DIALRecord : Record
    {
        public DIALRecord(RecordHeader header, List<Subrecord> subrecords) : base(header, subrecords)
        {

        }
    }
}
