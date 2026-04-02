using System;

namespace BindingOfIsaacCheatSheetApp.Models
{
    public static class DailySeedGenerator
    {
        private const string Characters = "0123456789abcdefghijklmnopqrstuvwxyz";
        private const int SeedLength = 8;

        public static string GenerateDailySeed()
        {
            // Use today's date as the seed - same date always produces same seed
            int seed = DateTime.Now.Date.GetHashCode();
            Random random = new Random(seed);
            
            string dailySeed = "";
            for (int i = 0; i < SeedLength; i++)
            {
                dailySeed += Characters[random.Next(Characters.Length)];
            }
            
            return dailySeed;
        }
    }
}
