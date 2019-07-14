using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public class Boss {
		public int mp = 53;
		public void Magic() {
			if(mp > 5) {
				this.mp -= 5;
				Debug.Log("魔法攻撃をした。残りmpは" + this.mp );

			} else {
				Debug.Log("MPが足りないため魔法が使えない。");
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		int[] array = {11, 22, 33, 44, 55};
		for(int i = 0; i < array.Length; i++)
			Debug.Log(array[i]);

		for(int p = 4; p >= 0; p--)
			Debug.Log(array[p]);
		
		Boss boss = new Boss ();
		for (int m = 0; m <= 10; m++) {
			boss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
