namespace litematicalib.net
{
    public class NBTTagList : NBTBase
    {
        public override NBTBase Copy() => throw new System.NotImplementedException();
        public override bool Equals(object obj) => throw new System.NotImplementedException();
        public override int GetHashCode() => throw new System.NotImplementedException();
        public override byte GetId() => throw new System.NotImplementedException();
        public override string ToString() => throw new System.NotImplementedException();

        public void AppendTag(NBTBase nbt)
        {

        }
        public NBTBase Get(int idx)
        {
            return null;
        }
        public NBTTagCompound GetCompoundTagAt(int i)
        {
            return null;
        }
        public double GetDoubleAt(int i)
        {
            return 0.0;
        }
        public float GetFloatAt(int i)
        {
            return 0.0f;
        }
        public int[] GetIntArrayAt(int i)
        {
            return null;
        }
        public int GetIntegerAt(int i)
        {
            return 0;
        }
        public string GetStringAt(int i)
        {
            return null;
        }
        public int GetTagType()
        {
            return 0;
        }
        public NBTBase RemoveTag(int i)
        {
            return null;
        }
        public void Set(int idx, NBTBase nbt)
        {

        }
        public int TagCount()
        {
            return 0;
        }
    }
}