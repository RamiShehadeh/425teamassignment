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
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0,0,-direction)); 
        }


    }
}