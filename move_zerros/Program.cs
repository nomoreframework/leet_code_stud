/// simple solution for O(N) time and N memory
var MoveZerros = (int [] arr) => {
    int length = arr.Length;
    int [] result = new int[length];
    int zerro_counter = 0;
    for(int i = 0; i < length - 1;i++){
        if(arr[i] != 0)
            result[i - zerro_counter] = arr[i];
        else zerro_counter++;
    }
    for(int i = length - zerro_counter; i < length;i++) result[i] = 0;
    return result;
};

