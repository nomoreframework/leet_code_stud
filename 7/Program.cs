var get_rank = (int number) => {
    int i  = 0;
    
    do{
        i++;
        number /= 10;
    }while(number / 10 != 0 );
    return i;
};
var get_reversed_number = (int n) => {
    if(n >= 0 && n < 10) return n;
    int rank = get_rank(n);
    double result = 0;
        do{
            result += (n % 10) * Math.Pow(10,rank);
            rank--;
            n /= 10;
        }while(rank >= 0);
    return result > Int32.MaxValue || result < Int32.MinValue ? 0 : (int)result;
}; 
int i = get_reversed_number(1);