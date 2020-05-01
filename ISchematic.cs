using System;
using System.IO;

namespace litematicalib.net
{
    public interface ISchematic
    {
        ///<summary>Clears all the data in this schematic</summary>
        void Clear();

        ///<summary>Returns the file this schematic was read from, if any.</summary>
        File GetFile();

        ///<summary>Returns the metadata object for this schematic</summary>
        SchematicMetadata GetMetadata();
    }
}
