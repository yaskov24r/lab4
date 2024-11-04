using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4_Golotaystrov
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> Equipments = new List<Equipment>
            {
                new Equipment { Id = 1, Name = "Нагрівач", Status = "Активний", Price = 1200 },
                new Equipment { Id = 2, Name = "Труба", Status = "Архівний", Price = 20 },
                new Equipment { Id = 3, Name = "Інфрачервоний датчик", Status = "Активний", Price = 200 },
                new Equipment { Id = 4, Name = "Теплообмінник", Status = "Активний", Price = 800 },
                new Equipment { Id = 5, Name = "Контролер температури", Status = "Архівний", Price = 50 },
                new Equipment { Id = 6, Name = "Термопара", Status = "Активний", Price = 15 },
                new Equipment { Id = 7, Name = "Піч", Status = "Активний", Price = 1500 },
                new Equipment { Id = 8, Name = "Вентилятор", Status = "Архівний", Price = 80 },
                new Equipment { Id = 9, Name = "Тепловий насос", Status = "Активний", Price = 3000 },
                new Equipment { Id = 10, Name = "Датчик тиску", Status = "Активний", Price = 300 },
                new Equipment { Id = 11, Name = "Терморегулятор", Status = "Архівний", Price = 35 },
                new Equipment { Id = 12, Name = "Котел", Status = "Активний", Price = 2500 },
                new Equipment { Id = 13, Name = "Сонячний колектор", Status = "Активний", Price = 1200 },
                new Equipment { Id = 14, Name = "Теплова завіса", Status = "Архівний", Price = 400 },
                new Equipment { Id = 15, Name = "Теплоізоляція", Status = "Активний", Price = 150 },
                new Equipment { Id = 16, Name = "Кондиціонер", Status = "Архівний", Price = 600 },
                new Equipment { Id = 17, Name = "Теплогенератор", Status = "Активний", Price = 5000 },
                new Equipment { Id = 18, Name = "Термопомпа", Status = "Активний", Price = 1200 },
                new Equipment { Id = 19, Name = "Датчик температури", Status = "Активний", Price = 70 },
                new Equipment { Id = 20, Name = "Система вентиляції", Status = "Архівний", Price = 1800 },
                new Equipment { Id = 21, Name = "Електронагрівач", Status = "Активний", Price = 900 },
                new Equipment { Id = 22, Name = "Індукційний котел", Status = "Архівний", Price = 450 },
                new Equipment { Id = 23, Name = "Термостат", Status = "Активний", Price = 50 },
                new Equipment { Id = 24, Name = "Газовий пальник", Status = "Активний", Price = 350 },
                new Equipment { Id = 25, Name = "Тепловий лічильник", Status = "Архівний", Price = 700 },
                new Equipment { Id = 26, Name = "Панель управління", Status = "Активний", Price = 120 },
                new Equipment { Id = 27, Name = "Водонагрівач", Status = "Архівний", Price = 200 },
                new Equipment { Id = 28, Name = "Автоматичний вентиль", Status = "Активний", Price = 500 },
                new Equipment { Id = 29, Name = "Тепловий акумулятор", Status = "Активний", Price = 250 },
                new Equipment { Id = 30, Name = "Сервопривід", Status = "Архівний", Price = 150 }
            };

            // 1. Вибрати всі обладнання зі статусом "Архівний"
            var archivedEquipments = Equipments.Where(e => e.Status == "Архівний").ToList();

            // 2. Знайти обладнання з найбільшою ціною
            var mostExpensiveEquipment = Equipments.OrderByDescending(e => e.Price).FirstOrDefault();

            // 3. Підрахувати загальну кількість обладнання в системі
            var totalEquipmentCount = Equipments.Count();

            // 4. Відсортувати обладнання за ціною у порядку спадання
            var sortedByPriceDescending = Equipments.OrderByDescending(e => e.Price).ToList();

            // 5. Вибрати унікальні статуси обладнання
            var uniqueStatuses = Equipments.Select(e => e.Status).Distinct().ToList();

            // 6. Порахувати кількість обладнання для кожного статусу (Активний, Архівний)
            var equipmentCountByStatus = Equipments.GroupBy(e => e.Status)
                                                   .Select(g => new { Status = g.Key, Count = g.Count() })
                                                   .ToList();

            // 7. Вибрати всі обладнання, назви яких починаються на букву "Т"
            var equipmentStartingWithT = Equipments.Where(e => e.Name.StartsWith("Т")).ToList();

            // 8. Знайти середню ціну всіх обладнання
            var averagePrice = Equipments.Average(e => e.Price);

            // 9. Вибрати всі обладнання, ціна яких нижча за 100
            var equipmentPriceBelow100 = Equipments.Where(e => e.Price < 100).ToList();

            // 10. Порахувати кількість обладнання, ціна яких перевищує 500
            var equipmentCountAbove500 = Equipments.Count(e => e.Price > 500);
        }
    }
}
