using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/12/07 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger6 : MonoBehaviour
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
		if(GUI.Button(new Rect(Screen.width - 210 , 40 ,80, 20), "AO_OKIFLK"))
			anim.SetBool ("AO_OKIFLK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 65 ,80, 20), "AO_OKIFHK"))
			anim.SetBool ("AO_OKIFHK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 90 ,80, 20), "AO_OKIBK"))
			anim.SetBool ("AO_OKIBK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 115 ,80, 20), "AO_OKIBHK"))
			anim.SetBool ("AO_OKIBHK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 140 ,80, 20), "UOKI_HK00"))
			anim.SetBool ("UOKI_HK00", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 165 ,80, 20), "UTU_OKIFLK"))
			anim.SetBool ("UTU_OKIFLK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 ,80, 20), "UOKI_HK180"))
			anim.SetBool ("UOKI_HK180", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 215 ,80, 20), "UOKI_LK180"))
			anim.SetBool ("UOKI_LK180", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 240 ,80, 20), "REV_HK2"))
			anim.SetBool ("REV_HK2", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 265 ,80, 20), "REV_HARAIK"))
			anim.SetBool ("REV_HARAIK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 290 ,80, 20), "CREV_TOAK"))
			anim.SetBool ("CREV_TOAK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 315 ,80, 20), "CREV_LLK"))
			anim.SetBool ("CREV_LLK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 340 ,80, 20), "REV_LK"))
			anim.SetBool ("REV_LK", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 365 ,80, 20), "JumpKnee"))
			anim.SetBool ("JHiza", true);

		if(GUI.Button(new Rect(Screen.width - 120 , 40 ,80, 20), "JPRMAWAK"))
			anim.SetBool ("JPRMAWAK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 65 ,80, 20), "JPREVHK"))
			anim.SetBool ("JPREVHK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 90 ,80, 20), "JPMK"))
			anim.SetBool ("JPMK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 115 ,80, 20), "JPRLK"))
			anim.SetBool ("JPRLK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 140 ,80, 20), "BACK_SAM"))
			anim.SetBool ("BACK_SAM", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 165 ,80, 20), "RUN_SLA"))
			anim.SetBool ("RUN_SLA", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 190 ,80, 20), "TENK"))
			anim.SetBool ("TENK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 215 ,80, 20), "JAKY_TOE"))
			anim.SetBool ("JAKY_TOE", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 240 ,80, 20), "LK2HK"))
			anim.SetBool ("LK2HK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 265 ,80, 20), "KORON_K"))
			anim.SetBool ("KORON_K", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 290 ,80, 20), "KNEEL_K"))
			anim.SetBool ("KNEEL_K", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 315 ,80, 20), "KENK"))
			anim.SetBool ("KENK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 340 ,80, 20), "DBLSPIN_K"))
			anim.SetBool ("DBLSPIN_K", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 365 ,80, 20), "CRH_POMELK"))
			anim.SetBool ("CRH_POMELK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 390 ,80, 20), "B_DBLK"))
			anim.SetBool ("B_DBLK", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 415 ,80, 20), "ASTK_K"))
			anim.SetBool ("ASTK_K", true);
		if(GUI.Button(new Rect(Screen.width - 120 , 440 ,80, 20), "KAGAMIK"))
			anim.SetBool ("KAGAMIK", true);
	}
}
