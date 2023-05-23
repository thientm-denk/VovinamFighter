using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/12/07 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger4 : MonoBehaviour
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
		GUI.Box(new Rect(Screen.width - 220 , 25 ,190 , 430), "");
		if(GUI.Button(new Rect(Screen.width - 210 , 40 ,80, 20), "RHiKick"))
			anim.SetBool ("RHiKick", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 70 ,80, 20), "RMidKick"))
			anim.SetBool ("RMidKick", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 100 ,80, 20), "RLowKick"))
			anim.SetBool ("RLowKick", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 130 ,80, 20), "DropKick"))
			anim.SetBool ("DropKick", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 160 ,80, 20), "ShaoK"))
			anim.SetBool ("ShaoK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 ,80, 20), "R_SYLoK"))
			anim.SetBool ("R_SYLOWK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 220 ,80, 20), "Sy_LoK"))
			anim.SetBool ("SY_LOMAK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 250 ,80, 20), "SyTa_MK"))
			anim.SetBool ("SYTA_MK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 280 ,80, 20), "SyTa_MRK"))
			anim.SetBool ("SYTA_MRK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 310 ,80, 20), "SamK"))
			anim.SetBool ("SAMK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 340 ,80, 20), "AAM"))
			anim.SetBool ("AAM", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 370 ,80, 20), "Senton"))
			anim.SetBool ("SENTON", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 400 ,80, 20), "J_KaniK"))
			anim.SetBool ("J_KANIK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 430 ,80, 20), "RollIn"))
			anim.SetBool ("RollIn", true);

		if(GUI.Button(new Rect(Screen.width - 120 , 40 ,80, 20), "VJK"))
			anim.SetBool ("VJK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 70 ,80, 20), "FJK"))
			anim.SetBool ("FJK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 100 ,80, 20), "BJK"))
			anim.SetBool ("BJK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 130 ,80, 20), "Run_JK"))
			anim.SetBool ("Run_JK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 160 ,80, 20), "Run_Drak"))
			anim.SetBool ("Run_Drak", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 190 ,80, 20), "HMawaK"))
			anim.SetBool ("HMAWAK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 220 ,80, 20), "Rev_HK"))
			anim.SetBool ("Rev_HK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 250 ,80, 20), "Rev_MK"))
			anim.SetBool ("Rev_MK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 280 ,80, 20), "Rev_CHK"))
			anim.SetBool ("Rev_CHARAIK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 310 ,80, 20), "JPHK"))
			anim.SetBool ("JPHK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 340 ,80, 20), "JPLK"))
			anim.SetBool ("JPLK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 370 ,80, 20), "Aoki_LK00"))
			anim.SetBool ("AOKI_LK00", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 400 ,80, 20), "Aoki_MK00"))
			anim.SetBool ("AOKI_MK00", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 430 ,80, 20), "Neryochagi"))
			anim.SetBool ("M_KAKA", true);
	}
}
