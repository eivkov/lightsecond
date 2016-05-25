using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public class Device {

		string label;
		string description;
		int hp;
		int max_hp;
		int energy_usage;
		bool fire;
		MonoBehaviour FireBehaviour;

		public Device (string l, string desc, int m_hp, int en_usage, MonoBehaviour fb) {
			label = l;
			description = desc;
			max_hp = m_hp;
			hp = max_hp;
			energy_usage = en_usage;
			FireBehaviour = fb;
		}

	}

	public class Spaceship {

		public Vector3 position;
		Vector3 new_position;
		public Quaternion rotation;
		Quaternion new_rotation;
		GameObject unityShip;
		public int hp;
		int max_hp;
		public ArrayList weapons;
		public ArrayList sciDevices;
		public ArrayList superWeapons;
		public ArrayList drives;

		public Spaceship (Vector3 p, Quaternion r, GameObject us, int m_hp) {
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

	ArrayList enemies;
	ArrayList 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
