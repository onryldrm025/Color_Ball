using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    List<Animator> _animators;
    public float arasında=0.15f;
    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(Gelen());
    }

    IEnumerator Gelen()
    {
        while(true)
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger("Gelen");
                yield return new WaitForSeconds(arasında);
            }
        }

    }
}
