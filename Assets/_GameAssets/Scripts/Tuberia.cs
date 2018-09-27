using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour {

    [SerializeField]float speed = 3;
    //private Deja_Bird bird;
    private float botLimit = -2.8f;
    private float topLimit = 2.2f;
    

    void Start () {
        //audioSource = GetComponent<AudioSource>();
        float factorPosition = Random.Range(botLimit, topLimit);
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
        if(Deja_Bird.ShowPoints() == 2)
        {
            speed = speed + 0.002f;
        }
        
    }
}
