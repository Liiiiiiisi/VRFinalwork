using System.Collections.Generic;
using UnityEngine;

public class Qian : MonoBehaviour
{
    public float movingSpeed = 0.5f;
    public float maxHeight = 1.0f;
    public float minHeight = 0.5f;
    private bool movingUp = true;
    public List<GameObject> QianPrefabs;
    public GameObject contentUI;
   // public float shakeTimer;
   // private Vector3 accelerationDir;
  //  public float shakeDetectionThreshold = 2.0f;
   // public float minShakeInterval = 0.5f;
   // private float timeSinceLastShake = 0.0f;



    // Start is called before the first frame update
    private void Start()
    {
        contentUI = GameObject.FindWithTag("Content");
        Debug.Log("Found");
        contentUI.SetActive(false);
        // accelerationDir = Input.acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        //ShakeDetection();
        float movingDirection = (movingUp ? 1 : -1);
        Vector3 newPosition = new Vector3(transform.position.x,
            transform.position.y + movingSpeed * Time.deltaTime * movingDirection,
            transform.position.z);
        transform.position = newPosition;
        if (transform.position.y >= maxHeight)
        {
            movingUp = false;
        }
        else if (transform.position.y <= minHeight)
        {
            movingUp = true;
        }
    }
    /*void ShakeDetection()
    {
        // ensure the time interval
        if (timeSinceLastShake > minShakeInterval)
        {
            // detect the acceleration
            if (Input.acceleration.magnitude - accelerationDir.magnitude > shakeDetectionThreshold)
            {
                shakeTimer += Time.deltaTime; // shake timer
                timeSinceLastShake = 0.0f; // reset last shake time
            }
            else
            {
                shakeTimer = 0.0f; // if the accleration is not enough to trigger the function, reset the timer
            }

            accelerationDir = Input.acceleration; // update the acceleration direction

            // only if the shake lasts three seconds
            if (shakeTimer >= 3.0f)
            {
                DropRandomPrefab(); // random prefab
                shakeTimer = 0.0f; // reset shake timer
            }

            timeSinceLastShake += Time.deltaTime; // reset the timer
        }*/
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           DropRandomPrefab();
           this.gameObject.SetActive(false);
        }
    }

    public void DropRandomPrefab()
    {
        if (QianPrefabs.Count > 0)
        {
            int index = UnityEngine.Random.Range(0, QianPrefabs.Count);
            GameObject PrefabInstance = Instantiate(QianPrefabs[index], transform.position, Quaternion.identity);
            Rigidbody rb = PrefabInstance.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            BoxCollider collider = PrefabInstance.AddComponent<BoxCollider>();
            collider.isTrigger = true;
            collider.size = new Vector3(1f, 2f, 1f);
        } 
    }
}
