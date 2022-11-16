using UnityEngine;
using TMPro;

namespace Wx
{
    // Put this on the models that will detect clicks that
    // instruct the appropriate Wind object to change between
    // live data from the internet and simulated data.

    public class ButtonWindCtl : MonoBehaviour
    {
        public Wind wind;
        [SerializeField]
        public TextMeshPro textMesh;

        void Start()
        {
            StartCoroutine(wind.SimulateWind());
        }
    
        private void OnMouseDown()
        {
            wind.ChangeState();
            StartCoroutine(wind.SimulateWind());
            StartCoroutine(wind.GetNetworkWind());
        }
    }
}