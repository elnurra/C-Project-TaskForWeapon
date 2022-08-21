using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForPlutonium_239.Models
{
    class Weapon
    {
        private int _magazineCapacity;
        private int _ammoCount;
        private double _bulletsUnloadTime;
        private char _shootingMode;



        public int MagazineCapacity
        {
            get
            {
                return _magazineCapacity;

            }
            set
            {
                if (MagazineCapacity >= 0)
                {
                    _magazineCapacity = value;
                }
            }
        }

        public int AmmoCount
        {
            get
            {
                return _ammoCount;

            }
            set
            {
                if (AmmoCount <= MagazineCapacity && AmmoCount >= 0)
                {
                    _ammoCount = value;

                }
            }
        }

        public double BulletsUnloadTime
        {
            get
            {
                return _bulletsUnloadTime;

            }
            set
            {
                if (BulletsUnloadTime >= 0)
                {
                    _bulletsUnloadTime = value;

                }
            }
        }






        public char ShootingMode
        {
            get
            {
                return _shootingMode;

            }
            set
            {
                if (value == 's' || value == 'S' || value == 'f' || value == 'F')
                {
                    _shootingMode = value;
                }

            }
        }

        public Weapon(int MagazineCapacity, int AmmoCount, double AmmoFullyTime, char ShootingMode)
        {
            this.MagazineCapacity = MagazineCapacity;
            this.AmmoCount = AmmoCount;
            this.BulletsUnloadTime = AmmoFullyTime;
            this.ShootingMode = ShootingMode;
        }



        public void Shoot()
        {



            if (_ammoCount > 0)
            {
                _ammoCount--;

                Console.WriteLine("BAM BAM");
            }
            else
            {

                Console.WriteLine("Need to reload your weapon: ");

            }

        }
        public void Fire()
        {

            double time;
            if (ShootingMode == 's' || ShootingMode == 'S')
            {
                Shoot();
                time = (1 * BulletsUnloadTime / _magazineCapacity);

                Console.WriteLine("Time for unload 1 bullet: " + time);

            }
            else if (ShootingMode == 'f' || ShootingMode == 'F')
            {

                time = ((_ammoCount * BulletsUnloadTime) / _magazineCapacity);
                do
                {
                    if (AmmoCount != 0)
                    {
                        AmmoCount--;
                        Console.WriteLine(AmmoCount);
                        ;
                    }
                    else
                    {
                        Console.WriteLine("Need to reload: ");
                    }

                } while (AmmoCount > 0);

                Console.WriteLine("Time for unload all bullets: " + time + " seconds");
            }

        }

        public int GetRemainBulletCount()
        {
            Console.WriteLine("Remain bullet count: ");
            return (_magazineCapacity - _ammoCount);
        }

        public void Reload()
        {
            Console.WriteLine("Reloading... ");
            AmmoCount = _magazineCapacity;
            Console.WriteLine("Reloaded");
        }

        public void ChangeFireMode()
        {
            if (_shootingMode == 's' || _shootingMode == 'S')
            {
                _shootingMode = 'f';
                _shootingMode = 'F';
            }
            else if (_shootingMode == 'f' || _shootingMode == 'F')
            {
                _shootingMode = 's';
                _shootingMode = 'S';
            }


        }

        public void GetInfo()
        {
            Console.WriteLine($"Current magazine capacity: {MagazineCapacity}" +
                $"\nCurrent bullets count: {AmmoCount}" +
                $"\nCurrent fully time to unload all bullets {BulletsUnloadTime} " +
                $"\nShooting mode (s or S) - Single (f-F) - Fire,automatic: {ShootingMode} ");

        }
    }
}
