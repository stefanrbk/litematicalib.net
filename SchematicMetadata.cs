using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace litematicalib.net
{
    public class SchematicMetadata
    {
        public string Name { get; set; } = "?";
        public string Author { get; set; } = "?";
        public string Description { get; set; }
        public Vector3 EnclosingSize { get; set; } = Vector3.Zero;
        public long TimeCreated { get; set; }
        public long TimeModified { get; set; }
        public int RegionCount { get; set; }
        public long TotalVolume { get; set; } = -1;
        public long TotalBlocks { get; set; } = -1;
        public bool ModifiedSinceSaved { get; private set; }
        public int[] ThumbnailPixelData { get; set; }

        public bool HasBeenModified() => TimeCreated != TimeModified;
        public void SetModifiedSinceSaved() => ModifiedSinceSaved = true;
        public void ClearModifiedSinceSaved() => ModifiedSinceSaved = false;
        public void SetTimeModifiedToNow() => TimeModified = DateTime.Now.Ticks;
        public void CopyFrom(SchematicMetadata other)
        {
            other ??= new SchematicMetadata();
            Name = other.Name;
            Author = other.Author;
            Description = other.Description;
            EnclosingSize = other.EnclosingSize;
            TimeCreated = other.TimeCreated;
            TimeModified = other.TimeModified;
            RegionCount = other.RegionCount;
            TotalVolume = other.TotalVolume;
            TotalBlocks = other.TotalBlocks;
            ModifiedSinceSaved = false;

            if (other.ThumbnailPixelData != null)
            {
                ThumbnailPixelData = new int[other.ThumbnailPixelData.Length];
                other.ThumbnailPixelData.CopyTo(ThumbnailPixelData, 0);
            }
            else
                ThumbnailPixelData = null;
        }
        /*
    public void fromTag(NBTTagCompound tag)
    {
        if (tag.hasKey("Name", Constants.NBT.TAG_STRING))
        {
            this.name = tag.getString("Name");
        }

        if (tag.hasKey("Author", Constants.NBT.TAG_STRING))
        {
            this.author = tag.getString("Author");
        }

        if (tag.hasKey("Description", Constants.NBT.TAG_STRING))
        {
            this.description = tag.getString("Description");
        }

        if (tag.hasKey("RegionCount", Constants.NBT.TAG_INT))
        {
            this.regionCount = tag.getInteger("RegionCount");
        }

        if (tag.hasKey("TotalVolume", Constants.NBT.TAG_LONG) || tag.hasKey("TotalVolume", Constants.NBT.TAG_INT))
        {
            this.totalVolume = tag.getLong("TotalVolume");
        }

        if (tag.hasKey("TotalBlocks", Constants.NBT.TAG_LONG) || tag.hasKey("TotalBlocks", Constants.NBT.TAG_INT))
        {
            this.totalBlocks = tag.getLong("TotalBlocks");
        }

        if (tag.hasKey("TimeCreated", Constants.NBT.TAG_LONG))
        {
            this.timeCreated = tag.getLong("TimeCreated");
        }

        if (tag.hasKey("TimeModified", Constants.NBT.TAG_LONG))
        {
            this.timeModified = tag.getLong("TimeModified");
        }

        if (tag.hasKey("EnclosingSize", Constants.NBT.TAG_COMPOUND))
        {
            Vec3i size = NBTUtils.readBlockPos(tag.getCompoundTag("EnclosingSize"));

            if (size != null)
            {
                this.enclosingSize = size;
            }
        }

        if (tag.hasKey("PreviewImageData", Constants.NBT.TAG_INT_ARRAY))
        {
            this.thumbnailPixelData = tag.getIntArray("PreviewImageData");
        }
        else
        {
            this.thumbnailPixelData = null;
        }
    }
         */
    }
}
