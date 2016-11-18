using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject upperStage;
	public GameObject enemy;
	//このEnemySpawnerではUpperStageとEnemyを扱います。
	//その為、 publicな変数として用意をしておきます。

	float  upperStageX;
	float  upperStageZ;
	//EnemyはUpperStageオブジェクトの幅の中からランダムで出現させます。
	//そのためにUpperStageオブジェクトの横幅(X)と縦幅(Y)を取得します。
	//それらを入れる為の変数であるupperStageXとupperStageZを定義しています

	void Start () { 
		upperStageX = upperStage.GetComponent<Renderer> ().bounds.size.x;
							  //.GetComponent<Renderer>()で
		                       //UpperStageオブジェクトのRendererコンポーネントを取得しています。

		//Rendererコンポーネント...自身をカメラに描画させる為のコンポーネントで、
		//内部で持っている為Inspectorビュー上には表示されません。

		upperStageZ = upperStage.GetComponent<Renderer> ().bounds.size.z;

//		for (int i = 0; i < 5; i++) {
//			Instantiate (enemy, 
//						 upperStage.transform.position + 
//				         new Vector3(Random.Range(-upperStageX/2, upperStageX/2), 0, Random.Range(-upperStageZ/2, upperStageZ/2)),
//				         Quaternion.identity);
//			//Instantiateはオブジェクトを複製する関数
//			//Instantiate (複製するオブジェクト, 複製する位置, 複製するオブジェクトの回転);
//
//							  //upperStage.transform.position
//							  //UpperStageオブジェクトの現在の位置情報を取得
//
//			//new Vector3(~)
//			//新しくVector3で座標を生成しています。
//			//new Vector3(X座標, Y座標, Z座標);
//
//			//Rnadom.Rangeは第一引数と第二引数の間でランダムな数字を生成します。
//
//
//		}
	}

	void Update () {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("enemy");
										//FindGameObjectsWithTag
										//引数に指定したタグ名に当てはまるオブジェクトを全て取得します。
		//GameObject型の配列enemiesを定義
		//FindGameObjectsWithTag ("enemy");で取得した、enemyタグが付いているオブジェクトを毎フレーム代入しています。

		if (enemies.Length < 5) {
			Instantiate (enemy, upperStage.transform.position + new Vector3 (Random.Range (-upperStageX / 2, upperStageX / 2), 0, 
				Random.Range (-upperStageZ / 2, upperStageZ / 2)), Quaternion.identity);
			//for文の中身と同じ記述
		}
	}
}