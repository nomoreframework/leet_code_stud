using System.Text;
int n = 6;
var result = new char [n];
int diff = 0;
int index = 0;
List<string> par = new List<string>();
Dictionary<string,string> st = new Dictionary<string,string>();
gen_parent(diff,index,n,result);
void gen_parent(int diff,int index,int cou,char[] res){
    if(diff <= cou - index - 2){
        res[index] = '(';
        gen_parent(++diff,++index,cou,res);
    }
    if(diff > 0){
        res[index] = ')';
        gen_parent(--diff,++index,cou,res);
    }
    if(index == cou){
        if(diff == 0){
            par.Add(new String(res));
            st.TryAdd(new String(res),"-");
        }
    }
}