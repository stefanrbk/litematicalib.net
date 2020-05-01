using System;
using System.Collections.Generic;
using System.Text;

namespace litematicalib.net
{
    public abstract class NBTBase
    {
        public static string[] NBT_TYPES;
        public abstract NBTBase Copy();
        protected static NBTBase CreateNewByType(byte id)
        {
            return null;
        }
        public abstract override bool Equals(object obj);
        public abstract byte GetId();
        protected string GetString()
        {
            return "";
        }
        public abstract override int GetHashCode();
        public bool HasNoTags()
        {
            return true;
        }
        public abstract override string ToString();
        public abstract class NBTPrimitive : NBTBase
        {
            public abstract byte GetByte();
            public abstract double GetDouble();
            public abstract float GetFloat();
            public abstract int GetInt();
            public abstract long GetLong();
            public abstract short GetShort();
        }
    }
}
