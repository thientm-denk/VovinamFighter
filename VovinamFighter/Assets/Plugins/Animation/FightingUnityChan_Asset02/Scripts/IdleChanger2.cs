using UnityEngine;
using System.Collections;

//
// アニメーションチェックスクリプト
// 2014/09/13 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

	public class IdleChanger2 : MonoBehaviour
	{
	
	private Animator anim;						// Animatorへの参照
	private AnimatorStateInfo currentState;		// 現在のステート状態を保存する参照
	private AnimatorStateInfo previousState;	// ひとつ前のステート状態を保存する参照


	// Use this for initialization
	void Start ()
	{
		// 各参照の初期化
		anim = GetComponent<Animator> ();
		currentState = anim.GetCurrentAnimatorStateInfo (0);
		previousState = currentState;
//		animator.SetBool("NowStanding",true); //NowStandingパラメータにtrueをセット
	}


	void OnGUI()
	{
//Right pane
		GUI.Box(new Rect(Screen.width - 220 , 10 ,210 ,400), "Crouch Before play");
		if(GUI.Button(new Rect(Screen.width - 155 , 40 ,80, 20), "toCrouch"))
			anim.SetBool ("NowStanding",false);
		if(GUI.Button(new Rect(Screen.width - 210 , 90, 90, 20), "CrouchGuard"))
			anim.SetBool ("CrouchGuard", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 115 , 90, 20), "ForwardWalk"))
			anim.SetBool ("ForwardWalk", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 140 , 90, 20), "ForwardStep"))
			anim.SetBool ("ForwardStep", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 165 , 90, 20), "BackWalk"))
			anim.SetBool ("BackWalk", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 , 90, 20), "BackStep"))
			anim.SetBool ("BackStep", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 215 , 90, 20), "RightStep"))
			anim.SetBool ("RightStep", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 240 , 90, 20), "LeftStep"))
			anim.SetBool ("LeftStep", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 265 , 90, 20), "Jab"))
			anim.SetBool ("Jab", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 290 , 90, 20), "LowKick"))
			anim.SetBool ("LowKick", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 315 , 90, 20), "Chop"))
			anim.SetBool ("Chop", true);	
		if(GUI.Button(new Rect(Screen.width - 210 , 340 , 90, 20), "SpinKick"))
			anim.SetBool ("SpinKick", true);

		if(GUI.Button(new Rect(Screen.width - 110 , 90 , 90, 20), "TurnJab"))
			anim.SetBool ("TurnJab", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 115 , 90, 20), "TurnUpper"))
			anim.SetBool ("TurnUpper", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 140 , 90, 20), "TurnKick"))
			anim.SetBool ("TurnKick", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 165 , 90, 20), "InvRoll_F"))
			anim.SetBool ("InvRoll_F", true);
		if(GUI.Button(new Rect(Screen.width - 110 , 190 , 90, 20), "InvRoll_B"))
			anim.SetBool ("InvRoll_B", true);
		if(GUI.Button(new Rect(Screen.width - 110 , 215 , 90, 20), "Damage_1"))
			anim.SetBool ("Damage_1", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 240 , 90, 20), "Damage_2"))
			anim.SetBool ("Damage_2", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 265 , 90, 20), "Damage_3"))
			anim.SetBool ("Damage_3", true);	
		if(GUI.Button(new Rect(Screen.width - 110 , 290 , 90, 20), "Damage_4"))
			anim.SetBool ("Damage_4", true);
		if(GUI.Button(new Rect(Screen.width - 110 , 315 , 90, 20), "Damage_5"))
			anim.SetBool ("Damage_5", true);
		if(GUI.Button(new Rect(Screen.width - 110 , 340 , 90, 20), "Damage_6"))
			anim.SetBool ("Damage_6", true);
//Left pane
		GUI.Box(new Rect(Screen.width - 880 , 10 ,160 ,400), "Stand Before play");
		if(GUI.Button(new Rect(Screen.width - 870 , 40 ,80, 20), "toStand"))
			anim.SetBool ("NowStanding",true);
			//			anim.SetBool ("toStand", true);
		if(GUI.Button(new Rect(Screen.width - 870 , 90 ,80, 20), "Combo_01"))
			anim.SetBool ("Combo_01", true);
		if(GUI.Button(new Rect(Screen.width - 870 , 115 ,80, 20), "screwKick"))
			anim.SetBool ("screwKick", true);	
	}
	



}
