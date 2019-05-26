using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Another_Morrowind_Utility.FileStructure.Records;

namespace Another_Morrowind_Utility.FileStructure
{
    class ESXParser
    {
        private const int HEADER_SIZE = 16;

        RecordFactory factory = new RecordFactory();

        /// <summary>
        /// Reads all records in a file and returns a collection of them
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>New collection of records</returns>
        public ESXFile Parse(string path)
        {
            List<Record> records = new List<Record>();
            Record record; 
            //throw new NotImplementedException();
            using (FileStream fs = File.OpenRead(path))
            {
                while ((record = ReadRecord(fs)) != null)
                {
                    records.Add(record);
                }
            }

            return new ESXFile(records);
        }

        /// <summary>
        /// Attempts to read a record from file,
        /// returns null upon reaching end of file
        /// </summary>
        /// <param name="fs">file stream to read from</param>
        /// <param name="offset">offset to begin from</param>
        /// <returns>A new record or null</returns>
        public Record ReadRecord(FileStream fs)
        {
            byte[] rawHeader = new byte[HEADER_SIZE];
            int count = fs.Read(rawHeader, 0, HEADER_SIZE);
            if (count == 0)
                return null;
            else if (count < 16)
                throw new FormatException("Unexpected file size.");

            RecordHeader header = new RecordHeader(rawHeader);

            byte[] data = new byte[header.Size];
            count = fs.Read(data, 0, header.Size);
            if (count < header.Size)
                throw new Exception("Unexpected file size.");

            return factory.ConstructRecord(header, ParseSubrecords(data));
        }

        private List<Subrecord> ParseSubrecords(byte[] data)
        {
            List<Subrecord> subrecords = new List<Subrecord>();

            string type;
            int size;
            int offset = 0;
            int count = data.Length;
            byte[] subrecordData;

            while (count > 0)
            {
                if (count < 8)
                    throw new FormatException("Unexpected file size.");
                
                type = Encoding.ASCII.GetString(data, offset, 4);
                count -= 4;
                offset += 4;
                size = BitConverter.ToInt32(data, offset);
                count -= 4;
                offset += 4;

                subrecordData = new byte[size];
                Array.Copy(data, offset, subrecordData, 0, size);
                count -= size;
                offset += size;

                subrecords.Add(new Subrecord(type, size, subrecordData));               
            }

            return subrecords;
        }
    }
}
