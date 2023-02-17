
    var get_max_area_points = (int [] arr) => {
        switch(arr.Length){
            case 0 : throw new NullReferenceException($"excepted non empty array");
            case 1 : return arr[0];
            case 2 : return arr[0] > arr[1] ? arr[1] : arr[0];
        }
        int max_area = 0;
        int left_point = 0;
        int right_point = arr.Length - 1;
        while(left_point < right_point){
            int shorter = Math.Min(arr[left_point], arr[right_point]);
            max_area = Math.Max(max_area, shorter * (right_point - left_point));
            if(arr[left_point] < arr[right_point]) left_point++;
            else right_point--;
        }        
        return max_area;
    };    

