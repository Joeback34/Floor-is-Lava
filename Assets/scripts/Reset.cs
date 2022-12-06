using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Vector3 respawnPoint = new Vector3(-22.7469997f, 16.8400002f, 9.25599957f);

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = respawnPoint;

        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        collision.transform.rotation = Quaternion.identity;

        collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        collision.gameObject.GetComponent<Rigidbody>().inertiaTensor = Vector3.one;
    }












}
