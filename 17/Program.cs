using System.Text;

Dictionary<char,string> keyBoard = new(){
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
};
void DFS(List<string> result, StringBuilder buf,int index, int length, string digits){
    if(index == length) result.Add(buf.ToString());
    else{
        var current_str = keyBoard[digits[index]];
        for(int i = 0; i < current_str.Length;i++) 
            DFS(result,new StringBuilder(buf.ToString()).Append(current_str[i]),index + 1,length,digits);
    }
}
var getLetterCombinations = (Action<IEnumerable<string>> act) => {
    _ = act ?? throw new ArgumentNullException($"{nameof(act)}");
    var r = new List<string>();
    act(r);
    return r;
};
IList<string> LetterCombinations(string digits) {
    var res = new List<string>();
    return digits.Length switch
    {
        0 => res,
        1 => keyBoard[digits[0]].Select(ch => ch.ToString()).ToList(),
        >4 => throw new ArgumentException("to long string! length <= 4."),
        _ => getLetterCombinations!((res) => DFS((List<string>)res, new StringBuilder(), 0, digits.Length, digits))
    };
}
