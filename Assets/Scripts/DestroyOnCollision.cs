using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool DestroySelf = false;

    [SerializeField]
    bool DestroyOther = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            if (DestroySelf)
                Destroy(this.gameObject);
            if (DestroyOther)
                Destroy(collision.gameObject);

    }
}
