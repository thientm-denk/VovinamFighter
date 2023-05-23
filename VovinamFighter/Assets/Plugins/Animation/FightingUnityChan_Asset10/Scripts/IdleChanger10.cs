using UnityEngine;
using System.Collections;

//
// アニメーション簡易プレビュースクリプト
// 2014/11/08 quad arrow
//

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class IdleChanger10 : MonoBehaviour
{

	public Partner partner;

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
		GUI.Box(new Rect(Screen.width - 280 , 30 ,120 , 400), "Front Suprex");

		if(GUI.Button(new Rect(Screen.width - 270 , 60 ,100, 20), "SEOI")) {//{}を足して二行以上実行できるようにする
			anim.SetBool ("SEOI", true);
		    partner.SendMessage("SEOI_Partner",SendMessageOptions.DontRequireReceiver);//パートナー側に増やしたメソッドの名前を指定する
		}

		if (GUI.Button (new Rect (Screen.width - 270, 85, 100, 20), "Brain")) {
			anim.SetBool ("BRAIN", true);
			partner.SendMessage("BRAIN_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 110, 100, 20), "Atemi1")) {
			anim.SetBool ("ATEMI1", true);
			partner.SendMessage("ATEMI1_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 135, 100, 20), "Atemi2")) {
			anim.SetBool ("ATEMI2", true);
			partner.SendMessage("ATEMI2_Partner",SendMessageOptions.DontRequireReceiver);
		}
		
		if (GUI.Button (new Rect (Screen.width - 270, 160, 100, 20), "Atemi3")) {
			anim.SetBool ("ATEMI3", true);
			partner.SendMessage("ATEMI3_Partner",SendMessageOptions.DontRequireReceiver);
		}
		
		if (GUI.Button (new Rect (Screen.width - 270, 185, 100, 20), "FISH")) {
			anim.SetBool ("FISH", true);
			partner.SendMessage("FISH_Partner",SendMessageOptions.DontRequireReceiver);
		}
		
		if (GUI.Button (new Rect (Screen.width - 270, 210, 100, 20), "FLANK")) {
			anim.SetBool ("FLANK", true);
			partner.SendMessage("FLANK_Partner",SendMessageOptions.DontRequireReceiver);
		}
		
		if (GUI.Button (new Rect (Screen.width - 270, 235, 100, 20), "HOLD")) {
			anim.SetBool ("HOLD", true);
			partner.SendMessage("HOLD_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 260, 100, 20), "LALIATO")) {
			anim.SetBool ("LALI", true);
			partner.SendMessage("LALI_Partner",SendMessageOptions.DontRequireReceiver);
		}


		if (GUI.Button (new Rect (Screen.width - 270, 285, 100, 20), "JPBOMB")) {
			anim.SetBool ("JPBOMB", true);
			partner.SendMessage("JPBOMB_Partner",SendMessageOptions.DontRequireReceiver);
		}
		
		if (GUI.Button (new Rect (Screen.width - 270, 310, 100, 20), "DSCREW")) {
			anim.SetBool ("DSCREW", true);
			partner.SendMessage("DSCREW_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 335, 100, 20), "ESCAPE")) {
			anim.SetBool ("ESCAPE", true);
			partner.SendMessage("ESCAPE_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 360, 100, 20), "NECK_BRK")) {
			anim.SetBool ("NECKB", true);
			partner.SendMessage("NECKB_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if (GUI.Button (new Rect (Screen.width - 270, 385, 100, 20), "SIHO")) {
			anim.SetBool ("SIHO", true);
			partner.SendMessage("SIHO_Partner",SendMessageOptions.DontRequireReceiver);
		}




		GUI.Box(new Rect(Screen.width - 150 , 30 ,120 , 160), "Behind suprex");

		if(GUI.Button(new Rect(Screen.width - 140 , 60 ,100, 20), "B_FUSHA")) {
			anim.SetBool ("B_FUSHA", true);
			partner.SendMessage("B_FUSHA_Partner",SendMessageOptions.DontRequireReceiver);
		}

		if(GUI.Button(new Rect(Screen.width - 140 , 85 ,100, 20), "German SPX")) {
			anim.SetBool ("GS", true);
			partner.SendMessage("GS_Partner",SendMessageOptions.DontRequireReceiver);
		}

		GUI.Box(new Rect(Screen.width - 150 , 240 ,120 , 100), "Extra assortment");

		if(GUI.Button(new Rect(Screen.width - 140 , 270 ,100, 20), "GiantSwing")) {
			anim.SetBool ("GSWING", true);
			partner.SendMessage("GSWING_Partner",SendMessageOptions.DontRequireReceiver);
		}

	}




}
