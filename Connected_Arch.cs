//  using System; using System.Data;
// using System.Data.SqlClient;

// namespace SystemSpace
// {
//     class Program2{
    
//         // Connected Approach for Database Access in ADO.NET
//         static void Main(string[] args)
//         { 
//             SqlConnection con1 = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
//             con1.Open();
//             SqlCommand cmd = new SqlCommand();

//             string str = "select * from EMPLOYEE_DETAILS";
//             cmd.CommandText = str;
//             cmd.Connection = con1;

//             SqlDataReader dr=  cmd.ExecuteReader();
//             Console.WriteLine("Employee Details...");
//             while(dr.Read())
//             {
//                 int id = Int32.Parse(dr[0].ToString());
//                 string title = dr[1].ToString();
//                 Console.WriteLine($"ID: {id}, NAME: {title}");
//             }
//         }
//     }
// }
// /****************************disconncted***************************/
// using System.Data;
// using System.Data.SqlClient;
// namespace DatabaseExample2
// {
//     class Program3
//     {
//         static void Main(string[] args)
//         {
//             SqlConnection con1 = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
//             con1.Open();
//             SqlDataAdapter da = new SqlDataAdapter("select * from EMPLOYEE_DETAILS",con1);
//             DataSet ds = new DataSet();
//             da.Fill(ds, "EMPLOYEE_DETAILS");
//             foreach(DataRow dr in ds.Tables["EMPLOYEE_DETAILS"].Rows)
//             {
//                 int x = Int32.Parse(dr[0].ToString());
//                 string? title = dr[1].ToString();

//                 Console.WriteLine($"Book ID: {x}, Book Title: {title}");
//             }
//         }
//     }
// }
/********************* Connected *************************************/
// using System.Data.SqlClient;
// namespace DatabaseExample3
// {
//     namespace ConnectedApproach
//     {
//         class Program4
//         {
//             SqlConnection con;
//             SqlCommand cmd;
//             SqlDataReader dr;
//             int n;
//             static void Main(string[] args)
//             {
//                 Program4 ob = new Program4();
//                 int ch;
//                 ob.ShowRecords();
//             }
//             public void ShowRecords()
//             {
//                 con = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
//                 con.Open();
//                 cmd = new SqlCommand("select * from EMPLOYEE_DETAILS");
//                 cmd.Connection = con;
//                 dr = cmd.ExecuteReader();
//                 string str = "";
//                 while (dr.Read())
//                 {
//                     int x = Int32.Parse(dr[0].ToString());
//                     string s1 = dr[1].ToString();
//                     str = "ID: " + x + ", NAME: " + s1;
//                     Console.WriteLine(str);
//                 }
//                 dr.Close();
//                 con.Close();
//             }
//     }
// }
// }
/***********************************connected insert*****************/
// using System.Data.SqlClient;
// namespace DatabaseExample3
// {
//     namespace ConnectedApproach
//     {
//         class Program5
//         {
//             SqlConnection con;
//             SqlCommand cmd;
//             SqlDataReader dr;
//             int n;
//             static void Main(string[] args)
//             {
//                 Program5 ob = new Program5();
//                 int ch;
//                 ob.InsertRecords();
//             }
//             public void InsertRecords()
//             {
//                 con = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
//                 con.Open();
//                 Console.WriteLine("Enter EMPLOYEE ID: ");
//                 int x = Int32.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter EMPLOYEE NAME: ");
//                 string s1 = Console.ReadLine();

//                 string cmdtext = "insert into EMPLOYEE_DETAILS(E_ID,E_NAME) values('" + x + "', '" + s1+"')";
//                 cmd = new SqlCommand(cmdtext);
//                 cmd.Connection = con;

//                 n = cmd.ExecuteNonQuery();
//                 if (n > 0)
//                 {
//                     Console.WriteLine("Record Inserted Successfully!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Record not inserted!");
//                 }

//                 con.Close();
//             }
//     }
// }
// }
/**************************** Stored Procedure ************************/
// using System.Data.SqlClient;
// using System.Data;
// namespace Stored_procedure
// {
//  class Program7
//     {
//         static void Main(string[] args)
//         {
//             string con_str = "Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234";
//                 using (SqlConnection con = new SqlConnection(con_str))
//                 {
//                     SqlCommand cmd = new SqlCommand();
//                     cmd.CommandText = "SelectAllCustomers";
//                     cmd.Connection = con;
//                     cmd.CommandType = CommandType.StoredProcedure;
//                     cmd.Parameters.AddWithValue("@ENAME",Console.ReadLine());
//                     con.Open();
//                     cmd.ExecuteNonQuery();
//                      SqlDataReader dr=cmd.ExecuteReader();
//                      string str = "";
//                 while (dr.Read())
//                 {
//                     int x = Int32.Parse(dr[0].ToString());
//                     string s1 = dr[1].ToString();
//                     str = "ID: " + x + ", NAME: " + s1;
//                     Console.WriteLine(str);
               
//                 }
//                 // dr.Close();
//                 con.Close();
//                 }
//         }
//     }
// }
/***************************/
// using System.Data.SqlClient;
// using System.Data;

// namespace PreparedStatement
// {
//     class Program11111
//     {
//         static void Main(string[] args)
//         {
//             var cs = "Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234";

//             using var con = new SqlConnection(cs);
//             con.Open();

//             var query = "INSERT INTO employee_details(e_id, e_name) VALUES(@id, @name)";
//             using var cmd = new SqlCommand(query, con);

//             cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value=Convert.ToInt32(Console.ReadLine());
//             cmd.Parameters.Add("@name", SqlDbType.VarChar,255).Value=Console.ReadLine();
//             cmd.Prepare();

//             cmd.ExecuteNonQuery();

//             Console.WriteLine("row inserted");
//         }
//     }
// }
/************************ Console *************************************/
// class Sample{
// public static void Main()
// {
//     using (StringWriter stringWriter = new StringWriter())
//     {
//          Console.SetOut(stringWriter);
//          Console.WriteLine("You are travelling north at a speed of 10m/s");
//          string consoleOutput = stringWriter.ToString();
//         //  Console.WriteLine(consoleOutput);
//         //  Console.WriteLine(consoleOutput);
//     }
//     Console.WriteLine(streamWriter);
// }
// }
/**************** Dissconnected Update **************************/

// using System.Data.SqlClient;
// using System.Data;
// namespace UpdateSam
// {
//     class Program999{
//         public static void Main(){
       
//             SqlConnection con = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
//             SqlDataAdapter da=new SqlDataAdapter("select * from EMPLOYEE_DETAILS", con);
//             da.UpdateCommand = new SqlCommand(
//            "UPDATE Employee_details SET E_Name = @y1 " +
//            "WHERE E_ID = @x1", con);
//             Console.WriteLine("Enter EMployee Id in which you want an updated value:");
//             int x1 = Int32.Parse(Console.ReadLine());
//             Console.WriteLine("Enter New Value of employee name: ");
//             string y1 = Console.ReadLine();
                 
//         DataTable dt = new DataTable();
//            da.UpdateCommand.Parameters.Add(
//            "@y1", SqlDbType.NVarChar,40).Value=y1;

//         da.UpdateCommand.Parameters.Add(
//           "@x1", SqlDbType.Int).Value=x1;
//             DataSet ds = new DataSet();
//             da.Fill(ds, "EMPLOYEE_DETAILS");
//             SqlCommandBuilder c = new SqlCommandBuilder(da);
      
//         da.Fill(dt);
//         foreach(DataRow dr in ds.Tables["EMPLOYEE_DETAILS"].Rows){
//             if (x1 == Int32.Parse(dr["e_id"].ToString())){
//                     dr[1]  = y1;
//         }
        

//         da.Update(dt);
//             foreach(DataRow dr1 in ds.Tables["EMPLOYEE_DETAILS"].Rows)
//                 {
//                     int x = Int32.Parse(dr1[0].ToString());
//                     string s1 = dr1[1].ToString();
//                     string str1 = "ID: " + x + ", NAME: " + s1;
//                     Console.WriteLine(str1);
               
//                 }
                
//     }
// }
//     }}
// /**************   disconnected - delete **********************/
// // using System.Data.SqlClient;
// // using System.Data;
// // namespace DeleteNameSapce{
// //     class Program10{
// //         public static void Main(){
        
// //         SqlConnection con = new SqlConnection("Data Source=TGU1SER15;Initial Catalog=Mounika;User Id=sa;Password=Dbase@1234");
// //         SqlDataAdapter da = new SqlDataAdapter("select * from employee_details",con);
// //         DataSet ds= new DataSet();
// //         da.Fill(ds,"EMPLOYEE_DETAILS");
// //         SqlCommandBuilder scb=new SqlCommandBuilder(da);
// //         Console.WriteLine("Enter the employee id to delete");
// //         int x=Int32.Parse(Console.ReadLine());
// //          foreach (DataRow dr in ds.Tables["EMPLOYEE_DETAILS"].Rows)
// //             {
// //                 int x1 = Int32.Parse(dr[0].ToString());
// //                 if (x == x1)
// //                 {
// //                     dr.Delete();
// //                     break;
// //                 }
// //             }
// //             da.Update(ds, "EMPLOYEE_DETAILS");
// //                     foreach(DataRow dr in ds.Tables["EMPLOYEE_DETAILS"].Rows)
// //                                     {
// //                                         int x1 = Int32.Parse(dr[0].ToString());
// //                                         string s1 = dr[1].ToString();
// //                                         string str1 = "ID: " + x1 + ", NAME: " + s1;
// //                                         Console.WriteLine(str1);
                                
// //                                     }
// //         }
// //     }
// // }
// /********************************* disconnect insert *****************************/
//  using System.Data.SqlClient;
//  using System.Data; 
//  namespace DeleteNameSapc {  
//    class Program4   {
//        public static void Main(){
//    Console.WriteLine("Enter the id to be inserted");
//    int id = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter name to be inserted");
//    string name = Console.ReadLine(); 
//    Console.WriteLine("Enter the salary");
//    Double salary = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Enter the department id");
//    int did = Convert.ToInt32(Console.ReadLine());
//    da.InsertCommand = new SqlCommand("INSERT INTO Employee VALUES (@id,@name,@salary,@did)",con);
//    da.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 30).Value =name ;
//    da.InsertCommand.Parameters.Add("@salary", SqlDbType.Float).Value =salary;
//    da.InsertCommand.Parameters.Add("@did", SqlDbType.Int).Value =did;
//    da.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value =id;
//   DataTable dt = ds.Tables["Employee"];
//   DataRow ndr = dt.NewRow();
//   ndr[0] = id;
//   ndr[1] = name;
//   ndr[2] = salary;
//   ndr[3] = did;
//   dt.Rows.Add(ndr);
//   da.Update(dt);
//   Console.WriteLine("After Insert");
//    foreach(DataRow dr in dt.Rows){
//   Console.WriteLine("EID: {0}, Name: {1} , Salary: {2} Deptid: {3}",dr[0],dr[1],dr[2],dr[3]);
//   }
//  }
// }
//  }

