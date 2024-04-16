// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerRabbit : MonoBehaviour{

        public GameObject play;
        public static bool lose = false; 

        void Awake (){ // Вызывается до старта, когда происходит перезапуск игры       
                lose = false; 
        }
        
        void OnTriggerEnter2D(Collider2D other){
            if(other.gameObject.tag == "candy"){ //пригрывает пользователь 
            lose = true; 
            play.SetActive(true); 
            }
        }
}
