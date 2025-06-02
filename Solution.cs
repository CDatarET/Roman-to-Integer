public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);
        int val = 0;
        int prev = 1001;

        for(int i = 0; i < s.Length; i++){
            if(map[s[i]] > prev){
                val = val + map[s[i]];
                val = val - 2*prev;
            }
            else{
                val = val + map[s[i]];
            }
            prev = map[s[i]];
        }
        return(val);
    }
}
