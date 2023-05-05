# Piramide
Esercizio piramide

Abbiamo realizza un programma che dato in ingresso il numero dei mattoni, ritorni il numero di piani che si possono costruire e il blocchi rimanenti.
###Numero di piani
Per calcolare il numero di piani ho fatto un while nel quale calcolo quanti mattoni ci sono in un piano, li sottrae al numero totale dei mattoni, aumenta di 1 la varibile che conta i mattoni e se il numero totale dei mattoni è minore o uguale di 0 esce dal ciclo e poi ritorna il numero di piani.  Se il numero di mattoni è uguale a 1 ho ritorna 1 perchè c'è solo un piano. Qui c'è un esempio del codice
```c#
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
```
### Numero di blocchi rimanenti
Per calcolare il numero di Blocchi rimanenti ho fatto un while come quello del numero dei piani e poi ho fatto un if nel quale se il numero di mattoni è minore di 0 gli aggiungo il numero di blocchi dell'ultimo piano e gli ritorno il numero di mattoni, altrimenti gli ritorno 0. Qui c'è  un esempio del codice
```c#
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
```
