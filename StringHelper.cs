public static  class StringHelper
    {
       /// <summary>
       /// Removes / \ { } " from string
       /// </summary>
       /// <param name="s"></param>
       /// <returns></returns>
       public static string RemoveExtras(string s)
       {
           StringBuilder sb = new StringBuilder(500);
           foreach(char c in s.ToCharArray())
           {
            if(c == 123  || c == 125 || c == 34 || c == 47 || c == 92)
            {
                

            }
            else
            {
                sb.Append(c);
            }

           }
           return sb.ToString();
        }

    }
