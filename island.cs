using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Island
{
    public Island()
    {
        int islandId;
        string islandName;
    }
}

public class homeIsland : Island
{
    public homeIsland()
    {
        int islandId = 1;
        string islandName = "온대섬";
    }

}

public class tropicalIsland : Island
{
    public tropicalIsland()
    {
        int islandId = 2;
        string islandName = "열대섬";
    }

}

public class iceIsland : Island
{
    public iceIsland()
    {
        int islandId = 3;
        string islandName = "얼음섬";
    }

}