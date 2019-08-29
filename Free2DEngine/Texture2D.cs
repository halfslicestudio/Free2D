using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Texture2D
{
    public int ID { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Dir { get; set; }

    public Texture2D(string Dir)
    {
        this.Dir = Dir;
    }

}
