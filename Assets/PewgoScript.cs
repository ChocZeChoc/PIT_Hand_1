using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PewgoScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;

    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable pewpewGrabable = GetComponent<XRGrabInteractable>();
        pewpewGrabable.activated.AddListener(Bang);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bang(ActivateEventArgs arg)
    {
        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = bulletSpawn.transform.position;
        newBullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * speed;

        Destroy(newBullet, 5f);
    }
}
