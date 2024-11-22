namespace AIOverhaulPatcher
{
    class Settings
    {
        public bool IgnoreIdenticalToLastOverride { get; set; } = false;
        public bool IgnorePlayerRecord { get; set; } = true;
        public bool PatchProtectionLevel { get; set; } = true;
        public bool MergeItems { get; set; } = true;
    }
}
