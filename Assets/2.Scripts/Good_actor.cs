using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good_actor : Actor
{
    public int health_down = 3;
    // Start is called before the first frame update
    public void LevelDown()
    {
         actor_level--;
    }

    public string SpeedDown()
    {
        return "플레이어의 속도가 감소합니다";
    }
}
