using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Morrowind_Utility.FileStructure.Records
{
    class RecordFactory
    {
        Dictionary<string, Func<RecordHeader, List<Subrecord>, Record>> dict;
        public RecordFactory()
        {
            dict = new Dictionary<string, Func<RecordHeader, List<Subrecord>, Record>>();

            dict.Add("TES3", (h, d) => new Record(h, d));
            dict.Add("GMST", (h, d) => new Record(h, d));
            dict.Add("GLOB", (h, d) => new Record(h, d));
            dict.Add("CLAS", (h, d) => new Record(h, d));
            dict.Add("FACT", (h, d) => new Record(h, d));
            dict.Add("RACE", (h, d) => new Record(h, d));
            dict.Add("SOUN", (h, d) => new Record(h, d));
            dict.Add("SKIL", (h, d) => new Record(h, d));
            dict.Add("MGEF", (h, d) => new Record(h, d));
            dict.Add("SCPT", (h, d) => new Record(h, d));
            dict.Add("REGN", (h, d) => new Record(h, d));
            dict.Add("BSGN", (h, d) => new Record(h, d));
            dict.Add("LTEX", (h, d) => new Record(h, d));
            dict.Add("STAT", (h, d) => new Record(h, d));
            dict.Add("DOOR", (h, d) => new Record(h, d));
            dict.Add("MISC", (h, d) => new Record(h, d));
            dict.Add("WEAP", (h, d) => new Record(h, d));
            dict.Add("CONT", (h, d) => new Record(h, d));
            dict.Add("SPEL", (h, d) => new Record(h, d));
            dict.Add("CREA", (h, d) => new Record(h, d));
            dict.Add("BODY", (h, d) => new Record(h, d));
            dict.Add("LIGH", (h, d) => new Record(h, d));
            dict.Add("ENCH", (h, d) => new Record(h, d));
            dict.Add("NPC_", (h, d) => new Record(h, d));
            dict.Add("ARMO", (h, d) => new Record(h, d));
            dict.Add("CLOT", (h, d) => new Record(h, d));
            dict.Add("REPA", (h, d) => new Record(h, d));
            dict.Add("ACTI", (h, d) => new Record(h, d));
            dict.Add("APPA", (h, d) => new Record(h, d));
            dict.Add("LOCK", (h, d) => new Record(h, d));
            dict.Add("PROB", (h, d) => new Record(h, d));
            dict.Add("INGR", (h, d) => new Record(h, d));
            dict.Add("BOOK", (h, d) => new Record(h, d));
            dict.Add("ALCH", (h, d) => new Record(h, d));
            dict.Add("LEVI", (h, d) => new Record(h, d));
            dict.Add("LEVC", (h, d) => new Record(h, d));
            dict.Add("CELL", (h, d) => new Record(h, d));
            dict.Add("LAND", (h, d) => new Record(h, d));
            dict.Add("PGRD", (h, d) => new Record(h, d));
            dict.Add("SNDG", (h, d) => new Record(h, d));
            dict.Add("DIAL", (h, d) => new Record(h, d));
            dict.Add("INFO", (h, d) => new Record(h, d));
            dict.Add("SSCR", (h, d) => new Record(h, d));

            /* Future hopes:
            
            dict.Add("TES3", (h, d) => new TES3Record(h, d));
            dict.Add("GMST", (h, d) => new GMSTRecord(h, d));
            dict.Add("GLOB", (h, d) => new GLOBRecord(h, d));
            dict.Add("CLAS", (h, d) => new CLASRecord(h, d));
            dict.Add("FACT", (h, d) => new FACTRecord(h, d));
            dict.Add("RACE", (h, d) => new RACERecord(h, d));
            dict.Add("SOUN", (h, d) => new SOUNRecord(h, d));
            dict.Add("SKIL", (h, d) => new SKILRecord(h, d));
            dict.Add("MGEF", (h, d) => new MGEFRecord(h, d));
            dict.Add("SCPT", (h, d) => new SCPTRecord(h, d));
            dict.Add("REGN", (h, d) => new REGNRecord(h, d));
            dict.Add("BSGN", (h, d) => new BSGNRecord(h, d));
            dict.Add("LTEX", (h, d) => new LTEXRecord(h, d));
            dict.Add("STAT", (h, d) => new STATRecord(h, d));
            dict.Add("DOOR", (h, d) => new DOORRecord(h, d));
            dict.Add("MISC", (h, d) => new MISCRecord(h, d));
            dict.Add("WEAP", (h, d) => new WEAPRecord(h, d));
            dict.Add("CONT", (h, d) => new CONTRecord(h, d));
            dict.Add("SPEL", (h, d) => new SPELRecord(h, d));
            dict.Add("CREA", (h, d) => new CREARecord(h, d));
            dict.Add("BODY", (h, d) => new BODYRecord(h, d));
            dict.Add("LIGH", (h, d) => new LIGHRecord(h, d));
            dict.Add("ENCH", (h, d) => new ENCHRecord(h, d));
            dict.Add("NPC_", (h, d) => new NPC_Record(h, d));
            dict.Add("ARMO", (h, d) => new ARMORecord(h, d));
            dict.Add("CLOT", (h, d) => new CLOTRecord(h, d));
            dict.Add("REPA", (h, d) => new REPARecord(h, d));
            dict.Add("ACTI", (h, d) => new ACTIRecord(h, d));
            dict.Add("APPA", (h, d) => new APPARecord(h, d));
            dict.Add("LOCK", (h, d) => new LOCKRecord(h, d));
            dict.Add("PROB", (h, d) => new PROBRecord(h, d));
            dict.Add("INGR", (h, d) => new INGRRecord(h, d));
            dict.Add("BOOK", (h, d) => new BOOKRecord(h, d));
            dict.Add("ALCH", (h, d) => new ALCHRecord(h, d));
            dict.Add("LEVI", (h, d) => new LEVIRecord(h, d));
            dict.Add("LEVC", (h, d) => new LEVCRecord(h, d));
            dict.Add("CELL", (h, d) => new CELLRecord(h, d));
            dict.Add("LAND", (h, d) => new LANDRecord(h, d));
            dict.Add("PGRD", (h, d) => new PGRDRecord(h, d));
            dict.Add("SNDG", (h, d) => new SNDGRecord(h, d));
            dict.Add("DIAL", (h, d) => new DIALRecord(h, d));
            dict.Add("INFO", (h, d) => new INFORecord(h, d));
            dict.Add("SSCR", (h, d) => new SSCRRecord(h, d));
            */
        }

        public Record ConstructRecord(RecordHeader header, List<Subrecord> subrecords)
        {
            Func<RecordHeader, List<Subrecord>, Record> f; 
            if (!dict.TryGetValue(header.Type, out f))
                throw new ArgumentException("Invalid record type.");
            return f(header, subrecords);
        }
    }
}