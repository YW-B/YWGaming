using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour

{

        public int health = 3;
        public int lives = 3;

        private float flickertime=0f;
        private float flickerduration = 0.1f;

        public SpriteRenderer sr;

        public bool isimmune= false;
        private float immunityduration = 0f;
        private float immunitytime = 1.5f;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();


        }

       

    


      public  void SpriteFlicker(){
            if (flickertime < flickerduration)
            {
                flickertime = flickertime + Time.deltaTime;

            }

            else if(flickertime >= flickerduration){

                sr.enabled = !(sr.enabled);
                flickertime = 0;
            }
      }


 public void TakeDamage (){

            if(isimmune==false){
                health = health - damage;
                if(health < 0){
                    health == 0;
                }
                if(lives > 0 && health == 0){
                    FindObjectOfType<LevelManager>().RespawnPlayer();
                    health = 3;
                    lives--;
                }
                else if (lives == 0 && health == 0){
                    Debug.log ("Game Over");
                    Destroy(this.gameobject);

                }

                Debug.log("Player health" + health.tostring());
                Debug.log("Player Lives" + Lives.tostring());

            }

            isimmune=true;
            immunitytime=0f;
        }

            



    // Update is called once per frame
   void Update()
{
    if(isImmune == true)
    {
        SpriteFlicker();
        immunityTime = immunityTime + Time.deltaTime;
        if(immunityTime >= immunityDuration)
        {
            isImmune = false;
            sr.enabled = true;
        }
    }
}
}
