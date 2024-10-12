namespace Methods
{
    internal class Program
    {
        static void Main()
        {
            #region Task 1
            /*--> CustomIndexOf(); Elə bir method yazın ki göndərilən array daxilində göndərilmiş olan dəyəri axtarsın və həmin index-i qaytarsın. Əgər yoxdursa geriyə -1 qaytarsın. <--*/

            //int[] arrInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.Write("Axtarilacaq ededi daxil edin: ");
            //int numInput = Convert.ToInt32(Console.ReadLine());
            //if (CustomIndexOf(arrInput, numInput) == -1)
            //    Console.WriteLine("Tapilmadi!");
            //else
            //    Console.WriteLine($"Eded {CustomIndexOf(arrInput, numInput)}-cu indexde tapildi!");
            #endregion

            #region Task 2 & 3
            /*--> CustomToUpper(); Elə bir method yazın ki göndərilən string-i böyük hərflərlə yazılmış versiyasını geriyə qaytarsın. <--*/
            /*--> CustomToLower(); Elə bir method yazın ki göndərilən string-i kicik hərflərlə yazılmış versiyasını geriyə qaytarsın. <--*/

            //Console.Write("Metin daxil edin: ");
            //string textInput = Console.ReadLine();
            //Console.WriteLine($"Metnin original versiyasi: {textInput}");
            //Console.WriteLine($"Metnin boyudulmus versiyasi: {CustomToUpper(textInput)}");
            //Console.WriteLine($"Metnin kicildilmis versiyasi: {CustomToLower(textInput)}");
            #endregion

            #region Task 4
            /*--> CustomCleanStr(); Elə bir method yazın ki göndərilən string-in daxilində yer alan ƏLAVƏ simvolları təmizləsin(yəni sadəcə geriyə boşluqlar və sözlər qayıtsın. <--*/

            //Console.Write("Metin daxil edin: ");
            //string textInput = Console.ReadLine();
            //Console.WriteLine($"Metnin original versiyasi: {textInput}");
            //Console.WriteLine($"Metnin temizlenmis versiyasi: {CustomCleanStr(textInput)}");

            #endregion

            #region Additional Task: Trim
            /*--> CustomTrimStr(); Sol ve Sagdaki bosluqlari silmek <--*/

            //Console.Write("Metin daxil edin: ");
            //string textInput = Console.ReadLine();
            //Console.WriteLine($"Temizlenmis metn: |{CustomTrimStr(textInput)}|");
            #endregion
        }

        static int CustomIndexOf(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) return i;
            }
            return -1;
        }

        static string CustomToUpper(string text)
        {
            string upperText = "";
            foreach (char letter in text)
            {
                if (letter >= 97 && letter <= 122)
                    upperText += (char)(letter - 32);
                else
                    upperText += letter;

            }
            return upperText;
        }

        static string CustomToLower(string text)
        {
            string upperText = "";
            foreach (char letter in text)
            {
                if (letter >= 65 && letter <= 90)
                    upperText += (char)(letter + 32);
                else
                    upperText += letter;

            }
            return upperText;
        }
        static string CustomCleanStr(string word)
        {
            string CleanText = string.Empty;
            foreach (char letter in word)
            {
                if ((letter >= 65 && letter < 90) || (letter >=  97 && letter <= 122) || letter == ' ')
                    CleanText += letter;
            }
            return CleanText;

        }
        static string CustomTrimStr(string text)
        {
            string TrimText = string.Empty;
            int leftTrimPoint = 0;
            int rightTrimPoint = 0;
            char letter;
            for (int i = 0; i < text.Length; i++)
            {
                letter = text[i];
                if (letter != ' ')
                {
                    leftTrimPoint = i;
                    break;
                }
            }
            for (int i = text.Length - 1; i >= 0; i--)
            {
                letter = text[i];
                if (letter != ' ')
                {
                    rightTrimPoint = i;
                    break;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (i >= leftTrimPoint && i <= rightTrimPoint) TrimText += text[i];
            }

            return TrimText;
        }
    }
}
