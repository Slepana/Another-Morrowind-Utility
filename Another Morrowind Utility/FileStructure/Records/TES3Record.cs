using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure
{
    class TES3Record : Record
    {
        public string Version { get; }
        public string Author { get; }
        public string Description { get; }
        public bool IsMaster { get; }
        public int RecordsNum { get; }


        public TES3Record(RecordHeader header, List<Subrecord> subrecords) : base(header, subrecords)
        {
            if (subrecords[0].Type == "HEDR")
            {
                Version = BitConverter.ToSingle(subrecords[0].Data, 0).ToString();
                int type = BitConverter.ToInt32(subrecords[0].Data, 4);

                if (type == 32) throw new Exception("Save game files are not supported.");
                else if (type == 1)
                    IsMaster = true;
                else
                    IsMaster = false;

                // Because C# doesn't like c-strings
                int count = 0;
                while (count <= 32 && subrecords[0].Data[8 + count] != 0)
                    count++;
                Author = Encoding.ASCII.GetString(subrecords[0].Data, 8, count);

                count = 0;
                while (count <= 265 && subrecords[0].Data[40 + count] != 0)
                    count++;
                Description = Encoding.ASCII.GetString(subrecords[0].Data, 40, count);

                RecordsNum = BitConverter.ToInt32(subrecords[0].Data, 296);
            }
            else throw new FormatException("Invalid header structire.");

            /*
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
            */
        }
    }
}
