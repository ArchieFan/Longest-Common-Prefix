using System.Text;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null) return "";

        List<string> resultlist = new List<string>();

        char[] firstword = strs[0].ToCharArray();
        bool IsExit = false;
        for (int i = 0; i < firstword.Length; i++)
        {
            if (IsExit) break;
            resultlist.Add(firstword[i].ToString());
            for (int j = 1; j < strs.Length; j++)
            {
                char[] secordword = strs[j].ToCharArray();
                if (i + 1 > secordword.Length)
                {
                    resultlist[i] = "";
                    IsExit = true;
                    break;
                }
                if (firstword[i] == secordword[i]) {
                    resultlist[i] = secordword[i].ToString();
                } else {
                    resultlist[i] = "";
                    IsExit = true;
                    break;
                }   
            }
        }
        return String.Join("", resultlist);
    }

    public string LongestCommonPrefix2(string[] strs)
    {
        string output = "";
        for (int i = 1; i <= strs[0].Length; i++)
        {
            string j = strs[0].Substring(0, i);
            bool result = strs.All(x => x.StartsWith(j));
            if (result)
            {
                output = j;
                continue;
            }
            else break;
        }
        return output;
    }


    public string LongestCommonPrefix3(string[] strs)
    {
        if (strs.Length == 0) return "";

        for (var i = 0; i < strs[0].Length; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[0][i] != strs[j][i]) return strs[0].Substring(0, i);
            }
        }

        return strs[0];
    }


    public string LongestCommonPrefix4(string[] strs)
    {
        int curpos = 0;
        int l = strs.Length;
        string res;
        if (l == 0) return "";
        StringBuilder ans = new StringBuilder();
        while (true)
        {
            try
            {
                var curchar = strs[0][curpos];
                for (int i = 0; i < l; i++)
                {
                    if (strs[i][curpos] != curchar)
                    {
                        res = ans.ToString();
                        return res;
                    };
                }
                ans.Append(curchar);
                curpos++;
            }
            catch { break; }
        }
        res = ans.ToString();
        return res;
    }
    static void Main()
    {

        string[] inputarr = { "ab", "a" };
        Solution sol = new Solution();
        string result = sol.LongestCommonPrefix(inputarr);
    }
}