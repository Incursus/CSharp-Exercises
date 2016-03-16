namespace StringCapitalization
{
   abstract class CapitalizationChecker
    {
       public bool DetermineFirstLetterCapitalization(string userValue)
       {
           return userValue.DetermineFirstLetterCapitalization();
       }

       public bool DetermineSentenceCapitalization(string userValue)
       {
           return userValue.DetermineSentenceCapitalization();
       }
    }
}