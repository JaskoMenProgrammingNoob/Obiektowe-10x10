using System.Security.Cryptography.X509Certificates;

class Macierz
{
    int n = 10;
    double suma = 0;
    double[,] tablica;

    public Macierz()
    {
        tablica = new double[n, n];
    }
    
    public void czytaj_dane()
    {
        Random losowa = new Random();
        int randomowa = losowa.Next(0, 10);
        for (int i = 0; i < n; i++)
        {
            /* tablica[i, i] = losowa.Next(0, 10); */
            for(int j = 0; j < n; j++)
            {
                if ( i == j)
                {
                    tablica[i, j] = losowa.Next(0, 10);
                } else
                {
                    tablica[i, j] = 0;
                }

            }
        }
    }
    public void przetworz_dane()
    {
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                suma += tablica[i, j];
            }
        }
        
    }
        public void wyswietl_wynik() {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                
                Console.Write($"{tablica[i, j],4}");
            }
            Console.WriteLine();
            
        }
        Console.Write($"Suma po przekątnej: {suma}");
    }
    static void Main(string[] args)
    {

        Macierz macierz = new Macierz();
        macierz.czytaj_dane();
        macierz.przetworz_dane();
        macierz.wyswietl_wynik();


    }
}
                
                
            
        
        








    
            
            


















