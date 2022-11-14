using UnityEngine;
using TMPro;

namespace Wx
{
    public class TextWindObs : MonoBehaviour
    {
        public Wind wind;

        TextMeshPro tmp;

        void Start()
        {
            // Add code to obtain reports of state changes.
            wind.ReportWind += ReportWind;
        }

        void ReportWind(float d, float s)
        {
            // Add code to manage reports of state changes.
        }
    }
}