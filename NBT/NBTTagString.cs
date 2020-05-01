using System;
using System.Collections.Generic;
using System.Text;

namespace litematicalib.net
{
    public class NBTTagString : NBTBase
    {
        public override NBTBase Copy() => throw new NotImplementedException();
        public override bool Equals(object obj) => throw new NotImplementedException();
        public override int GetHashCode() => throw new NotImplementedException();
        public override byte GetId() => throw new NotImplementedException();
        public override string ToString() => throw new NotImplementedException();

        public NBTTagString()
        {

        }
        public NBTTagString(string data)
        {

        }
        public string GetString()
        {
            return null;
        }
    }
}
