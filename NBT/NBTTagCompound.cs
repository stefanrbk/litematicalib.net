using java.util;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Generic.Dictionary<string, litematicalib.net.NBTBase>;

namespace litematicalib.net
{
    public class NBTTagCompound : NBTBase
    {
        public override NBTBase Copy() => throw new NotImplementedException();
        public override bool Equals(object obj) => throw new NotImplementedException();
        public override int GetHashCode() => throw new NotImplementedException();
        public override byte GetId() => throw new NotImplementedException();
        public override string ToString() => throw new NotImplementedException();
        public bool GetBoolean(string key)
        {
            return false;
        }
        public byte GetByte(string key)
        {
            return 0;
        }
        public byte[] GetByteArray(string key)
        {
            return null;
        }
        public NBTTagCompound GetCompoundTag(string key)
        {
            return null;
        }
        public double GetDouble(string key)
        {
            return 0.0;
        }
        public float GetFloat(string key)
        {
            return 0f;
        }
        public int[] GetIntArray(string key)
        {
            return null;
        }
        public int GetInteger(string key)
        {
            return 0;
        }
        public KeyCollection GetKeySet()
        {
            return null;
        }
        public long GetLong(string key)
        {
            return 0L;
        }
        public short GetShort(string key)
        {
            return 0;
        }
        public int GetSize()
        {
            return 0;
        }
        public string GetString(string key)
        {
            return null;
        }
        public NBTBase GetTag(string key)
        {
            return null;
        }
        public byte GetTagId(string key)
        {
            return 0;
        }
        public NBTTagList GetTagList(string key, int type)
        {
            return null;
        }
        public UUID GetUniqueId(string key)
        {
            return Guid.Empty;
        }
        public bool HasKey(string key)
        {
            return false;
        }
        public bool HasKey(string key, int type)
        {
            return false;
        }
        public bool HasUniqueId(string key)
        {
            return false;
        }
        public void Merge(NBTTagCompound other)
        {

        }
        public void RemoveTag(string key)
        {

        }
        public void SetBoolean(string key, bool value)
        {

        }
        public void SetByte(string key, byte value)
        {

        }
        public void SetByteArray(string key, byte[] value)
        {

        }
        public void SetDouble(string key, double value)
        {

        }
        public void SetFloat(string key, float value)
        {

        }
        public void SetIntArray(string key, int[] value)
        {

        }
        public void SetInteger(string key, int value)
        {

        }
        public void SetLong(string key, long value)
        {

        }
        public void SetShort(string key, short value)
        {

        }
        public void SetString(string key, string value)
        {

        }
        public void SetTag(string key, NBTBase value)
        {

        }
        public void SetUniqueId(string key, UUID value)
        {

        }
    }
}
