using UnityEngine;
using System.Collections;

public abstract class Device
{

    public string label;
    public string description;
    public int hp;
    public int max_hp;
    public int energy_usage;
    public bool is_firing;
    public int d_type;
    public GameObject unityShip;
    public GameObject unityDevice;
    public abstract void Fire();

}

public class Spaceship
{

    public Vector3 position;
    public Vector3 new_position;
    public Quaternion rotation;
    public Quaternion new_rotation;
    public GameObject unityShip;
    public int hp;
    public int max_hp;
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

    public int AddDevice()
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
