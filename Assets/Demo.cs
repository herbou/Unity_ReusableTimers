using UnityEngine ;

public class Demo : MonoBehaviour {

   [SerializeField] Timer timer1 ;
   [SerializeField] Timer timer2 ;
   [SerializeField] Timer timer3 ;
   [SerializeField] Timer timer4 ;

   private void Start () {
      timer1
      .SetDuration (6)
      .OnEnd (() => Debug.Log ("Timer 1 ended"))
      .Begin () ;

      timer2
      .SetDuration (10)
      .OnEnd (() => Debug.Log ("Timer 2 ended"))
      .Begin () ;

      timer3
      .SetDuration (15)
      .OnEnd (() => Debug.Log ("Timer 3 ended"))
      .Begin () ;

      timer4
      .SetDuration (25)
      .OnEnd (() => Debug.Log ("Timer 4 ended"))
      .Begin () ;
   }

}
