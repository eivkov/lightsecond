using UnityEngine;
using System.Collections;

public class Device
{

    string label;
    string description;
    int hp;
    int max_hp;
    int energy_usage;
    bool fire;
    MonoBehaviour FireBehaviour;

    public Device(string l, string desc, int m_hp, int en_usage, MonoBehaviour fb)
    {
        label = l; //присваиваем название девайса
        description = desc; //присваеваем описание девайса
        max_hp = m_hp;
        hp = max_hp;
        energy_usage = en_usage;
        FireBehaviour = fb;//Это скрипт/ процедура/метод, кторый что-то реальное выполняет
    }

}

public class Spaceship
{

    public Vector3 position;
    public Vector3 new_position;
    public Quaternion rotation;
    public Quaternion new_rotation;
    GameObject unityShip;
    public int hp;
    int max_hp;
    public ArrayList weapons;//оружие
    public ArrayList sciDevices;//Научные девайсы(для лечения)
    public ArrayList superWeapons;//супероружие
    public ArrayList drives;//Двигатели

    public Spaceship(Vector3 p, Quaternion r, GameObject us, int m_hp)
    {
        position = p;
        new_position = p;
        rotation = r;
        new_rotation = r;
        unityShip = us;
        max_hp = m_hp;
        hp = max_hp;
        weapons = new ArrayList();
        sciDevices = new ArrayList();
        superWeapons = new ArrayList();
        drives = new ArrayList();
    }
}

    public class MainScript : MonoBehaviour {

	

	

	public ArrayList enemy_ships;
    public ArrayList my_ships;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
