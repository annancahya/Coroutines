using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram6 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(BossSpawn());

        // Cara lain buat manggil
        //StartCoroutine("BossSpawn");
        //StopCoroutine("BossSpawn");
    }

    IEnumerator BossSpawn()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("The boss is appear");
    }

}
