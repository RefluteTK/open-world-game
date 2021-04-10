
using UnityEngine;
// The name of the Target can be change
public class Target : MonoBehaviour
{
// can be change
   public float health = 100f;
   public float shield = 100f;
   public void  TakeDamage (float amount)
   
   {

        shield -= amount;
       if (shield <= 0f)
       
       health -= amount;
       if (health <= 0f)
       {
           die();
    
       }
   }
   void die ()
   {
       Destroy(gameObject);
   }
}
