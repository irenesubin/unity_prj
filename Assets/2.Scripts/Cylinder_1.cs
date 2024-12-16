using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_1 : MonoBehaviour 
 {
    string title = "전설의";
    string playerName = "나야나";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 30;
    bool isFulllevel = false;
    
    // Start is called before the first frame update
    void Start() //로딩이 되고 1번만 실행
    {
        /*string[] monsters = { "슐라임", "사막뱀", "악마" };
        int[] monsterlevel = new int[3];
        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        bool isiBasCondition = (health <= 50) || (mana <= 20);

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log ("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사의 만렙인가?");
        Debug.Log(isFulllevel);

        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;
        Debug.Log(" 맵에 존재하는 몬스터 레벨 ");
        Debug.Log(monsterlevel[0]);
        Debug.Log(monsterlevel[1]);
        Debug.Log(monsterlevel[2]);

        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log(items[0]);
        Debug.Log(items[1]); 

        Debug.Log(title + " " + playerName);

        int fulllevel = 99;
        isFulllevel = level == fulllevel;
        Debug.Log("용사는 만렙인가요?" + isFulllevel);

        bool isEndTutorial = level < 10;
        Debug.Log("튜토리얼이 끝난 용사인가?" + isEndTutorial); 

        string condition = isiBasCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 어떤가?" + condition);

        if(condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하시오");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋다");
        }
        if(isiBasCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션 30을 사용함");
        }
        else if (isiBasCondition && items[0]=="마나물약30")
            {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용함");
            }

        string monsterAlarm;
        switch (monsters[0])
        {
            case "슐라임":
            case "사막뱀":
                monsterAlarm = "소형 몬스터 출현";
                break;
            case "악마":
                monsterAlarm = "중형 몬스터 출현";
                break;
            case "골램":
                monsterAlarm = "대형 몬스터 출현";
                break;
            default:
                monsterAlarm = "미확인 몬스터 출현";
                break;
        }
        Debug.Log(monsterAlarm);

        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입음" + health);
            else
                Debug.Log("사망함");

            if(health == 10)
            {
                Debug.Log("해독제를 사용함");
                break;
            }
        }

        for(int count =0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료중");
        }
        for(int index = 0;index<monsters.Length;index++)
        {
            Debug.Log("현재 현존하는 몬스터: " + monsters[index]);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("다시 한번 현재 존재하는 몬스터: " + monster);
        }

        int Heal(int currentHealth)
        {
            currentHealth += 10;
            Debug.Log("생명력 받음 " + currentHealth);
            return currentHealth;
        }
        

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("파이터는 " + monsters[index] + "에게" + Battle(monsterlevel[index]));

        }*/
        
        int NowPlayer_actor = 0;
        int NowHealth = 0;
        Actor player_actor = new Actor();
        Monster_shu monster_actor = new Monster_shu();
        Good_actor goodPlayer_actor = new Good_actor();
        player_actor.id = 0;
        player_actor.name = "나법사";
        player_actor.title = "현명한";
        player_actor.strength = 2.4f;
        player_actor.weapon = "나무지팡이";

        Debug.Log(player_actor.Talk());
        Debug.Log(player_actor.HasWeapon());
        player_actor.LevelUp();

        Debug.Log(player_actor.name + "의 레벨은" + player_actor.actor_level + "입니다");
        Debug.Log(monster_actor.move());
        NowHealth = health;
        Debug.Log(NowHealth);

        if (NowHealth == health)
        {
            goodPlayer_actor.LevelDown();
            goodPlayer_actor.LevelDown();
            NowPlayer_actor = player_actor.actor_level;
            Debug.Log("현재의 레벨은" + NowPlayer_actor);

            Debug.Log(goodPlayer_actor.SpeedDown());
            
            health -= goodPlayer_actor.health_down;
            Debug.Log(health);
           
            Debug.Log(player_actor.actor_level);
            Debug.Log(monster_actor.actor_level);
            Debug.Log(goodPlayer_actor.actor_level);
        }
    }
    
    void Heal()
    {
        health += 10;
        Debug.Log("생명력 받음" + health);
    }

    string Battle (int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
        {
            result = "승리";
        }
        else
        {
            result = "패전";
        }
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
