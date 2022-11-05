using System;
using System.Collections.Generic;
using TelefonRehberi;

namespace TelefonRehberi
{
    class Program
    {
        static void Main()
        {
            // Varsayılan Numaralar

            List<PersonInformations> personList = new List<PersonInformations>();
            personList.Add(new PersonInformations("Furkan Yılmaz", "05555555551"));
            personList.Add(new PersonInformations("Flip Yazılımcı", "05555555552"));
            personList.Add(new PersonInformations("Flip Yazılımcı", "05555555553"));
            personList.Add(new PersonInformations("Zagor Balaban", "05555555554"));
            personList.Add(new PersonInformations("Zırti Haydar", "05555555555"));


            // Program
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Telefon rehberi uygulamasına hoşgeldiniz! Lütfen yapmak istediğiniz işlemi seçin: ");
                Console.WriteLine("(1) Yeni numara kaydetmek.");
                Console.WriteLine("(2) Varolan numarayı silmek");
                Console.WriteLine("(3) Varolan numarayı güncellemek.");
                Console.WriteLine("(4) Rehberi listelemek.");
                Console.WriteLine("(5) Rehberde arama yapmak.");
                Console.WriteLine("(6) Programdan çıkış yapmak.");

                // Sayının istenilen değer aralığında olduğunun kontrol edilmesi.

                Metods m1 = new();
                string? selection = Console.ReadLine();
                int a = 1;
                bool checkTheValue = false;
                while (a > 0)
                {
                    if (checkTheValue == m1.CheckTheNumber(selection))
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Lütfen sadece 1 ile 6 arasında bir sayı giriniz.");
                        break;
                    }
                    else if ((int.Parse(selection) < 1) || (int.Parse(selection) > 6))
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Lütfen sadece 1 ile 6 arasında bir sayı giriniz.");
                        break;
                    }
                    else
                        a = 0;
                }

                if (selection == "6")
                    break;

                switch (int.Parse(selection))
                {
                    case 1:

                        Console.WriteLine("Lütfen isim ve soyisim giriniz:");
                        string nameSurname = Console.ReadLine();

                        a = 1;
                        while (a > 0)
                        {
                            Console.WriteLine("Lütfen numarayı giriniz:");
                            string number = Console.ReadLine();

                            if (number.Length != 11)
                            {
                                Console.WriteLine("Lütfen 11 haneli bir telefon numarası giriniz.");
                                continue;
                            }
                            personList.Add(new PersonInformations(nameSurname, number));
                            a = 0;
                        }
                        break;

                    case 2:

                        a = 1;
                        while (a > 0)
                        {
                            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ve soyadını giriniz:");
                            string removeName = Console.ReadLine();
                            var item = personList.Find(x => x.NameSurname == removeName);
                            if (item == null)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("* Yeniden denemek için : (2)");
                                int choosedNumber1 = int.Parse(Console.ReadLine());
                                if (choosedNumber1 == 1)
                                    break;
                                else if (choosedNumber1 == 2)
                                    continue;
                            }
                            Console.WriteLine($"{item.NameSurname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                            char choosedChar = char.Parse(Console.ReadLine());
                            if (choosedChar == 'y')
                                personList.Remove(item);
                            else if (choosedChar == 'n')
                                continue;
                            a = 0;
                        }
                        break;

                    case 3:
                        a = 1;
                        while (a > 0)
                        {
                            Console.WriteLine("Lütfen değişiklik yapmak istediğiniz kişinin adını ve soyadını giriniz:");
                            string updateName = Console.ReadLine();
                            var updateItem = personList.Find(x => x.NameSurname == updateName);
                            if (updateItem == null)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                                Console.WriteLine("* Yeniden denemek için: (2)");
                                int choosedNumber2 = int.Parse(Console.ReadLine());
                                if (choosedNumber2 == 1)
                                    break;
                                else if (choosedNumber2 == 2)
                                    continue;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen değiştirmek istediğiniz değeri seçiniz:");
                                Console.WriteLine("* İsim ve soyisim değişikliği için: (1)");
                                Console.WriteLine("* Numara değişikliği için: (2)");
                                int choosedNumber3 = int.Parse(Console.ReadLine());
                                if (choosedNumber3 == 1)
                                {
                                    Console.WriteLine("Yeni ismi giriniz:");
                                    updateItem.NameSurname = Console.ReadLine();
                                }
                                else if (choosedNumber3 == 2)
                                {
                                    Console.WriteLine("Yeni numarayı giriniz:");
                                    updateItem.Number = Console.ReadLine();
                                }
                                Console.WriteLine("Değişiklik başarıyla tamamlandı.");
                            }
                            a = 0;
                        }
                        break;

                    case 4:

                        Console.WriteLine("Telefon Rehberi");
                        Console.WriteLine("********************");

                        foreach (var item in personList)
                        {
                            Console.WriteLine(item.NameSurname);
                            Console.WriteLine(item.Number);
                            Console.WriteLine('-');
                        }
                        break;

                    case 5:

                        Console.WriteLine("Arama yapmak istediğiniz kriteri seçiniz.");
                        Console.WriteLine("*******************************************");
                        Console.WriteLine();
                        Console.WriteLine("İsim ve soyisme göre arama yapmak için: (1)");
                        Console.WriteLine("Numaraya göre arama yapmak için: (2)");
                        int choosedNumber = int.Parse(Console.ReadLine());
                        if (choosedNumber == 1)
                        {
                            Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin isim ve soyismini giriniz: ");
                            string name = Console.ReadLine();
                            var findNames = personList.FindAll(x => x.NameSurname == name);
                            if (findNames != null)
                            {
                                Console.WriteLine("Arama Sonuçlarınız: ");
                                Console.WriteLine("*********************");
                                foreach (var item in findNames)
                                {
                                    Console.WriteLine(item.NameSurname);
                                    Console.WriteLine(item.Number);
                                    Console.WriteLine('-');
                                }
                            }
                            else
                                Console.WriteLine("Aradığınız kriterlerde herhangi bir kişi bulunamadı.");                                                       
                        }

                        else if (choosedNumber == 2)
                        {
                            Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz: ");
                            string number = Console.ReadLine();
                            var findNumbers = personList.FindAll(x => x.Number == number);
                            if (findNumbers != null)
                            {
                                Console.WriteLine("Arama Sonuçlarınız: ");
                                Console.WriteLine("**********************");
                                foreach (var item in findNumbers)
                                {
                                    Console.WriteLine(item.NameSurname);
                                    Console.WriteLine(item.Number);
                                    Console.WriteLine('-');
                                }
                            }
                            else
                                Console.WriteLine("Aradığınız kriterlerde biri bulunamadı.");
                        }
                        break;
                }

                Console.WriteLine("İşleminiz tamamlandı.");
                Console.WriteLine("* Yeni bir işlem yapmak için: (1)");
                Console.WriteLine("* Programdan çıkmak için: (2)");
                int choosedNumber5 = int.Parse(Console.ReadLine());
                if (choosedNumber5 == 1)
                    continue;
                else if (choosedNumber5 == 2)
                    break;
                i = 0;
            }

        }
    }
}

