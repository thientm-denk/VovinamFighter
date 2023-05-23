
using UnityEngine;
using System.Collections;

//
// ループアニメーションを切り替えるスクリプト（ランダム切り替え付き）Ver.3
// 2014/04/03 N.Kobayashi
// 2015/07/09 Modified M.Onoguchi 

// Require these components when using this script
[RequireComponent(typeof(Animator))]



public class IdleChanger9 : MonoBehaviour
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

	// Update is called once per frame
	void  Update ()
	{
		// ↑キー/スペースが押されたら、ステートを次に送る処理
		if (Input.GetKeyDown ("up") || Input.GetButton ("Jump")) {
			// ブーリアンNextをtrueにする
			anim.SetBool ("Next", true);
		}
		
		// ↓キーが押されたら、ステートを前に戻す処理
				if (Input.GetKeyDown ("down")) {
			// ブーリアンBackをtrueにする
			anim.SetBool ("Back", true);
		}

		// "Next"フラグがtrueの時の処理
		if (anim.GetBool ("Next")) {
			// 現在のステートをチェックし、ステート名が違っていたらブーリアンをfalseに戻す
			currentState = anim.GetCurrentAnimatorStateInfo (0);
			if (previousState.nameHash != currentState.nameHash) {
				anim.SetBool ("Next", false);
				previousState = currentState;				
			}
		}
		
		// "Back"フラグがtrueの時の処理
		if (anim.GetBool ("Back")) {
			// 現在のステートをチェックし、ステート名が違っていたらブーリアンをfalseに戻す
			currentState = anim.GetCurrentAnimatorStateInfo (0);
			if (previousState.nameHash != currentState.nameHash) {
				anim.SetBool ("Back", false);
				previousState = currentState;
			}
		}
	}


	void OnGUI()
	{
				GUI.Box(new Rect(Screen.width - 160 , 70 ,100 ,90), "Change Motion");
				if(GUI.Button(new Rect(Screen.width - 150 , 95 ,80, 20), "Next"))
					anim.SetBool ("Next", true);
				if(GUI.Button(new Rect(Screen.width - 150 , 125 ,80, 20), "Back"))
					anim.SetBool ("Back", true);
	}

	
}

