using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TanookiStudio
{
    [CreateAssetMenu(menuName = "TanookiStudio/GameFlag")]
    public class GameFlag : ScriptableObject
    {
        public bool value;
        [Space(10)]
        public UnityEvent onTrigger;

        public void TriggerFlag()
        {
            Debug.Log( string.Format("Flag {0} was triggered", name) );
            onTrigger?.Invoke();

            value = true;
        }
        public IEnumerator IWaitFlag()
        {
            value = false;

            while (!value)
                yield return null;
        }
    }
}
