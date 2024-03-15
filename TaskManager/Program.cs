using System.Security.Cryptography.X509Certificates;
using TaskManager;

namespace Warehouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            //a możliwość stworzenia zadania
            //a1 użytkownik będzie poproszony o wpisanie id ,nazwy,opisu,daty wykonania,kategorii oraz skali ważności danego zadania
            //a2 użytkownik zostanie poproszony o potwierdzenie wypisanych przez niego właściwości
            //a3 użytkownik zostanie poinformowany że utworzono zadanie
            //b możliwość usunięcia zadania
            //b1 użytkownik zostanie poproszony o id zadania
            //b2 użytkownik bedzie poproszony o potwierdzenie usunięcia oraz zostanie mu pokazana nazwa zadania
            //b3 użytkownik zostanie poinformowany że zadanie zostało usunięte
            //c możliwość edytacji zadania
            //c1 użytkownik poproszony zostanie o id zadania
            //c2 użytkownikowi zostanie wyświetlona nazwa zadania oraz zostanie on spytany którą właściwość chce zmienić
            //d możliwość wglądu na zadanie
            //d1 użytkownik zostanie poproszony o wpisanie id zadania
            //d2 użytkownikowi zostanie wyświetlone wszystko co w danym zadaniu się znajduje
            //e możliwość wyświetlenia zadań z danej kategorii(Praca,Dom,Hobby) bądź z danego numeru ważności(1,2,3,4,5)
            //e1 użytkownik zostanie spytany którą opcje chcę wybrać (kategorię czy stopień ważności)
            //e2 użytkownikowi zostanie wyświetlone id zadania wraz z jego nazwą
            //f wyjście z porogramu
            //f1 program pożegna użytkownika i się zakończy
            Console.WriteLine("Welcome to the Task Menager app");
            Console.WriteLine("Choose operation which you want to do: ");
            var MainCreate = MenuActionService.get;





            static MenuActionService MainMenuAcctions(MenuActionService actionService)
            {
                actionService.AddNewAction(1, "Add task", "Main");
                actionService.AddNewAction(2, "Delete task", "Main");
                actionService.AddNewAction(3, "Edit task", "Main");
                actionService.AddNewAction(4, "Show task", "Main");
                actionService.AddNewAction(5, "Show tasks by category or degree of severity", "Main");
                actionService.AddNewAction(6, "Leave program", "Main");
                return actionService;
            }
        }
    }
}