using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class SpawnMorcovki : MonoBehaviour{
    public GameObject morcovka;
    void Start(){
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn (){
        while(!PlayerRabbit.lose){ //пока игрок не проиграл, создаются конфеты  
            Instantiate(morcovka, new Vector2(Random.Range(-3.0f, 3.0f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
