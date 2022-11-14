using UnityEngine;

namespace Wx
{
    public class DialWindObs : MonoBehaviour
    {
        public Wind wind;

        Vector3 axle;

        void Start()
        {
            wind.ReportWind += ReportWind;
        }

        void ReportWind(float direction, float speed)
        {
            // Add code to manage reports of state changes.
        }

        
    }
}