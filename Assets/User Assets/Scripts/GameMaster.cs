using UnityEngine;
using System.Collections;

public class GameMaster : FullInspector.BaseBehavior {

	// Populate and Unit Management
	public ArrayList PlayerUnits = new ArrayList();
	public ArrayList EnemyUnits = new ArrayList();
	public GameObject User_Unit;
	public GameObject Enemy_Unit;
	public GameObject CloneUnit;
	public GameObject UserSelector;
	public GameObject EnemySelector;
	public GameObject CloneUserSelector;

	// Active Units - Targets
	public GameObject ActivePlayerUnit;
	public GameObject ActiveEnemyUnit;

	//Add a Unit to Scene
	public void AddUnit(ArrayList Army) {
		int Slot = Army.Count;
		string Name = "";
		if (Army == PlayerUnits) {
			Name += "Player_"; 
			if (Slot == 0) {
				Vector3 SelectorPos;
				SelectorPos.x = 0;
				SelectorPos.y = 0.001f;
				SelectorPos.z = 0;
				CloneUserSelector = (GameObject) Instantiate(UserSelector, SelectorPos, Quaternion.Euler(0, 0, 0)) as GameObject;
				CloneUserSelector.name = "UserSelector";
			}
		} else {
			Name += "Enemy_";
			if (Slot == 0) {
				Vector3 SelectorPos;
				SelectorPos.x = 2.5f;
				SelectorPos.y = 0.001f;
				SelectorPos.z = 0;
				CloneUserSelector = (GameObject) Instantiate(EnemySelector, SelectorPos, Quaternion.Euler(0, 0, 0)) as GameObject;
				CloneUserSelector.name = "EnemySelector";
			}
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
			ActivePlayerUnit = CloneUnit;
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
			ActiveEnemyUnit = CloneUnit;
		}
		SelectUnit (CloneUnit);
	}

	// Select Unit
	public void SelectUnit(GameObject selected) {
		if (selected.GetComponent<UnitAttributes> ().UnitType == "Player Unit") {
			ActivePlayerUnit = selected;
			Vector3 ObjPos = selected.transform.position;
			GameObject.Find("UserSelector").transform.position = ObjPos;
		} 
		else {
			ActiveEnemyUnit = selected;
			Vector3 ObjPos = selected.transform.position;
			GameObject.Find("EnemySelector").transform.position = ObjPos;
		}

	}

	// Use this for initialization
	void Start () {
		AddUnit (PlayerUnits);
		AddUnit (EnemyUnits);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
