namespace Another_Morrowind_Utility.FileStructure
{
    class Subrecord
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public byte[] Data { get; set; }

        public Subrecord(string type, int size, byte[] data)
        {
            Type = type;
            Size = size;
            Data = data;
        }
    }
}
