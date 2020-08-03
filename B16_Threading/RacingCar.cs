using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace B16_Threading
{

    public class Car
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("1");
            Car car2 = new Car("2");
            Car car3 = new Car("3");
            Thread thread1 = new Thread(car1.Run);
            Thread thread2 = new Thread(car2.Run);
            Thread thread3 = new Thread(car3.Run);
            thread3.Priority = ThreadPriority.Highest;
            Console.WriteLine("Distance: 100KM");
            thread1.Start();
            thread2.Start();

            thread3.Start();

            Console.ReadLine();
        }
        public static int DISTANCE = 100;
        public static int STEP = 2;
        // Khai báo Tên của xe đua
        private string name;

        public Car(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            // Khởi tạo điểm start(hay km ban đầu)
            int runDistance = 0;
            // Khởi tạo time bắt đầu cuộc đua
            var startTime = DateTime.Now;

            // Kiểm tra chừng nào còn xe chưa kết thúc quãng đường đua thì xe vẫn tiếp tục chạy
            while (runDistance < DISTANCE)
            {
                try
                {
                    // Random Speed KM/H
                    int speed = (new Random()).Next(20);
                    // Calculate traveled distance
                    runDistance += speed;
                    // Build result graphic
                    string log = "|";
                    int percentTravel = (runDistance * 100) / DISTANCE;
                    for (int i = 0; i < DISTANCE; i += STEP)
                    {
                        if (percentTravel >= i + STEP)
                        {
                            log += "=";
                        }
                        else if (percentTravel >= i && percentTravel < i + STEP)
                        {
                            log += "o";
                        }
                        else
                        {
                            log += "-";
                        }
                    }
                    log += "|";
                    Console.WriteLine("Car" + this.name + ": " + log + " " + Math.Min(DISTANCE, runDistance) + "KM");
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine("Car" + this.name + " broken... , Message:" + e.Message);
                    break;
                }
            }
            var endTime = System.DateTime.Now;
            Console.WriteLine("Car" + this.name + " Finish in " + (endTime - startTime) + "s");
        }
    }


}
