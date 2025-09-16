using System;
using System.Collections.Generic;
using System.Data;

namespace TransportManagement
{
    public class DatabaseManager
    {
        private string connectionString = "Server=localhost;Database=transport_management;Uid=root;Pwd=;";

        public DatabaseManager()
        {
            // Конструктор
        }

        public void Dispose()
        {
            // Метод для освобождения ресурсов
        }

        public Dictionary<string, int> GetDashboardStats()
        {
            // Заглушка - возвращаем тестовые данные
            return new Dictionary<string, int>
            {
                ["total_vehicles"] = 4,
                ["active_drivers"] = 3,
                ["active_waybills"] = 2,
                ["vehicles_on_route"] = 1
            };
        }

        public DataTable GetVehicles()
        {
            // Заглушка - создаем тестовые данные
            var table = new DataTable();
            table.Columns.Add("Госномер", typeof(string));
            table.Columns.Add("Марка", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Год", typeof(int));
            table.Columns.Add("Статус", typeof(string));

            table.Rows.Add("А123БВ777", "ГАЗ", "ГАЗель Next", 2022, "работает");
            table.Rows.Add("В456ГД777", "КамАЗ", "5320", 2021, "работает");
            table.Rows.Add("Е789ЖЗ777", "Форд", "Transit", 2023, "работает");
            table.Rows.Add("К012ЛМ777", "ГАЗ", "3307", 2020, "ремонт");

            return table;
        }

        public DataTable GetDrivers()
        {
            var table = new DataTable();
            table.Columns.Add("ФИО", typeof(string));
            table.Columns.Add("Номер ВУ", typeof(string));
            table.Columns.Add("Телефон", typeof(string));
            table.Columns.Add("Статус", typeof(string));

            table.Rows.Add("Иванов Иван Иванович", "7712345678", "+7(495)123-45-67", "работает");
            table.Rows.Add("Петров Петр Петрович", "7787654321", "+7(495)765-43-21", "работает");
            table.Rows.Add("Сидоров Сидор Сидорович", "7798765432", "+7(495)987-65-43", "отпуск");

            return table;
        }

        public DataTable GetActiveWaybills()
        {
            var table = new DataTable();
            table.Columns.Add("Номер ПЛ", typeof(string));
            table.Columns.Add("Автомобиль", typeof(string));
            table.Columns.Add("Водитель", typeof(string));
            table.Columns.Add("Маршрут", typeof(string));
            table.Columns.Add("Время выезда", typeof(DateTime));
            table.Columns.Add("Выдано топлива", typeof(decimal));

            table.Rows.Add("ПЛ-001-170925", "А123БВ777", "Иванов И.И.", "Центр - Север", DateTime.Now.AddHours(-2), 25.0);
            table.Rows.Add("ПЛ-002-170925", "Е789ЖЗ777", "Петров П.П.", "Склад - Магазин №1", DateTime.Now.AddHours(-1), 30.0);

            return table;
        }

        public bool CreateWaybill(string vehicleNumber, string driverName, string route, decimal fuel, int mileage)
        {
            // Заглушка - всегда возвращаем true
            return true;
        }

        public bool CloseWaybill(string waybillNumber, int endMileage)
        {
            // Заглушка - всегда возвращаем true
            return true;
        }
    }
}