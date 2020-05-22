namespace PrimeiroPoo
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public float vida = 100.0f;
        public double dinheiro = 0.987;
        public bool pulando = true;      

        public string Correr(float velocidade)
        {
            return "Batman está correndo e descendo a porrada a "+velocidade+"Km/h";
        }

        public float Atacar(float forca)
        {
            float forcaAtaque = 350;

            if(pulando == false){
                forcaAtaque = forca;
            }

            return forcaAtaque;
        }


    }
}