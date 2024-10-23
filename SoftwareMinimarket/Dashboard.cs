using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareMinimarket
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : datConexion
    {
        // Campos y Propiedades
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; private set; }
        public decimal TotalRevenue { get; private set; }
        public decimal TotalProfit { get; private set; }

        // Constructor
        public Dashboard()
        {
        }

        //Metodos Privados
        private void GetNumberItems()
        {
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Obtener el número total de clientes
                    command.CommandText = "SELECT COUNT(ClienteID) FROM Cliente";
                    NumCustomers = (int)command.ExecuteScalar();

                    // Obtener el número total de productos
                    command.CommandText = "SELECT COUNT(ProductoID) FROM Producto";
                    NumProducts = (int)command.ExecuteScalar();

                    // Obtener el número total de órdenes en el rango de fechas
                    command.CommandText = @"SELECT COUNT(VentaID) 
                                        FROM Venta 
                                        WHERE Fecha BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;

                    // Obtener los 5 productos más vendidos
                    command.CommandText = @"SELECT TOP 5 P.Descripcion, SUM(DV.Cantidad) AS Cantidad
                                        FROM DetalleVenta DV
                                        INNER JOIN Producto P ON P.ProductoID = DV.ProductoID
                                        INNER JOIN Venta V ON V.VentaID = DV.VentaID
                                        WHERE V.Fecha BETWEEN @fromDate AND @toDate
                                        GROUP BY P.Descripcion
                                        ORDER BY Cantidad DESC";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    // Obtener productos con bajo stock
                    command.CommandText = @"SELECT Descripcion, Cantidad
                                        FROM Producto
                                        WHERE Cantidad <= 50";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT V.Fecha, SUM(V.Total) 
                                    FROM Venta V
                                    WHERE V.Fecha BETWEEN @fromDate AND @toDate
                                    GROUP BY V.Fecha";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;

                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                        );
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m; // 20% de ganancia
                    reader.Close();

                    // Agrupar por horas
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    // Agrupar por días
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    // Agrupar por semanas
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    // Agrupar por meses
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    // Agrupar por años
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Datos actualizados: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Datos no actualizados, misma consulta: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
