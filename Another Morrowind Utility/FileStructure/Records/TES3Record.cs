﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Another_Morrowind_Utility.FileStructure
{
    class TES3Record : Record
    {
        // HEDR properties
        public string Version { get; }
        public string Author { get; }
        public string Description { get; }
        public bool IsMaster { get; }
        public int RecordsNum { get; }

        // MAST and DATA properties
        public List<Tuple<string, long>> Masters { get; }

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
            
            string master;
            long length;
            Masters = new List<Tuple<string, long>>();

            // each MAST subrecord has a DATA subrecord following it
            for (int MASTcount = 1; MASTcount < subrecords.Count; MASTcount += 2) 
            {
                // Again c-strings
                int count = 0;
                while (subrecords[MASTcount].Data[count] != 0)
                    count++;
                master = Encoding.ASCII.GetString(subrecords[MASTcount].Data, 0, count);
                length = BitConverter.ToInt64(subrecords[MASTcount + 1].Data, 0);

                Masters.Add(Tuple.Create(master, length));
            }
        }
    }
}
