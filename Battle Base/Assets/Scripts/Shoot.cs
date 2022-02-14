using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    public GameObject impact;
    public AudioSource pew;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot_Gun();
        }
    }
    void Shoot_Gun()
    {
        muzzleflash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            pew.Play();
            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
