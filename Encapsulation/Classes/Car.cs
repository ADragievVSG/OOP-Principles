namespace Encapsulation.Classes
{
    public class Car
    {
        public string _model;
        private int _speedLimit;
        private bool _engineStarted;
        private int _currentSpeed;

        public Car(string model, int speedLimit)
        {
            _model = model;
            _speedLimit = speedLimit;
            _engineStarted = false;
            _currentSpeed = 0;
        }

        public void Drive(int speed)
        {
            _engineStarted = true;
            SetSpeed(speed);
            Console.WriteLine($"Riding with speed: {_currentSpeed}");
        }

        public void Stop()
        {
            SetSpeed(0);
            _engineStarted = false;
        }

        public string GetCarInformation()
        {
            return $"Car: {_model}; Engine turned on: {_engineStarted}; Current speed: {_currentSpeed}";
        }

        private void SetSpeed(int speed)
        {
            if (speed > _speedLimit)
            {
                throw new InvalidOperationException($"Can't reach speed: {speed}. Max speed limit is {_speedLimit}");
            }
            else
            {
                while (_currentSpeed != speed)
                {
                    Console.WriteLine("Current speed: " + _currentSpeed);
                    if (_currentSpeed < speed)
                    {
                        _currentSpeed++;
                    }
                    else if (_currentSpeed > speed)
                    {
                        _currentSpeed--;
                    }
                    Thread.Sleep(50);
                }
            }
        }

        //public int SpeedLimit
        //{
        //    get
        //    {
        //        return _speedLimit;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            Console.WriteLine($"SpeedLimit must be positive number! Speed Limit remains {_speedLimit}.");
        //        }
        //        else
        //        {
        //            _speedLimit = value;
        //        }
        //    }
        //}


        //public int Get()
        //{
        //    return _speedLimit;
        //}

        //public void Set(int value)
        //{
        //    _speedLimit = value;
        //}
    }
}
