// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine(MergeAlternately("abcgfff", "def"));

string MergeAlternately(string word1, string word2)
{
    var sb = new StringBuilder();
    var size = word1.Length < word2.Length ? word1.Length : word2.Length;
    var pos = 0;

    while (pos < size)
    {
        sb.Append(word1[pos]);
        sb.Append(word2[pos]);
        
        pos++;
    }

    _ = pos != word1.Length ? sb.Append(word1.AsSpan(pos)) : sb.Append(word2.AsSpan(pos));
    
    return sb.ToString();
}