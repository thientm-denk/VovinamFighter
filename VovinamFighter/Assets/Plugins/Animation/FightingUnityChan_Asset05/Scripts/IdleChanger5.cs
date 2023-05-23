using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/12/07 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger5 : MonoBehaviour
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

	}



	void OnGUI()
	{	
		GUI.Box(new Rect(Screen.width - 220 , 30 ,190 , 440), "");
		if(GUI.Button(new Rect(Screen.width - 210 , 40 ,80, 20), "CMN_LJAB"))
			anim.SetBool ("CMN_LJAB", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 65 ,80, 20), "R_ST"))
			anim.SetBool ("R_ST", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 90 ,80, 20), "ARW_ST"))
			anim.SetBool ("ARW_ST", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 115 ,80, 20), "CATCH"))
			anim.SetBool ("CATCH", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 140 ,80, 20), "CHOPPING"))
			anim.SetBool ("CHOPPING", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 165 ,80, 20), "CUT_ELBO"))
			anim.SetBool ("CUT_ELBO", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 ,80, 20), "DPON"))
			anim.SetBool ("DPON", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 215 ,80, 20), "L_UP"))
			anim.SetBool ("L_UP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 240 ,80, 20), "URAP"))
			anim.SetBool ("URAP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 265 ,80, 20), "ZEN_JPP"))
			anim.SetBool ("ZEN_JPP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 290 ,80, 20), "AIR_LJAB"))
			anim.SetBool ("AIR_LJAB", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 315 ,80, 20), "AIR_STP"))
			anim.SetBool ("AIR_STP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 340 ,80, 20), "AIR_REVSTP"))
			anim.SetBool ("AIR_REVSTP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 365 ,80, 20), "AIR_REVLOWP"))
			anim.SetBool ("AIR_REVLOWP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 390 ,80, 20), "MOROTE"))
			anim.SetBool ("MOROTE", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 415 ,80, 20), "Kabe1_on"))
			anim.SetBool ("KABEDON1", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 440 ,80, 20), "Kabe2_on"))
			anim.SetBool ("KABEDON2", true);

		if(GUI.Button(new Rect(Screen.width - 120 , 40 ,80, 20), "R_FKP"))
			anim.SetBool ("R_FKP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 65 ,80, 20), "R_UPPER"))
			anim.SetBool ("R_UPPER", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 90 ,80, 20), "R_UPPER4"))
			anim.SetBool ("R_UPPER4", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 115 ,80, 20), "REV_RP"))
			anim.SetBool ("REV_RP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 140 ,80, 20), "REV_FBP"))
			anim.SetBool ("REV_FBP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 165 ,80, 20), "REV_LELBO"))
			anim.SetBool ("REV_LELBO", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 190 ,80, 20), "ROLL_LUP"))
			anim.SetBool ("ROLL_LUP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 215 ,80, 20), "RISING_P"))
			anim.SetBool ("RISING_P", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 240 ,80, 20), "RISING_P2"))
			anim.SetBool ("RISING_P2", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 265 ,80, 20), "RISING_P3"))
			anim.SetBool ("RISING_P3", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 290 ,80, 20), "SY_LP"))
			anim.SetBool ("SY_LP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 315 ,80, 20), "SY_REVMP"))
			anim.SetBool ("SY_REVMP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 340 ,80, 20), "SYTA_LUP"))
			anim.SetBool ("SYTA_LUP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 365 ,80, 20), "L_SHO"))
			anim.SetBool ("L_SHO", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 390 ,80, 20), "RUN_SHOL"))
			anim.SetBool ("RUN_SHOL", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 415 ,80, 20), "Kabe1_off"))
			anim.SetBool ("KABEDON1", false);
		if(GUI.Button(new Rect(Screen.width - 120 , 440 ,80, 20), "Kabe2_off"))
			anim.SetBool ("KABEDON2", false);
	}
}
