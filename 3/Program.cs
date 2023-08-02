var LengthOfLongestSubstring = (string s) => {
    int result = 0;
    switch (s.Length){
        case 1:
            result = 1;
            break;
        case 2:
            result =  s[0] == s[1] ? 1 : 2;
            break;
        default: {
            for(int i = 0; i < s.Length;i++){
                int res = 0;
                int j = i;
                var dict = new Dictionary<char,int>();
                    while(j < s.Length && dict.TryAdd(s[j++],i)) res++;
                if(res > result) result = res;
            }
        }
        break;
    }
    return result;
};
