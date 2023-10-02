namespace party.test.tools.Extensions
{
    using System;

    public static class FileExtensions
    {
        public static string GetTemporalUniqueFolder()
        {
            string temporalFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            return temporalFolder;
        }
        public static string CreateTemporalUniqueFolder()
        {
            string temporalFolder = GetTemporalUniqueFolder();
            Directory.CreateDirectory(temporalFolder);
            return temporalFolder;
        }
        public static string CreateFileInUniqueFolder(this string filename)
        {
            string temporalFile = Path.Combine(CreateTemporalUniqueFolder(), filename);
            File.Create(temporalFile);
            return temporalFile;
        }
        public static string ShallowFileInUniqueFolder(this string filename)
        {
            string temporalFile = Path.Combine(CreateTemporalUniqueFolder(), filename);
            return temporalFile;
        }
    }
}
