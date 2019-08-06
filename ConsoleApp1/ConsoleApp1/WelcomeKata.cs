using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Welcome
    {
        public static string Greet(string language)
        {
            #region dictionary
            string[,] dictionary = new string[17, 2]
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };
            #endregion

            for (int i = 0; i < 17; i++)
            {
                if (dictionary[i, 0] == language)
                    return dictionary[i, 1];
            }
            return "Welcome";
        }

    }
}
