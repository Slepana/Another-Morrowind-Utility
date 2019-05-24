using System;
using System.Collections.Generic;

namespace Another_Morrowind_Utility.FileStructure
{
    class Types
    {
        public enum RecordType {
            TES3, GMST, GLOB, CLAS, FACT, RACE, SOUN, SKIL, MGEF,
            SCPT, REGN, BSGN, LTEX, STAT, DOOR, MISC, WEAP, CONT,
            SPEL, CREA, BODY, LIGH, ENCH, NPC_, ARMO, CLOT, REPA,
            ACTI, APPA, LOCK, PROB, INGR, BOOK, ALCH, LEVI, LEVC,
            CELL, LAND, PGRD, SNDG, DIAL, INFO, SSCR
        };

        public class TypeMap
        {
            private Dictionary<string, RecordType> dictStrRec;
            private Dictionary<RecordType, string> dictRecStr;

            public TypeMap()
            {
                dictRecStr = new Dictionary<RecordType, string>();
                dictStrRec = new Dictionary<string, RecordType>();

                dictStrRec.Add("TES3", Types.RecordType.TES3);
                dictStrRec.Add("GMST", Types.RecordType.GMST);
                dictStrRec.Add("GLOB", Types.RecordType.GLOB);
                dictStrRec.Add("CLAS", Types.RecordType.CLAS);
                dictStrRec.Add("FACT", Types.RecordType.FACT);
                dictStrRec.Add("RACE", Types.RecordType.RACE);
                dictStrRec.Add("SOUN", Types.RecordType.SOUN);
                dictStrRec.Add("SKIL", Types.RecordType.SKIL);
                dictStrRec.Add("MGEF", Types.RecordType.MGEF);
                dictStrRec.Add("SCPT", Types.RecordType.SCPT);
                dictStrRec.Add("REGN", Types.RecordType.REGN);
                dictStrRec.Add("BSGN", Types.RecordType.BSGN);
                dictStrRec.Add("LTEX", Types.RecordType.LTEX);
                dictStrRec.Add("STAT", Types.RecordType.STAT);
                dictStrRec.Add("DOOR", Types.RecordType.DOOR);
                dictStrRec.Add("MISC", Types.RecordType.MISC);
                dictStrRec.Add("WEAP", Types.RecordType.WEAP);
                dictStrRec.Add("CONT", Types.RecordType.CONT);
                dictStrRec.Add("SPEL", Types.RecordType.SPEL);
                dictStrRec.Add("CREA", Types.RecordType.CREA);
                dictStrRec.Add("BODY", Types.RecordType.BODY);
                dictStrRec.Add("LIGH", Types.RecordType.LIGH);
                dictStrRec.Add("ENCH", Types.RecordType.ENCH);
                dictStrRec.Add("NPC_", Types.RecordType.NPC_);
                dictStrRec.Add("ARMO", Types.RecordType.ARMO);
                dictStrRec.Add("CLOT", Types.RecordType.CLOT);
                dictStrRec.Add("REPA", Types.RecordType.REPA);
                dictStrRec.Add("ACTI", Types.RecordType.ACTI);
                dictStrRec.Add("APPA", Types.RecordType.APPA);
                dictStrRec.Add("LOCK", Types.RecordType.LOCK);
                dictStrRec.Add("PROB", Types.RecordType.PROB);
                dictStrRec.Add("INGR", Types.RecordType.INGR);
                dictStrRec.Add("BOOK", Types.RecordType.BOOK);
                dictStrRec.Add("ALCH", Types.RecordType.ALCH);
                dictStrRec.Add("LEVI", Types.RecordType.LEVI);
                dictStrRec.Add("LEVC", Types.RecordType.LEVC);
                dictStrRec.Add("CELL", Types.RecordType.CELL);
                dictStrRec.Add("LAND", Types.RecordType.LAND);
                dictStrRec.Add("PGRD", Types.RecordType.PGRD);
                dictStrRec.Add("SNDG", Types.RecordType.SNDG);
                dictStrRec.Add("DIAL", Types.RecordType.DIAL);
                dictStrRec.Add("INFO", Types.RecordType.INFO);
                dictStrRec.Add("SSCR", Types.RecordType.SSCR);

                dictRecStr.Add(Types.RecordType.TES3, "TES3");
                dictRecStr.Add(Types.RecordType.GMST, "GMST");
                dictRecStr.Add(Types.RecordType.GLOB, "GLOB");
                dictRecStr.Add(Types.RecordType.CLAS, "CLAS");
                dictRecStr.Add(Types.RecordType.FACT, "FACT");
                dictRecStr.Add(Types.RecordType.RACE, "RACE");
                dictRecStr.Add(Types.RecordType.SOUN, "SOUN");
                dictRecStr.Add(Types.RecordType.SKIL, "SKIL");
                dictRecStr.Add(Types.RecordType.MGEF, "MGEF");
                dictRecStr.Add(Types.RecordType.SCPT, "SCPT");
                dictRecStr.Add(Types.RecordType.REGN, "REGN");
                dictRecStr.Add(Types.RecordType.BSGN, "BSGN");
                dictRecStr.Add(Types.RecordType.LTEX, "LTEX");
                dictRecStr.Add(Types.RecordType.STAT, "STAT");
                dictRecStr.Add(Types.RecordType.DOOR, "DOOR");
                dictRecStr.Add(Types.RecordType.MISC, "MISC");
                dictRecStr.Add(Types.RecordType.WEAP, "WEAP");
                dictRecStr.Add(Types.RecordType.CONT, "CONT");
                dictRecStr.Add(Types.RecordType.SPEL, "SPEL");
                dictRecStr.Add(Types.RecordType.CREA, "CREA");
                dictRecStr.Add(Types.RecordType.BODY, "BODY");
                dictRecStr.Add(Types.RecordType.LIGH, "LIGH");
                dictRecStr.Add(Types.RecordType.ENCH, "ENCH");
                dictRecStr.Add(Types.RecordType.NPC_, "NPC_");
                dictRecStr.Add(Types.RecordType.ARMO, "ARMO");
                dictRecStr.Add(Types.RecordType.CLOT, "CLOT");
                dictRecStr.Add(Types.RecordType.REPA, "REPA");
                dictRecStr.Add(Types.RecordType.ACTI, "ACTI");
                dictRecStr.Add(Types.RecordType.APPA, "APPA");
                dictRecStr.Add(Types.RecordType.LOCK, "LOCK");
                dictRecStr.Add(Types.RecordType.PROB, "PROB");
                dictRecStr.Add(Types.RecordType.INGR, "INGR");
                dictRecStr.Add(Types.RecordType.BOOK, "BOOK");
                dictRecStr.Add(Types.RecordType.ALCH, "ALCH");
                dictRecStr.Add(Types.RecordType.LEVI, "LEVI");
                dictRecStr.Add(Types.RecordType.LEVC, "LEVC");
                dictRecStr.Add(Types.RecordType.CELL, "CELL");
                dictRecStr.Add(Types.RecordType.LAND, "LAND");
                dictRecStr.Add(Types.RecordType.PGRD, "PGRD");
                dictRecStr.Add(Types.RecordType.SNDG, "SNDG");
                dictRecStr.Add(Types.RecordType.DIAL, "DIAL");
                dictRecStr.Add(Types.RecordType.INFO, "INFO");
                dictRecStr.Add(Types.RecordType.SSCR, "SSCR");
            }

            public string RecTypeToString(RecordType type)
            {
                string str;
                if (!dictRecStr.TryGetValue(type, out str))
                    throw new Exception("Invalid record type.");
                return str;
            }

            public RecordType StringToRecType(string str)
            {
                RecordType recType;
                if (!dictStrRec.TryGetValue(str, out recType))
                    throw new Exception("Invalid record type.");
                return recType;
            }
        } 
    }
}
