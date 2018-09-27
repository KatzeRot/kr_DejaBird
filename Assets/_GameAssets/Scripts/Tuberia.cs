using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour {

    [SerializeField]float speed = 3;

	void Start () {
        float factorPosition = Random.Range(-2, 1);
        this.transform.position = new Vector3(
            transform.position.x,
            transform.position.y + factorPosition,
            transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        if(GameConfig.IsPlaying() == true)
        {
           transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if (this.transform.position.x <= -20)
        {
           DestroyImmediate(this.gameObject);
        }
    }
}
