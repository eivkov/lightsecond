using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {
    GameObject cont;
    MainScript ms;
	// Use this for initialization
	void Start () {
        cont = GameObject.Find("Controller");
        ms = cont.GetComponent<MainScript>();
            }
	
	// Update is called once per frame
	void Update () {
        Spaceship s1 = (Spaceship)ms.my_ships[0];
        float x1 = s1.position.x;
        float y1 = s1.position.y;
        Spaceship s2 = (Spaceship)ms.enemy_ships[0];
        float x2 = s2.position.x;
        float y2 = s2.position.y;
        if (x1 > x2)
        {
            if ((x1 - x2) < 100)
            {
                s2.new_position.x = x2 - 100;
            }
        }
        else if (x2 > x1)
        {
            if ((x2 - x1) < 100)
            {
                s2.new_position.x = x2 + 100;
            }
        }
        if (y1 > y2)
        {
            if ((y1 - y2) < 100)
            {
                s2.new_position.y = y2 - 100;
            }
        }
        else if (y2 > y1)
        {
            if ((y2 - y1) < 100)
            {
                s2.new_position.y = y2 + 100;
            }
        }

    }
}
