namespace lista02
{
    class Circulo
    {
        private float raio;
        public float Raio
        {
            get{return raio;}
            set{if (value >= 0) raio = value;}
        }

        public Circulo(float raio) => Raio = raio;
        public float Area()
        {
            return (raio * raio) * 3.14f;
        }
    }
}
