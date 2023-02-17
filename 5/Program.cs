    public class worker
    {
        public static string LongestPalindrome(string s) 
        {
            if(s.Length == 1) return s;
            string result = "";
            string buffer;
            int i,j; i = 0;
                do{
                    j = s.Length;
                    while(j > i && (j - i) > result.Length){
                        buffer = s.Substring(i,j - i);
                        result = isPalindrome(buffer) && buffer.Length > result.Length ? buffer : result;
                        j--;
                    }
                    i++;

                }while(i + result.Length <= s.Length);
            return result;
        }  
     private static bool isPalindrome(string substr)
        {
            bool res = false;
            switch(substr.Length){
                case 0: return false;
                case 1: return true;
                case 2: return res = substr[1] == substr[0];
                default:{
                    int i, j; i = 0; j = substr.Length - 1;
                    while(i <= j){
                        res = substr[i] == substr[j];
                        if(!res) return res;
                        i++;j--;
                    }
                }
                break;
            }
            return res;
        }
    }
    
