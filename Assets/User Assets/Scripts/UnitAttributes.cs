using UnityEngine;
using System.Collections;

public class UnitAttributes : FullInspector.BaseBehavior {
	
	public int Experience;
	public string UnitType;
	public PlayerAttribute Strength;
	public PlayerAttribute Agility;
	public PlayerAttribute Health;
	
	public class PlayerAttribute {

		public enum PlayerAttributeName { Strength, Agility, Health };
		public enum PlayerAttributeDevType { Static, Dynamic, NAN };

		public PlayerAttributeName Name;
		public int Value;
		public PlayerAttributeDevType DevType;
		public int DevRate;

		public PlayerAttribute (PlayerAttributeName Name, int Value, PlayerAttributeDevType DevType, int DevRate) {
			this.Name = Name;
			this.Value = Value;
			this.DevType = DevType;
			this.DevRate = DevRate;		
		}
	};

	public void DevelopAttribute(PlayerAttribute attribute) {
		int Cost;
		if (attribute.DevType == PlayerAttribute.PlayerAttributeDevType.Static) {
			Cost = attribute.DevRate;
		} 
		else {
			Cost = attribute.Value * attribute.DevRate;
		} 

		if (Experience < Cost) {
			Debug.Log("Not enough exp.");
		} else {
			attribute.Value ++;
			Experience -= Cost;
		}
	}

	// Use this for initialization
	void Start () {
		if (UnitType == "Player Unit") {
			//Main abilities
			Strength = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Strength, 1, PlayerAttribute.PlayerAttributeDevType.Dynamic, 1);
			Agility = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Agility, 1, PlayerAttribute.PlayerAttributeDevType.Dynamic, 1);
			Health = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Health, 1, PlayerAttribute.PlayerAttributeDevType.Static, 1);

			//Experience
			Experience = 10;

		} else {
			//Main abilities
			Strength = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Strength, Random.Range(1, 4), PlayerAttribute.PlayerAttributeDevType.NAN, 1);
			Agility = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Agility, Random.Range(1, 4), PlayerAttribute.PlayerAttributeDevType.NAN, 1);
			Health = new PlayerAttribute (PlayerAttribute.PlayerAttributeName.Health, Random.Range(2, 7), PlayerAttribute.PlayerAttributeDevType.NAN, 1);
			
			//Experience
			Experience = 0;
		}
	}

	void OnMouseDown() {
		//Set Active Unit
		GameObject.Find("GameMaster").GetComponent<GameMaster>().SelectUnit (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
