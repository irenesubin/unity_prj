using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    public int id;
    public string name,title, weapon;
    public float strength;
    public int actor_level = 5;
    // Start is called before the first frame update
    public string Talk()
    {
        return "대화를 걸어옴";
    }
    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        actor_level++;
    }
    
}
