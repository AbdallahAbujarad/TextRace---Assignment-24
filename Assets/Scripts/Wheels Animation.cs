using UnityEngine;
namespace Assignment24
{
    public class WheelsAnimation : MonoBehaviour
    {
        public static RaceState wheelState;

        private void Update() 
        {
            AnimateWheels();
        }

        void AnimateWheels()
        {
            switch (wheelState)
            {
                case RaceState.Start:
                    transform.Rotate(0,-100 * Time.deltaTime,0,Space.Self);
                    break;

                case RaceState.Accelerate:
                    transform.Rotate(0,-500 * Time.deltaTime,0,Space.Self);
                    break;

                case RaceState.Turn:
                    transform.localRotation = Quaternion.Euler(90,45,0);
                    break;
                case RaceState.Crash:
                    transform.localRotation = Quaternion.Euler(90,0,0);
                    break;

                case RaceState.Finish:
                    transform.localRotation = Quaternion.Euler(90,0,0);
                    break;

                default:
                    transform.localRotation = Quaternion.Euler(90,0,0);
                    break;
        }
    }
}
}

