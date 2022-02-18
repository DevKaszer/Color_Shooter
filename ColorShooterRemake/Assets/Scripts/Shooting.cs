using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject PrefabAmmo;
    public Transform Firepoint;
    public float SpeedAmmo = 0.5f;
    private Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        var NewBullet = Instantiate(PrefabAmmo.transform, Firepoint.transform.position, Firepoint.transform.rotation);
        rb = NewBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.right * SpeedAmmo, ForceMode2D.Impulse);
    }

}
