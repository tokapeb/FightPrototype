using UnityEngine;
using System.Collections;
using MessageController;

public class BaseCharSheet : FullInspector.BaseBehavior {

	public GameObject UnitToShow;
	public GameObject UnitTarget;
	public Texture2D AttackIcon;
	public Texture2D SpellIcon;
	
	void OnGUI () {

		UnitToShow = GetComponent<GameMaster> ().ActivePlayerUnit;
		UnitTarget = GetComponent<GameMaster> ().ActiveEnemyUnit;
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
			Debug.Log( UnitToShowAttributes.AttributeCheck(UnitToShowAttributes.Agility));
			UnitToShow.animation.Play("attack");
		}

		if (GUI.Button (new Rect (225, 40, 65, 65), SpellIcon)) {
			Debug.Log("Spell Attack");
			MessageController.MessageController.BasicMessage("Maki");
			float xpos = UnitTarget.transform.position.x;
			float zpos = UnitTarget.transform.position.z;

			iTween.MoveTo(UnitToShow, iTween.Hash(
				"x",	xpos-0.3f,
				"y",	0f,
				"z",	zpos,
				//"orienttopath",	true,
				//"onstart", WalKanim(),
//				"onstartparams", (string) str,
				//"oncomplete",	MessageController.MessageController.BasicMessage,
				//"oncompleteparams",	"Ended",
				"time",	2f
				)
      		);
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
