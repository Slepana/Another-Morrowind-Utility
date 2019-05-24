using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    /// <summary>
    /// A collection of records essentially
    /// </summary>
    class ESXFile
    {
        public List<Record> Records { get; set; }

        public ESXFile(List<Record> records)
        {
            Records = records;
        }
    }
}
