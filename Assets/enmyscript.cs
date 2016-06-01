using UnityEngine;
using System.Collections;
using System;

public class enemyScript : MonoBehaviour
{
    public int H;
    public int W;
    GameObject cont;
    MainScript ms;
    public int rangemy; // досигаемость оружия игрока
    public int renge; // досигаемость оружия бота
                      // Use this for initialization
    void Start()
    {
        H = Screen.height;
        W = Screen.width;
        cont = GameObject.Find("Controller");
        ms = cont.GetComponent<MainScript>();
    }

    void Update()
    {
        rangemy = 0;
        Spaceship s1 = (Spaceship)ms.my_ships[0];
        float x1 = s1.position.x;
        float y1 = s1.position.y;
        double nr1 = s1.new_rotation.z;
        double r1 = System.Math.Asin(x1 / (x1 * x1) + (y1 * y1));
        Device d11 = (Device)s1.weapons[0];
        int d11_t = d11.d_type;
        Device d12 = (Device)s1.weapons[1];
        int d12_t = d12.d_type;
        Spaceship s2 = (Spaceship)ms.enemy_ships[0];
        float x2 = s2.position.x;
        float y2 = s2.position.y;
        double r2 = s2.rotation.z;
        double nr2 = s2.new_rotation.z;
        Device d21 = (Device)s2.weapons[0];
        int d21_t = d21.d_type;
        Device d22 = (Device)s2.weapons[1];
        int d22_t = d22.d_type;
        if (System.Math.Sin(r2) > System.Math.Sin(r1))
        {
            if (r2 - r1 >= 180)
            {
                nr2 += ((360 - r2) + r1);
            }
            else
            {
                nr2 -= r2 - r1;
            }
        }
        else if (System.Math.Sin(r2) < System.Math.Sin(r1))
        {
            if (r1 - r2 >= 180)
            {
                nr2 -= ((360 - r1) + r2);
                nr2 = 360 - Math.Abs(nr2);
            }
            else
            {
                nr2 += r1 - r2;
            }
        }
        if (x1 > x2)
        {

        }

    }
 }