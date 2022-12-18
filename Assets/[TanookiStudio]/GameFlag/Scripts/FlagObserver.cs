using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TanookiStudio
{
    public class FlagObserver : MonoBehaviour
    {
        [SerializeField] private GameFlag observedFlag;
        [SerializeField] private float delayToTrigger;
        [SerializeField] private UnityEvent onFlagTrigger;

        private void Start()
        {
            observedFlag.onTrigger.AddListener(TriggerEvent);
        }
        public void TriggerEvent()
        {
            StartCoroutine( ITriggerEvent() );
        }
        private IEnumerator ITriggerEvent()
        {
            yield return new WaitForSeconds(delayToTrigger);

            onFlagTrigger?.Invoke();
        }
    }
}