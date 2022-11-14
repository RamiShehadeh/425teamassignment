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
            GameObject.transform.rotation = new Vector3(0,0,-direction); 
        }


    }
}