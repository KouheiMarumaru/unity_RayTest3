using UnityEngine;
using System.Collections;

public class RayController : MonoBehaviour {

	public GameObject bullet;
	public Camera playerCamera;
	public float spead = 20;

	void Update () {
		if (Input.GetMouseButton (0)) {
			GameObject bullet2 =  (GameObject) Instantiate (bullet, playerCamera.transform.position,  Quaternion.identity) ;
			//Instantiateメソッドで先程アタッチしたbulletを複製
			//GameObjectの変数bullet2に代入をするので、
			//Instantiateメソッドの前に(GameObject)を記述して型の変換を行っています。

			//第二引数移行の記述がある場合はキャストする必要がある

			Ray rayOrigin = playerCamera.ScreenPointToRay (Input.mousePosition);
			//ScreenPointToRayで()の中の座標を3Dの中の3次元座標上に変更しています。
			//クリックした場所を示す。そこがrayの飛ぶ場所

			Vector3 direction = rayOrigin.direction; 
			//そのrayの飛ぶ場所に対しての方向性を記述

			bullet2.GetComponent<Rigidbody> ().velocity = direction * spead ;
			//球を発射させる記述（加速の記述）
			//velocityはRigidbodyの記述がないと使えない


		}
	}
}