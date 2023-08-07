using System.Text;

namespace Main.Algorithms;

public class StairCase
{
    
    public List<string> GenerateStair(int n)
    {
        List<string> list = new();
        List<string> stairList = new();
        StringBuilder builder = new();
        
        for (int i = 0; i < n; i++)
        {
            list.Add(" ");
        }
        
        for (int i = list.Count - 1; i >= 0; i--)
        {
            builder.Clear();
            list[i] = "#";
            
            foreach (var item in list)
            {
                builder.Append(item);
            }
            
            stairList.Add((builder.ToString()));
        }

        return stairList;
    }
}
