using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deja_Bird : MonoBehaviour {

    [SerializeField] float power = 3f;
    [SerializeField] Text puntuation;
    [SerializeField] ParticleSystem prefabBlood;
    [SerializeField] AudioSource explosionSound;
    [SerializeField] AudioSource pointSound;
    [SerializeField] AudioSource jumpSound;
    private static int points = 0;

    private Rigidbody rb;

	void Start () {
        rb = this.GetComponent<Rigidbody>();
        GameConfig.StartGame();
	}
	
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            jumpSound.Play();
            rb.AddForce(Vector3.up * power);
            //rb.AddTorque(Vector3.forward * power);
            //rb.rotation = Quaternion.Euler(0.0f, rb.velocity.z, 0.0f);
            
        }
        //if (this.transform.rotation.x <= -45f)
        //{
        //    transform.rotation = Quaternion.Euler(-30, 0, 0);
        //    rb.freezeRotation = true;
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(prefabBlood, transform.position, Quaternion.identity);
        explosionSound.Play();
        GameConfig.StopGame();
        //DESACTIVA EL RENDERER
        gameObject.SetActive(false);
        Invoke("amocheBird", 2);

    }
    private void OnTriggerEnter(Collider other)
    {
        pointSound.Play();
        UpdateDejaBirdsPoints();
    }
    private void amocheBird()
    {
        //The deja-bird dies like a noob
        Destroy(this.gameObject);
        SceneManager.LoadScene(0);
    }
    private void UpdateDejaBirdsPoints()
    {
        points++;
        puntuation.text = points.ToString();
        //Debug.Log("Puntos: " + points);
    }
    public static int ShowPoints()
    {
        return points;
    }
}
