//
// UnityChanFightingAnimations
// 格ゲー風ユニティちゃんアニメーションビューア
// 2014/04/22 N.Kobayashi
//
//

using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Animator))]

public class UnitychanFightingAnimations : MonoBehaviour {

	private Animator anim;
	private string instFlag = "Idle";
	public bool showInstructionWindow = true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.UpArrow))
			SetCommand ("Shoryu");

		else if(Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.DownArrow))
			SetCommand ("Samk");

		else if(Input.GetKeyDown(KeyCode.UpArrow))
			SetCommand ("Forward");

		else if(Input.GetKeyDown(KeyCode.DownArrow))
			SetCommand ("Back");

		else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
			SetCommand ("Turn");

		else if(Input.GetKeyDown(KeyCode.P))
			SetCommand ("Ljab");

		else if(Input.GetKeyDown(KeyCode.K))
			SetCommand ("Rhk");

		else if(Input.GetKeyDown(KeyCode.G))
			SetCommand ("Guard");

		else if(Input.GetKeyDown(KeyCode.J))
			SetCommand ("Jump");
	}

	void LateUpdate(){
		ResetInstFlag();
	}

	void OnGUI()
	{
		if(showInstructionWindow){
			GUI.Box(new Rect(Screen.width -260, 10 ,250 ,220), "Instruction");
			GUI.Label(new Rect(Screen.width -245,30,250,30),"Up/Down Arrow : Go Forward/Go Back");
			GUI.Label(new Rect(Screen.width -245,50,250,30),"Left/Right Arrow : Turn Body");
			GUI.Label(new Rect(Screen.width -245,70,250,30),"P : Punch");
			GUI.Label(new Rect(Screen.width -245,90,250,30),"K : Kick");
			GUI.Label(new Rect(Screen.width -245,110,250,30),"P+Up Arrow : Upper Punch");
			GUI.Label(new Rect(Screen.width -245,130,250,30),"K+Down Arrow : SomerSault Kick");
			GUI.Label(new Rect(Screen.width -245,150,250,30),"G : Guard");
			GUI.Label(new Rect(Screen.width -245,170,250,30),"J : Jump");
			if(GUI.Button (new Rect(Screen.width -245, 200, 110, 20),"Serious Damage"))
				SetCommand ("SeriousDamage");
			if(GUI.Button (new Rect(Screen.width -135, 200, 110, 20),"Normal Damage"))
				SetCommand ("NormalDamage");
		}
	}


	void SetCommand(string commandFlag){
		instFlag = commandFlag;
		anim.SetBool(instFlag, true);
	}

	void ResetInstFlag(){
		if(instFlag != "Idle"){
			anim.SetBool (instFlag, false);
			instFlag = "Idle";
		}
	}
	
}
