namespace StringCapitalization
{
   static public class StringExtensions
    {
       public static bool DetermineFirstLetterCapitalization(this string userValue)
       {
           if (string.IsNullOrWhiteSpace(userValue))
               return false;

           userValue = userValue.TrimStart(' ', '\'');
           return char.IsUpper(userValue[0]);
       }

       public static bool DetermineSentenceCapitalization(this string userValue)
        {
            if (string.IsNullOrEmpty(userValue))
            {
                return false;
            }

            char[] wordSeperator = { ' ', ',', '.', ':', '\t' };
            string[] words = userValue.Split(wordSeperator);

            foreach (var word in words)
            {
                if (DetermineFirstLetterCapitalization(word) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}