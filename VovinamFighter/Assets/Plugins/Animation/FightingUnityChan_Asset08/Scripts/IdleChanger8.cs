using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/11/08 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger8 : MonoBehaviour
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
		GUI.Box(new Rect(Screen.width - 280 , 30 ,120 , 460), "Spine down");
		if(GUI.Button(new Rect(Screen.width - 270 , 60 ,100, 20), "ChangeSpine"))
			anim.SetBool ("ChangeSpineProne", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 100 ,100, 20), "Aoki_00"))
			anim.SetBool ("AOKI_00", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 125 ,100, 20), "Aoki_180"))
			anim.SetBool ("AOKI_180", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 150 ,100, 20), "ADWNF_HS"))
			anim.SetBool ("ADWNF_HS", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 175 ,100, 20), "ADWNH_HS"))
			anim.SetBool ("ADWNH_HS", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 200 ,100, 20), "Ao_Koten"))
			anim.SetBool ("AO_KOTEN", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 225 ,100, 20), "Ao_Koten_R"))
			anim.SetBool ("AO_KOTEN_R", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 250 ,100, 20), "Ao_Zenten"))
			anim.SetBool ("AO_ZENTEN", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 275 ,100, 20), "Ao_Zenten_R"))
			anim.SetBool ("AO_ZENTEN_R", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 300 ,100, 20), "Koro_Oki"))
			anim.SetBool ("KORO_OKI", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 325 ,100, 20), "Ao_LGoro"))
			anim.SetBool ("AO_LGORO", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 350 ,100, 20), "Ao_RGoro"))
			anim.SetBool ("AO_RGORO", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 375 ,100, 20), "Ao_LGoro_dwn"))
			anim.SetBool ("AO_LGORO_dwn", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 400 ,100, 20), "Ao_RGoro_dwn"))
			anim.SetBool ("AO_RGORO_dwn", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 425 ,100, 20), "Ao_LGoro_R"))
			anim.SetBool ("AO_LGORO_R", true);
		if(GUI.Button(new Rect(Screen.width - 270 , 450 ,100, 20), "Ao_RGoro_R"))
			anim.SetBool ("AO_RGORO_R", true);


		GUI.Box(new Rect(Screen.width - 150 , 30 ,120 , 340), "Prone down");
		if(GUI.Button(new Rect(Screen.width - 140 , 60 ,100, 20), "ChangeProne"))
			anim.SetBool ("ChangeSpineProne", false);
		if(GUI.Button(new Rect(Screen.width - 140 , 100 ,100, 20), "Uoki_00"))
			anim.SetBool ("UOKI_00", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 125 ,100, 20), "Uoki_180"))
			anim.SetBool ("UOKI_180", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 150 ,100, 20), "Utsu_Koten"))
			anim.SetBool ("UTSU_KOTEN", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 175 ,100, 20), "Utsu_Koten_R"))
			anim.SetBool ("UTSU_KOTEN_R", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 200 ,100, 20), "Utsu_Zenten"))
			anim.SetBool ("UTSU_ZENTEN", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 225 ,100, 20), "Utsu_Zenten_R"))
			anim.SetBool ("UTSU_ZENTEN_R", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 250 ,100, 20), "Utsu_LGoro"))
			anim.SetBool ("UTSU_LGORO", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 275 ,100, 20), "Utsu_RGoro"))
			anim.SetBool ("UTSU_RGORO", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 300 ,100, 20), "Utsu_LGoro_R"))
			anim.SetBool ("UTSU_LGORO_R", true);
		if(GUI.Button(new Rect(Screen.width - 140 , 325 ,100, 20), "Utsu_RGoro_R"))
			anim.SetBool ("UTSU_RGORO_R", true);

	}




}
