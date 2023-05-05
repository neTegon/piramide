
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {
            int npiani=0;
            int piano;
            int righe=1;
            if (mattoni==1)
            {
                return 1;
            }
            mattoni=mattoni-1;
            while(mattoni>=0)
            {
                righe=righe+2;
                piano=righe*righe;
                mattoni=mattoni-piano;
                npiani++;
            }
            return npiani;
        }
        public static int Rimanenti( int mattoni )
        {
            int npiani=0;
            int piano=0;
            int righe=1;
            if (mattoni==1)
            {
                return 0;
            }
            mattoni=mattoni-1;
            while(mattoni>=0)
            {
                righe=righe+2;
                piano=righe*righe;
                mattoni=mattoni-piano;
                npiani++;
            }
            if(mattoni<0)
            {
                mattoni=mattoni+piano;
                return mattoni;
            }
            return 0;
        }

    }
}