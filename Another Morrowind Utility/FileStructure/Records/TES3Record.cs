using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    class TES3Record : Record
    {
        public Record Source { get; }
        public string Version { get; }
        public string Author { get; }
        public string Description { get; }
        public bool IsMaster { get; }
        public int RecordsNum { get; }


        public TES3Record(RecordHeader header, byte[] data) : base(header)
        {
            Subrecords = new List<Subrecord>();

            Version = BitConverter.ToSingle(data, 8).ToString();

            IsMaster = (data[15] == 1);

            // Because C# doesn't like c-strings
            int count = 0;
            while (count <= 32 && data[16 + count] != 0)
                count++;
            Author = Encoding.ASCII.GetString(data, 16, count);

            count = 0;
            while (count <= 265 && data[48 + count] != 0)
                count++;
            Description = Encoding.ASCII.GetString(data, 48, count);

            RecordsNum = BitConverter.ToInt32(data, 304);
        }
    }
}
