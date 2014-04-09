using UnityEngine;
using System.Collections;

public class UnitAttributes : MonoBehaviour {

	public int Strength;
	public int Agility;
	public int Health;
	public int Experience;
	public string UnitType;

	// Use this for initialization
	void Start () {
		if (UnitType == "Player Unit") {
			Strength = Agility = 1;
			Health = 3;
			Experience = 10;
		} else {
			Strength = Random.Range(1, 3);
			Agility = Random.Range(1, 3);
			Health = Random.Range(3, 6);
		}
	}

	void OnMouseDown() {
		//Set Active Unit
		if (this.UnitType == "Player Unit") {
			GameObject.Find("GameMaster").GetComponent<GameMaster>().ActivePlayerUnit = this.gameObject;
			Vector3 ObjPos = this.transform.position;
			GameObject.Find("UserSelector").transform.position = ObjPos;
		} else {
			GameObject.Find("GameMaster").GetComponent<GameMaster>().ActiveEnemyUnit = this.gameObject;
			Vector3 ObjPos = this.transform.position;
			GameObject.Find("EnemySelector").transform.position = ObjPos;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
