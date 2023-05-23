using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/12/07 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger7 : MonoBehaviour
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
		GUI.Box(new Rect(Screen.width - 220 , 30 ,190 , 400), "");
		if(GUI.Button(new Rect(Screen.width - 210 , 40 ,80, 20), "ArrowRp"))
			anim.SetBool ("ARROW_RP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 65 ,80, 20), "CLST"))
			anim.SetBool ("CLST", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 90 ,80, 20), "CRevUrap"))
			anim.SetBool ("CREV_URAP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 115 ,80, 20), "DLali"))
			anim.SetBool ("D_LALI", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 140 ,80, 20), "DblupDwnP"))
			anim.SetBool ("DBLUP_DWNP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 165 ,80, 20), "Lelbo"))
			anim.SetBool ("LELBO", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 ,80, 20), "Elbo2Rstp"))
			anim.SetBool ("ELBO2RSTP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 215 ,80, 20), "Fdrmst"))
			anim.SetBool ("FDRMST", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 240 ,80, 20), "DduckLup"))
			anim.SetBool ("DDUCK_LUP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 265 ,80, 20), "RHRSTP"))
			anim.SetBool ("HRSTP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 290 ,80, 20), "JpUp"))
			anim.SetBool ("JPUP", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 315 ,80, 20), "KI_P"))
			anim.SetBool ("KI_P", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 340 ,80, 20), "LowShol"))
			anim.SetBool ("LOW_SHOL", true);


		if(GUI.Button(new Rect(Screen.width - 120 , 40 ,80, 20), "LowUrap"))
			anim.SetBool ("LOWURAP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 65 ,80, 20), "LowRP09"))
			anim.SetBool ("LOWRP09", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 90 ,80, 20), "MoroP"))
			anim.SetBool ("MORO_P", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 115 ,80, 20), "R_FKP2"))
			anim.SetBool ("R_FKP2", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 140 ,80, 20), "R_Upper2"))
			anim.SetBool ("R_UPPER2", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 165 ,80, 20), "R_Upper3"))
			anim.SetBool ("R_UPPER3", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 190 ,80, 20), "RevDkup"))
			anim.SetBool ("REV_DKUP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 215 ,80, 20), "RevTaSyUrap"))
			anim.SetBool ("REVTASY_URAP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 240 ,80, 20), "Msho_P"))
			anim.SetBool ("MSHO_P", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 265 ,80, 20), "RollUpr"))
			anim.SetBool ("ROLL_UP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 290 ,80, 20), "RollST"))
			anim.SetBool ("ROLL_ST", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 315 ,80, 20), "SyRevLP"))
			anim.SetBool ("SY_REVLP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 340 ,80, 20), "SyRevUP"))
			anim.SetBool ("SY_REVUP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 365 ,80, 20), "SyTaChop"))
			anim.SetBool ("SYTA_CHOP", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 390 ,80, 20), "WildRP"))
			anim.SetBool ("WILD_RP", true);

	}
}
