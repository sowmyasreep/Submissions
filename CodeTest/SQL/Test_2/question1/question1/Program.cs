

using System;

using System.Data;

using System.Data.SqlClient;

 

class Program

{

    static void Main()

    {

        string connectionString = "Data Source =ICS-LT-HHK96V3;Initial Catalog = CodeBase_Test;" +

                "Integrated Security=True";



        using (SqlConnection connection = new SqlConnection(connectionString))

        {

            connection.Open();



            Console.Write("Enter employee name: ");

            string empName = Console.ReadLine();



            Console.Write("Enter employee salary: ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal empSalary))

            {

                Console.WriteLine("Invalid salary input.");

                return;

            }



            Console.Write("Enter employee type (F for full-time, P for part-time): ");

            string empType = Console.ReadLine().ToUpper();



            using (SqlCommand command = new SqlCommand("AddEmployee", connection))

            {

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmpName", empName);

                command.Parameters.AddWithValue("@EmpSal", empSalary);

                command.Parameters.AddWithValue("@EmpType", empType);



                int rowsAffected = command.ExecuteNonQuery();



                if (rowsAffected > 0)

                {

                    Console.WriteLine("Employee added successfully.");

                }

                else

                {

                    Console.WriteLine("Employee addition failed.");

                }

            }

        }

    }

}