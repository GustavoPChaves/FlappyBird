using UnityEngine;

namespace Assets.Scripts
{
    public class Column : MonoBehaviour {


        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<BirdController>() != null)
            {
                //If the bird hits the trigger collider in between the columns then
                //tell the game control that the bird scored.
                GameManager.instance.BirdScored();
            }
        }
    }
}
