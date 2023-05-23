using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class Partner : MonoBehaviour {
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
	//やられアクションが増えたらコピペして増やす
	public void SEOI_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		//やられアクションの名前を指定する
		anim.SetBool ("SEOI_Y", true);
	}

	public void BRAIN_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// ブレーンバスター
		anim.SetBool ("BRAIN_Y", true); 
	}

	public void ATEMI1_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// 当身1
		anim.SetBool ("ATEMI1_Y", true); 
	}

	public void ATEMI2_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// 当身2
		anim.SetBool ("ATEMI2_Y", true); 
	}

	public void ATEMI3_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// 当身3
		anim.SetBool ("ATEMI3_Y", true); 
	}

	public void FISH_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// フィッシャーマンズスープレックス
		anim.SetBool ("FISH_Y", true); 
	}

	public void FLANK_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// フランケンシュタイナー
		anim.SetBool ("FLANK_Y", true); 
	}

	public void HOLD_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// つかみホールド
		anim.SetBool ("HOLD_Y", true); 
	}

	public void LALI_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// つかみラリアット
		anim.SetBool ("LALI_Y", true); 
	}

	public void JPBOMB_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// ジャンピングパワーボム
		anim.SetBool ("JPBOMB_Y", true); 
	}

	public void DSCREW_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// ドラゴンシュクリュー
		anim.SetBool ("DSCREW_Y", true); 
	}

	public void ESCAPE_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// 掴みエスケープ
		anim.SetBool ("ESCAPE_Y", true); 
	}

	public void NECKB_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// ネックブリーカー
		anim.SetBool ("NECKB_Y", true); 
	}

	public void SIHO_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// 四方投げ
		anim.SetBool ("SIHO_Y", true); 
	}

	public void B_FUSHA_Partner(){
		transform.rotation = Quaternion.Euler(0, 180, 0);
		// 背面風車
		anim.SetBool ("B_FUSHA_Y", true); 
	}

	public void GS_Partner(){
		transform.rotation = Quaternion.Euler(0, 180, 0);
		// ジャーマンスープレックス
		anim.SetBool ("GS_Y", true); 
	}

	public void GSWING_Partner(){
		transform.rotation = Quaternion.Euler(0, 0, 0);
		// ジャイアントスイング
		anim.SetBool ("GSWING_Y", true); 
	}

}
