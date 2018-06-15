using Netduino.Foundation.Servos;
using System.Threading;
using N = SecretLabs.NETMF.Hardware.Netduino;

namespace ServoHost
{
    public class Program
    {
        static IServo _servo = null;

        public static void Main()
        {
            _servo = new Servo(N.PWMChannels.PWM_PIN_D9, NamedServoConfigs.Ideal270Servo);

            while (true)
            {
                for (int i = 0; i < 270; i++)
                {
                    _servo.RotateTo(i);
                    Thread.Sleep(50);
                }
            }
        }
    }
}
