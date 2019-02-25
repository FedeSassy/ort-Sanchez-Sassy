using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TP_NT_Taller_Meacanico.Models.Utils
{
    public class FilesHelper
    {
        public static void GenerateCSVFile()
        {
            string csvFile = AppDomain.CurrentDomain.BaseDirectory + "Files\\orders_record.csv";

            if (File.Exists(csvFile))
            {
                File.Delete(csvFile);
            }

            File.Create(csvFile);

            if (File.Exists(csvFile))
            {
                using (StreamWriter writer = new StreamWriter(csvFile))
                {
                    List<Order> orders = new DBWrapper().GetAllOrders();
                    if (orders != null && orders.Count() > 0)
                    {
                        foreach (Order order in orders)
                        {
                            if (order.state == "DONE")
                            {
                                string line = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", order.id, Util.GetSimpleDate(order.date_created), Util.GetSimpleDate(order.date_ended), order.client_id, order.employee_id, order.brand, order.model, order.plate_number, order.description, order.total);
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }
    }
}