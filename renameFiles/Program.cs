using System.IO;
using System.Linq;

namespace renameFiles
{
    class Program
    {
        private const string PATH = @"C:\Games\Stellaris\localisation\braz_por\";
        private const string EXT = ".yml";

        static void Main()
        {
            var files = Directory.GetFiles(PATH).ToList();

            files.Where(x => x.Contains("l_braz_por")).ToList().ForEach(file =>
            {
                var nameRefatored = Path.GetFileNameWithoutExtension(file).Replace("braz_por", "english");
                Directory.Move(file, PATH + nameRefatored + EXT);
            });
        }
    }
}
