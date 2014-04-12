using UnityEngine;
using System.Collections;

public class BaseCharSheet : FullInspector.BaseBehavior {

	public GameObject UnitToShow;
	public Texture2D AttackIcon;
	public Texture2D SpellIcon;

	void OnGUI () {

		UnitToShow = GetComponent<GameMaster> ().ActivePlayerUnit;
		UnitAttributes UnitToShowAttributes = UnitToShow.GetComponent<UnitAttributes> ();

		GUI.BeginGroup (new Rect (Screen.width / 2 -300, Screen.height - 220, 600, 200));
		GUI.Box(new Rect(0, 0, 600, 200), "Selected Unit:");

		//Stats
		GUI.Label (new Rect (10, 20, 500, 25), UnitToShow.name);
		GUI.Label (new Rect (10, 45, 500, 25), UnitToShowAttributes.Strength.Name.ToString() + ": " + UnitToShowAttributes.Strength.Value );
		if (GUI.Button (new Rect (100, 45, 20, 20), "+")) {
			UnitToShowAttributes.DevelopAttribute(UnitToShowAttributes.Strength);
		}
		GUI.Label (new Rect (10, 70, 500, 25), UnitToShowAttributes.Agility.Name.ToString() + ": " + UnitToShowAttributes.Agility.Value );
		if (GUI.Button (new Rect (100, 70, 20, 20), "+")) {
			UnitToShowAttributes.DevelopAttribute(UnitToShowAttributes.Agility);
		}
		GUI.Label (new Rect (10, 95, 500, 25), UnitToShowAttributes.Health.Name.ToString() + ": " + UnitToShowAttributes.Health.Value );
		if (GUI.Button (new Rect (100, 95, 20, 20), "+")) {
			UnitToShowAttributes.DevelopAttribute(UnitToShowAttributes.Health);
		}

		if (GUI.Button (new Rect (150, 40, 65, 65), AttackIcon)) {
			//Debug.Log("Phis Attack");
			for (int i = 0; i < 100; i++)
			Debug.Log( UnitToShowAttributes.AttributeCheck(UnitToShowAttributes.Agility));
		}

		if (GUI.Button (new Rect (225, 40, 65, 65), SpellIcon)) {
			Debug.Log("Spell Attack");
		}

		GUI.Label (new Rect (10, 120, 500, 25), "Experience: " + UnitToShowAttributes.Experience );
		GUI.EndGroup();

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
