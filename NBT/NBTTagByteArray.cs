using System;
using System.Collections.Generic;
using System.Text;

namespace litematicalib.net
{
    public class NBTTagByteArray : NBTBase
    {
        public override NBTBase Copy() => throw new NotImplementedException();
        public override bool Equals(object obj) => ((object)this).Equals(obj);
        public override byte GetId() => throw new NotImplementedException();
        public override int GetHashCode() => ((object)this).GetHashCode();
        public override string ToString() => ((object)this).ToString();
        public byte[] GetByteArray()
        {
            return null;
        }

    }
}
