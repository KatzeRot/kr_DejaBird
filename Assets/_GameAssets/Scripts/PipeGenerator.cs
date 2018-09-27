using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    [SerializeField] Transform prefabTuberia;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GeneratePipe", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void GeneratePipe()
    {
        //We generate the tubes
        if(GameConfig.IsPlaying() == true)
            Instantiate(prefabTuberia, transform.position, Quaternion.identity);
      
    }
    //void DeleteTube
}
