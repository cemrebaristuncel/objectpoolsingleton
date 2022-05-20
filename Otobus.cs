using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tasarimkaliplari

{
    class Otobus<T> where T : new()
    {
        private static List<T> bosKoltuklar = new List<T>();
        private List<T> doluKoltuklar = new List<T>();

        private int havuzdaKalanlar = 0;

        private static Otobus<T> koltuk = null;


        public static Otobus<T> GetInstance()
        {
            lock (bosKoltuklar)
            {

                if (koltuk == null)
                {
                    koltuk = new Otobus<T>();
                }

                return koltuk;
            }
        }
        public T koltugaOtur()
        {
            lock (bosKoltuklar)
            {
                if (bosKoltuklar.Count != 0 && bosKoltuklar.Count < 10)
                {
                    T item = bosKoltuklar[0];
                    doluKoltuklar.Add(item);
                    bosKoltuklar.RemoveAt(0);
                    havuzdaKalanlar--;
                    return item;
                }

                else
                {
                    T obj = new T();
                    doluKoltuklar.Add(obj);
                    return obj;
                }
            }
        }
        public void koltuktanKalk(T item)
        {
            lock (bosKoltuklar)
            {
                if (havuzdaKalanlar <= 10)
                {
                    bosKoltuklar.Add(item);
                    Console.WriteLine("Bos koltukların sayisi : " + (bosKoltuklar.Count));
                    havuzdaKalanlar++;
                    doluKoltuklar.Remove(item);
                }
            }
        }
    }

    class Yolcular
    {
        static void Main(string[] args)

        {
            Task task1 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                object obj = objPool.koltugaOtur();
                Console.WriteLine("1.Yolcu Koltuga Oturdu");
                Thread.Sleep(17500);
                Console.WriteLine("1.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task2 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(1000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("2.Yolcu Koltuga Oturdu");
                Thread.Sleep(18500);
                Console.WriteLine("2.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task3 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(2000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("3.Yolcu Koltuga Oturdu");
                Thread.Sleep(19500);
                Console.WriteLine("3.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task4 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(3000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("4.Yolcu Koltuga Oturdu");
                Thread.Sleep(20500);
                Console.WriteLine("4.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task5 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(4000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("5.Yolcu Koltuga Oturdu");
                Thread.Sleep(21500);
                Console.WriteLine("5.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task6 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(5000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("6.Yolcu Koltuga Oturdu");
                Thread.Sleep(22500);
                Console.WriteLine("6.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task7 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(6000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("7.Yolcu Koltuga Oturdu");
                Thread.Sleep(23500);
                Console.WriteLine("7.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task8 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(7000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("8.Yolcu Koltuga Oturdu");
                Thread.Sleep(24500);
                Console.WriteLine("8.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task9 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(8000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("9.Yolcu Koltuga Oturdu");
                Thread.Sleep(25500);
                Console.WriteLine("9.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task10 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(9000);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("10.Yolcu Koltuga Oturdu");
                Console.WriteLine("*** BÜTÜN KOLTUKLAR DOLU ***");
                Thread.Sleep(26500);
                Console.WriteLine("10.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);


            });

            Task task11 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(9250);
                Console.WriteLine("11.Yolcu Ayakta Bekliyor");
                Thread.Sleep(6500);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("11.Yolcu Koltuga Oturdu");
                Thread.Sleep(19750);
                Console.WriteLine("11.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task12 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(9500);
                Console.WriteLine("12.Yolcu Ayakta Bekliyor");
                Thread.Sleep(7500);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("12.Yolcu Koltuga Oturdu");
                Thread.Sleep(21000);
                Console.WriteLine("12.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task13 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(9750);
                Console.WriteLine("13.Yolcu Ayakta Bekliyor");
                Thread.Sleep(8500);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("13.Yolcu Koltuga Oturdu");
                Thread.Sleep(22000);
                Console.WriteLine("13.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);

            });

            Task task14 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(10000);
                Console.WriteLine("14.Yolcu Ayakta Bekliyor");
                Thread.Sleep(9500);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("14.Yolcu Koltuga Oturdu");
                Thread.Sleep(23000);
                Console.WriteLine("14.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);


            });

            Task task15 = Task.Run(() =>
            {
                Otobus<object> objPool = Otobus<object>.GetInstance();
                Thread.Sleep(10250);
                Console.WriteLine("15.Yolcu Ayakta Bekliyor");
                Thread.Sleep(10250);
                object obj = objPool.koltugaOtur();
                Console.WriteLine("15.Yolcu Koltuga Oturdu");
                Thread.Sleep(23500);
                Console.WriteLine("15.Yolcu Koltuktan Kalktı");
                objPool.koltuktanKalk(obj);
                Console.WriteLine("*** BÜTÜN KOLTUKLAR BOŞ ***");

            });


            Console.ReadKey();
        }
    }
}
