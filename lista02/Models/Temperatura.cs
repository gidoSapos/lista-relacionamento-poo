using System;
namespace lista02
{
    class Temperatura
    {
        public float celsius;
        public float fahrenheit;

        public float FahToCel(float fahrenheit)
        {
            return (fahrenheit - 32) * 5f / 9f;
        }
        public float CelToFah(float celsius)
        {
            return (celsius * 9f / 5f) + 32;
        }
    }
}

