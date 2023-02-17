using System.Text;
var get_int = (char c, out int res) => {
    res = 0;
    for(byte i = 48; i < 58;i++){
         if((byte)c == i) return res; 
         res++;
        }
        throw new Exception($"cannot convert '{c}' to Int32");

};
var parse_int = (string str) =>{
   StringBuilder s_b = new StringBuilder();
   int result = 0;
   int buff = 0;
   foreach(var c in str) if(((byte)c > 47 && (byte)c < 58) || c == '-') s_b.Append(c);
   bool is_positive = s_b[0] != '-';
   int i = is_positive ? 0 : 1;
   for(; i < s_b.Length;i++){
    try{
        result += get_int(s_b[i],out buff) * (int)Math.Pow(10,s_b.Length - (i + 1));
    }
    catch{}
   }
   return is_positive ? result : ~result + 1;
};