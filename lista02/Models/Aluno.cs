namespace lista02
{
    class Aluno
    {
        private float nota1;
        public float Nota1
        {
            get {return nota1;}
            set {if (value >= 0) nota1 = value;}
        }
        private float nota2;
        public float Nota2
        {
            get {return nota2;}
            set {if (value >= 0) nota2 = value;}
        }

        public Aluno(float nota1, float nota2)
        {
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public float Media()
        {
            return (nota1 + nota2) / 2;
        }
    }
}
