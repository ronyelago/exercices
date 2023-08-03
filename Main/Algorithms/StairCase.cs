using System.Text;

namespace Main.Algorithms;

public class StairCase
{
    
    public void GenerateStair(int n)
    {
        List<string> list = new();
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
            
            Console.WriteLine(builder.ToString());
        }
    }
}
