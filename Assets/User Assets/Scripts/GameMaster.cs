﻿using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	// Populate and Unit Management
	public ArrayList PlayerUnits = new ArrayList();
	public ArrayList EnemyUnits = new ArrayList();
	public GameObject User_Unit;
	public GameObject Enemy_Unit;
	public GameObject CloneUnit;

	// Active Units - Targets
	public GameObject ActivePlayerUnit;
	public GameObject ActiveEnemyUnit;

	//Add a Unit to Scene
	public void AddUnit(ArrayList Army) {
		int Slot = Army.Count;
		string Name = "";
		if (Army == PlayerUnits) {
			Name += "Player_"; 
		} else {
			Name += "Enemy_";
		}
		Name += "Unit_"+Slot.ToString();

		//Set location
		Vector3 UnitPos;

		//X location
		if (Army == PlayerUnits) {
			UnitPos.x = 0f;
		} else {
			UnitPos.x = 2.5f;
		}

		//Y location
		UnitPos.y = 0f;

		//Z location
		UnitPos.z = Slot * 0.3f;

		//Capsule Collider position
		Vector3 ColliderPos;
		ColliderPos.x = 0;
		ColliderPos.y = 0.15f;
		ColliderPos.z = 0;
		
		//Instinate Unit
		if (Army == PlayerUnits) {
			CloneUnit = (GameObject) Instantiate(User_Unit, UnitPos, Quaternion.Euler(0, 90, 0)) as GameObject;
			CloneUnit.name = Name;
			CloneUnit.AddComponent("UnitAttributes");
			CloneUnit.GetComponent<UnitAttributes>().UnitType = "Player Unit";
			CapsuleCollider _CCollider = (CapsuleCollider) CloneUnit.gameObject.AddComponent(typeof(CapsuleCollider));
			_CCollider.height = 1.3f;
			_CCollider.radius = 0.12f;
			_CCollider.center = ColliderPos;
			Army.Add (CloneUnit);
		} else {
			CloneUnit = (GameObject) Instantiate(Enemy_Unit, UnitPos, Quaternion.Euler(0, 270, 0)) as GameObject;
			CloneUnit.name = Name;
			CloneUnit.AddComponent("UnitAttributes");
			CloneUnit.GetComponent<UnitAttributes>().UnitType = "Enemy Unit";
			CapsuleCollider _CCollider = (CapsuleCollider) CloneUnit.gameObject.AddComponent(typeof(CapsuleCollider));
			_CCollider.height = 1.3f;
			_CCollider.radius = 0.12f;
			_CCollider.center = ColliderPos;
			Army.Add(CloneUnit);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}