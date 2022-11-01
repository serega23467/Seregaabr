using System;

namespace лр_8_1 //Разработать тип Сотрудник в котором содержаться поля: имя; фамилия; отчество; возраст;должность; отдел разработки.Возможные действия совершаемые над сотрудником:Добавить сотрудника; изменить возраст сотрудника; изменить должность сотрудника; изменитьотдел разработки сотрудника.
{
    class Worker
    {
        public string name;
        public string surname;
        public string patronymic;
        public int age;
        public string jobtitle;
        public string developmentdep;

        public void GetInfo()
        {
            Console.WriteLine($" Имя: {name}\n Фамилия: {surname}\n Отчество: {patronymic}\n Возраст: {age}\n Должность: {jobtitle}\n Отдел: {developmentdep}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker wrk = new Worker();
            wrk.name = "Sergei";
            wrk.surname = "Abroskin";
            wrk.patronymic = "Alexcandrovich";
            wrk.age = 16;
            wrk.jobtitle = "Cleaner";
            wrk.developmentdep = "Cleaners";
            wrk.GetInfo();
            /*Разработать тип Отдел разработки в котором содержаться поля: название отдела; управляющий 
            отделом(выбирается из сотрудников), кол - во сотрудников.Возможные действия совершаемые над отделом разработки:
            Поменять название отдела; поменять управляющего отделом; поменять кол-во сотрудников*/
            Development_department dep = new Development_department();
            dep.department_name = "departament";
            dep.department_manager = "Abroskin";
            dep.worker_number = 120;
            dep.GetInfo();
        }
    }
    class Development_department
    {
        public string department_name;
        public string department_manager;
        public int worker_number;


        public void GetInfo()
        {
            Console.WriteLine($" \n Название отдела: {department_name}\n Глава отдела: {department_manager}\n Количество сотрудников: {worker_number}");
        }
    }
}
