using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Island
{
    public abstract string islandName;
    public abstract string goods;

}

public class homeIsland : Island
{
    public homeIsland()
    {
        int islandId = 1;
        string islandName = "온대섬";
        string goods = "사과";
        double goodsPrice = 200;
    }

}

public class tropicalIsland : Island
{
    public tropicalIsland()
    {
        int islandId = 2;
        string islandName = "열대섬";
        string goods = "바나나";
        double goodsPrice = 300;

    }

}

public class iceIsland : Island
{
    public iceIsland()
    {
        int islandId = 3;
        string islandName = "얼음섬";
        string goods = "돌얼음";
        double goodsPrice = 400;
    }

}