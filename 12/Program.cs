using System.Text;
var get_rank = (int num) => {
    int res = 0;
    while(num / 10 != 0){
        num /= 10; res++;
    }
    return res;
};
var get_10_roman_rank = (int rank)=> {
    char res = '\0';
    switch(rank){
        case 1000: res = 'M';
            break;
        case 100: res = 'C';
            break;
        case 10: res = 'X';
            break;
        case 1: res = 'I';
            break;
            default: throw new Exception($"no mathes found for rank '{rank}'"); 
    }
    return res;
};
var get_5_roman_rank = (int rank)=> {
    char res = '\0';
    switch(rank){
        case 5: res = 'V';
            break;
        case 50: res = 'L';
            break;
        case 500: res = 'D';
            break;
            default: throw new Exception($"no mathes found for rank '{rank}'"); 
    }
    return res;
};
var get_roman_int = (int num) => {
    StringBuilder result = new StringBuilder();
    int _rank = 0;
    int curent_num = 0;
    do{
        _rank = get_rank(num);
        curent_num = num >= 10 ? (int)(num / Math.Pow(10,_rank)) : num;
        switch(curent_num){
            case 4:{
                result.Append(new char[]{get_10_roman_rank((int)Math.Pow(10,_rank)),get_5_roman_rank((int)(5 * Math.Pow(10,_rank)))});
            }break;
            case 9:{
                result.Append(new char[]{get_10_roman_rank((int)Math.Pow(10,_rank)), get_10_roman_rank((int)(10 * Math.Pow(10, _rank)))});
            }break;
            default:{
                if(curent_num <= 3) result.Append(get_10_roman_rank((int)Math.Pow(10,_rank)), curent_num);
                else{result.Append(get_5_roman_rank(5 * (int)Math.Pow(10,_rank)));
                     result.Append(get_10_roman_rank((int)Math.Pow(10, _rank)),curent_num - 5);   
                }
            }break;
        }
        num -= curent_num * (int)Math.Pow(10,_rank);
    }while(_rank != 0);    
    return result.ToString();
};