using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SteamLauncher.Modules
{
    internal class RemoveWhatsNewModule
    {
        // TODO: Do not use hardcoded directories and make these parameters confirgurable.
        private static string filepath = "steamui\\css\\sp.css";
        private static string locator = "libraryhome_UpdatesContainer_17uEB{";
        private static string replace = "display: none !important;";

        public static void RemoveWhatsNew() { 
            Write(Modify(Read()));
        }

        private static string Read()
        {
            var content = string.Empty;
            using (StreamReader reader = new StreamReader(filepath))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }
            return content;
        }

        /* Replace the contents between 
         * "libraryhome_UpdatesContainer_17uEB{" and "}"
         * with "display: none !important;" followed by 
         * a number of spaces in order to keep the file length in tact */
        private static string Modify(string content)
        {
            int startIndex = content.IndexOf(locator);
            int endIndex = content.IndexOf("}", startIndex);

            var output = new StringBuilder();
            output.Append(content.Substring(0, startIndex));
            output.Append(locator);
            output.Append(replace);

            int numSpaces = endIndex - output.Length;
            for (int i = 0; i < numSpaces; i++)
                output.Append(' ');
            output.Append(content.Substring(endIndex));

            return output.ToString();
        }

        private static void Write(string content)
        {
            File.WriteAllText(filepath, content);
        }
    }
}
