using System;

namespace Unit_5_MVC_Countries_Lab
{
    internal class Program
    {
        static void Main()
        {
            CountryController controller = new CountryController();
            controller.WelcomeAction();
        }
    }
}