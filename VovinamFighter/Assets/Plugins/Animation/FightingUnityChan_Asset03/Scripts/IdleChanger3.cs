using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/11/08 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger3 : MonoBehaviour
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
		GUI.Box(new Rect(Screen.width - 220 , 10 ,100 , 240), "Hovering");
		if(GUI.Button(new Rect(Screen.width - 210 , 40 ,80, 20), "Hover"))
			anim.SetBool ("Hover", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 70 ,80, 20), "AirCombo"))
			anim.SetBool ("AirAttack", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 100 ,80, 20), "HandFire"))
			anim.SetBool ("HandFire", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 130 ,80, 20), "Damage1"))
			anim.SetBool ("Damage1", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 160 ,80, 20), "Damage2"))
			anim.SetBool ("Damage2", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 190 ,80, 20), "DmgCover"))
			anim.SetBool ("DmgCover", true);
		if(GUI.Button(new Rect(Screen.width - 210 , 220 ,80, 20), "Guard"))
			anim.SetBool ("Guard", true);

		GUI.Box(new Rect(Screen.width - 110 , 10 ,100 , 180), "Hover to fly");
		if(GUI.Button(new Rect(Screen.width - 100 , 40 ,80, 20), "Fly"))
			anim.SetBool ("Fly", true);
		if(GUI.Button(new Rect(Screen.width - 100 , 70 ,80, 20), "Bullet1"))
			anim.SetBool ("FlyAttack1", true);
		if(GUI.Button(new Rect(Screen.width - 100 , 100 ,80, 20), "Bullet2"))
			anim.SetBool ("FlyAttack2", true);
		if(GUI.Button(new Rect(Screen.width - 100 , 130 ,80, 20), "FlyThrough"))
			anim.SetBool ("FlyThrough", true);


		GUI.Box(new Rect(Screen.width - 110 , 200 ,100 , 100), "Ground");
		if(GUI.Button(new Rect(Screen.width - 100 , 230 ,80, 20), "Landing"))
			anim.SetBool ("Landing", true);
		if(GUI.Button(new Rect(Screen.width - 100 , 260 ,80, 20), "Combo01"))
			anim.SetBool ("GroundAttack", true);
	}




}
