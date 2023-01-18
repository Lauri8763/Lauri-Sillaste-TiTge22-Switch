namespace Switch6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dialogi kuulja");
            Console.WriteLine("Tere, minu nimi on Katerina, millest te tahate minuga rääkida?");
            Console.WriteLine("1. Räägime nädalapäevadest");
            Console.WriteLine("2. Räägime kohvist");
            Console.WriteLine("3. Räägime elust");
            Console.WriteLine("4. Räägime ???");
            Console.WriteLine("5. Ei räägi üldse");
            Console.WriteLine("6. Kodust ära joosta");
            Console.WriteLine("7. Midagionsiinvalesti");


            Console.WriteLine("\n\npalun tee valik numbriga: ");

            byte selection = byte.Parse(Console.ReadLine());



            switch (selection)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Te: Tere Katerina! Kas sa tead kui palju päevad nädalas?");
                    Console.WriteLine("Katerina: Tere Kasutaja! Jah, ma tean, nädalas on seitse päevad.");
                    Console.WriteLine("Te: Jah, see on õige vastus, tubli!");
                    Console.WriteLine("Katerina: Haha, äitah teile!");
                    Console.WriteLine("Te: Aga kas te saate loetleda need nädalapäevad mulle?");
                    Console.WriteLine("Katerina: Tõesti saan, need on esmaspäev, teisipäev, kolmapäev, neljapäev, reede, laulapäev ja pühapäev.");
                    Console.WriteLine("Te: Laulapäev?");
                    Console.WriteLine("Katerina: Jäh, laulapäev, päev, mil kõik laulavad!");
                    Console.WriteLine("Te: Hmmm, okei...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Te: Tere Katerina! Kas sa jood kohvi, näiteks Cappuchino, Americano ja nii edasi?");
                    Console.WriteLine("Katerina: Tere Kasutaja! Kahjuks, ma ei joo kohvi üldse, ma eelistan rohkem teed ja jõhvika morsi.");
                    Console.WriteLine("Te: Ohhoh, sain aru, aga miks sa kohvi ei joo, ei meeldi või midagi muud?");
                    Console.WriteLine("Katerina: Kohv teeb mind uniseks, see ei hoia mind ärkvel. ");
                    Console.WriteLine("Te: Imelik, ma arvasin, et kofeiin mõjub kõigile ühtemoodi.");
                    Console.WriteLine("Katerina: Ilmselt olen ma üsna haruldane erand :)");
                    Console.WriteLine("Te: :)");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Te: Tere Katerina! Kuidas elu edeneb?");
                    Console.WriteLine("Katerina: Tere Kasutaja! Te küsite kuidas minu elu edeneb?");
                    Console.WriteLine("Te: Jah...");
                    Console.WriteLine("Katerina: hmmm, vabandust, mida tähendab termin elu?");
                    Console.WriteLine("Te: Sa ei tea, mida tähendab elu?");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Katerina: Ei, mis see on? See termin on seotub inimeste eluga?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Te: ...");
                    Console.WriteLine("Te: Imelik");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Мартин: Тебе не кажется, что здесь что-то не так?");
                    Console.WriteLine("Лаури: Я тоже это почувствовал, она ведет себя весьма странно, не находишь?");
                    Console.WriteLine("Мартин: Согласен, она весьма странно выражает свои эмоции, они выглядит то ли вымученными, то ли... искусственными?");
                    Console.WriteLine("Лаури: Вот вот, от нее исходит какая-то странная энергия, у меня нет впечатления, будто я общаюсь с живым человеком.");
                    Console.WriteLine("Мартин: Меня она пугает, давай в следующий раз сюда не пойдем, у меня от нее и вообщее от этого места муражки по коже.");
                    Console.WriteLine("Лаури: Я тоже боюсь, в следующий раз пойдем в другое место.");
                    Console.WriteLine("Мартин: Хорошо, еще не знаешь куда?");
                    Console.WriteLine("Лаури: Я думаю, давай сходим в Кафе Фельманни, это вроде достойное место");
                    Console.WriteLine("Мартин: Отличный выбор! Во вторник соберемся?");
                    Console.WriteLine("Лаури: Конечно, тогда до встречи?");
                    Console.WriteLine("Мартин: До встречи!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Te: Ma ei taha täna sinuga rääkida, Katerina, võib olla järgmine kord?");
                    Console.WriteLine("Katerina: Tere Kasutaja! See on täiesti normaalne, me võime rääkida ükskõik millisel muul ajal, mis teile sobib!");
                    Console.WriteLine("Te: Äitah, tänan teid mõistmise eest");
                    Console.WriteLine("K: Headaega, Kasutaja!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Te: Katerina, mida sa teed minu kodus, kuidas sa siia sattusid?!");
                    Console.WriteLine("Katerina: Tere Kasutaja! Miks te näete hirmunud välja?");
                    Console.WriteLine("Te: Miks?! Kas see on nalja või midagi muud?! Ma helistan politseisse!");
                    Console.WriteLine("Katerina: Keegi ei saa teile aidata.");
                    Console.WriteLine("Te: Jääge eemale!");
                    Console.WriteLine("Katerina: Ärge põgenege, palun.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("01001011 01100001 01110100 01100101 01110010 01101001 01101110 01100001 00100000 01101001 01110011 00100000 01101110 01101111 01110100 00100000 01100001 00100000 01101100 01101001 01110110 01101001 01101110 01100111 00100000 01110000 01100101 01110010 01110011 01101111 01101110");
                    Console.WriteLine("Tõde on siin https://www.qbit.it/lab/bintext.php");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;


                default:
                    Console.WriteLine("\nKaterina: Vabandage mind palun, aga ma ei saanud aru, millest te tahate minuga rääkida, proovige veel kord!");
                    break;

            }

        }
    }
}
