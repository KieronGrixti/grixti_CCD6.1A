using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData
{
    private static int score = 0;
    private static int health = 10;

    public static int Score
    { 
        get { return score; }
        set { score = value; }
    }

    public static int Health
    {
        get { return health; }
        set { health = value; }
    }


    private static Vector3 GetTarget()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos = new Vector3(mousepos.x, mousepos.y, 0);
        return mousepos;
    }

    public static Vector3 Target
    { get { return GetTarget(); } }
}
