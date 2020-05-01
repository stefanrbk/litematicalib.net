using System;
using System.Collections.Generic;
using System.Text;

namespace litematicalib.net
{
    public class NBTTagEnd : NBTBase
    {
        public override NBTBase Copy() => throw new NotImplementedException();
        public override bool Equals(object obj) => ((object)this).Equals(obj);
        public override int GetHashCode() => ((object)this).GetHashCode();
        public override byte GetId() => throw new NotImplementedException();
        public override string ToString() => ((object)this).ToString();
    }
}
