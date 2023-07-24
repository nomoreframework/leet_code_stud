var IsAnagram = (string s, string t) =>
{
    bool result = true;
    var HashT = new Dictionary<char, int>(s.Length);
    var HashS = new Dictionary<char, int>(s.Length);
    if (s.Length != t.Length) return false;
    for (int i = 0; i < s.Length; i++)
    {
        if (HashT.TryAdd(s[i], 1)) { }
        else HashT[s[i]]++;
        if (HashS.TryAdd(t[i], 1)) { }
        else HashS[t[i]]++;
    }
    foreach(var kvp in HashT){
        if(HashS.TryAdd(kvp.Key,kvp.Value) || kvp.Value != HashS[kvp.Key]) return false;
    }
    return result;
};
Console.WriteLine(IsAnagram("aacc", "cacc"));