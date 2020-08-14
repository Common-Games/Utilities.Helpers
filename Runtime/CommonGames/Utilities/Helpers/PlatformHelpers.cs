
namespace CommonGames.Utilities.Helpers
{

    using System;

    public static class PlatformHelpers
    {
        [Flags]
        public enum Platforms
        {
            //WindowsEditor,
            //OSXEditor,
            //LinuxEditor,

            //WindowsPlayer,
            //OSXPlayer,
            //LinuxPlayer,

            //Windows = WindowsEditor | WindowsPlayer,
            //OSX     = OSXEditor | OSXPlayer,
            //Linux   = LinuxEditor | LinuxPlayer,
            None = 0,

            Windows = 1,
            OSX = 2,
            Linux = 4,

            Android = 8,
            IPhone = 16,

            WebGL = 32,

            PS4 = 64,
            XboxOne = 128,
            Switch = 256,

            Stadia = 512,

            Lumin = 1024,

            TvOS = 2048,

            All = 1 | 2 | 4 | 8 | 16 | 32 | 64 | 128 | 256 | 512 | 1024 | 2048,
        }
    }
}