using ProjectForPlutonium_239.Models;
using System;

namespace ProjectForPlutonium_239
{
    
            


    
        class Program
        {
            static void Main(string[] args)
            {

                try
                {
                    char input;
                    Console.WriteLine("Input your magazine capacity: ");
                    int magazinecapacity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input your ammo count:  ");
                    int ammocount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Write your time fully ");
                    double bulletsUnloadTime = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose shooting mode: (s or S) Single shoot (f or F) Fire,automatic shoot");
                    char shootingmode = char.Parse(Console.ReadLine());

                    if (magazinecapacity >= ammocount)
                    {
                        Weapon weapon = new Weapon(magazinecapacity, ammocount, bulletsUnloadTime, shootingmode);

                        Console.WriteLine($"Choose what u want to do: " +
                            $"\n(1) Shoot: " +
                            $"\n(2) Fire: " +
                            $"\n(3) Get remain bullet count: " +
                            $"\n(4) Reload: " +
                            $"\n(5) Change fire mode: " +
                            $"\n(6) Exit the program:" +
                            $"\n(7) Change options:");
                        do
                        {

                            input = char.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case '0':
                                    weapon.GetInfo();
                                    break;
                                case '1':
                                    weapon.Shoot();
                                    break;
                                case '2':
                                    weapon.Fire();
                                    break;
                                case '3':
                                    Console.WriteLine(weapon.GetRemainBulletCount());
                                    break;
                                case '4':
                                    weapon.Reload();
                                    break;
                                case '5':
                                    Console.WriteLine("Changing fire mode...");
                                    weapon.ChangeFireMode();
                                    Console.WriteLine("Changed fire mode.");
                                    break;
                                case '7':
                                    Console.WriteLine($"What are u want change? " +
                            $"\n (S) Change magazine capacity: " +
                            $"\n (T) Change count of bullets: " +
                            $"\n (D) Reset the time: ");
                                    char change = char.Parse(Console.ReadLine());
                                    switch (change)
                                    {
                                        case 'S':
                                            magazinecapacity = int.Parse(Console.ReadLine());
                                            weapon.MagazineCapacity = magazinecapacity;
                                            Console.WriteLine("Changed magazine capacity.");

                                            break;
                                        case 'T':
                                            ammocount = int.Parse(Console.ReadLine());
                                            if (ammocount <= magazinecapacity)
                                            {
                                                weapon.AmmoCount = ammocount;
                                                Console.WriteLine("Changed current ammo counts");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ammo count can't be more than magazine capacity: " + magazinecapacity);
                                            }

                                            break;
                                        case 'D':
                                            bulletsUnloadTime = int.Parse(Console.ReadLine());
                                            weapon.BulletsUnloadTime = bulletsUnloadTime;
                                            break;
                                        default:
                                            Console.WriteLine("Wrong input!");
                                            break;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Wrong input!");
                                    break;
                            }


                        } while (input != '6');
                    }
                    else
                    {
                        Console.WriteLine("Ammo count can't be more than magazine Capacity! ");
                    }
                }
                catch (Exception exept)
                {

                    Console.WriteLine(exept.Message);
                }







            }
        }
    }


   

