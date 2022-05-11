using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupCompanyGameComponentsOrganizer
{
    public class ProductionInfo
    {
        public static void Info(Component component)
        {
            string timeInfo = $"{component.CreatingTime.Hours}:{component.CreatingTime.Minutes}";

            string info =
                $" {component.Name.PadRight(20)} will be produced in {timeInfo.PadLeft(4)} by [{component.EmployeeLevel} {component.Profession}]";
            Console.WriteLine(info);
        }
    }
}
