using UnityEngine;
using System.Collections;

public class GUIButtons : MonoBehaviour {
	private int MaxGold = 3;
	private int PlayerGold;
	private int EnemyGold;

	// Use this for initialization
	void Start () {
		//Init starting golds.
		PlayerGold = MaxGold;
		EnemyGold = MaxGold;
	}

	// Update is called once per frame
	void Update () {
	
	}

	bool HasGold (int WhosGold) {
		if (WhosGold > 0) {
			return true; } 
		else {
			return false;
		}
	}

	void OnGUI() {
		GUI.contentColor = Color.black;
		GUI.Label(new Rect(170, 10, 20, 20), PlayerGold.ToString());
		GUI.Label(new Rect(Screen.width-20, 10, 20, 20), EnemyGold.ToString());
		GUI.contentColor = Color.white;

		if (GUI.Button (new Rect(10, 10, 150, 20), "Add Player Unit")) {
			if (HasGold(PlayerGold)) {
				GetComponent<GameMaster>().AddUnit(GetComponent<GameMaster>().PlayerUnits);
				PlayerGold--;
			} else {
				Debug.Log("Not enough gold: Player.");
			}
		}

		if (GUI.Button (new Rect(Screen.width-180, 10, 150, 20), "Add Enemy Unit")) {
			if (HasGold(EnemyGold)) {
				GetComponent<GameMaster>().AddUnit(GetComponent<GameMaster>().EnemyUnits);
				EnemyGold--;
			} else {
				Debug.Log("Not enough gold: Enemy.");
			}

		}

		GUI.BeginGroup (new Rect (Screen.width / 2 -300, Screen.height - 220, 600, 200));
		GUI.Box(new Rect(0, 0, 600, 200), "Selected Unit:");
		//Debug.Log (GetComponent<GameMaster> ().ActivePlayerUnit.name);

		//GUI.Label (new Rect (10, 20, 500, 20), ActivePlayerUnit.name);
		GUI.EndGroup();
	}
}
