using System;
using System.Windows.Forms;
using MedTrackingGui.Service;

namespace MedTrackingGui {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			DBOperations.Initialize();

//			Console.WriteLine(PatientService.GetIdByFullName("Katherine Young")); // 2
//			Console.WriteLine(DoctorService.GetDiplomaNumberByFullName("Alice Andrews")); // 9817640
//			Console.WriteLine(MedicineService.GetIdByMedicineName("4 Kidney")); // 7
			/*
			SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-QAE100K;Initial Catalog=MedTrackingDB;Integrated Security=True");
			SqlCommand cmd = new SqlCommand();
			SqlDataReader reader;

			cmd.CommandText = "SELECT * FROM Medicine";
			cmd.CommandType = CommandType.Text;
			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();
	  
			// Veri alma
			reader = cmd.ExecuteReader();
			// Data is accessible through the DataReader object here.
			while (reader.Read()) {
			    var record = (IDataRecord) reader;
			    Console.WriteLine(@"#{0} Name: '{1}' Price: '{2}'", record[0], record[2], record[3]);
			}
	  
			sqlConnection1.Close();
	  
			// Stored Proc. çalıştırma
			cmd.CommandText = "LoginEmployee";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "John";
			cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = "Doe";
	  
			sqlConnection1.Open();
	  
			reader = cmd.ExecuteReader();
			// Data is accessible through the DataReader object here.
			while (reader.Read())
			{
			    var record = (IDataRecord)reader;
			    Console.WriteLine(@"#{0} Name: '{1}' Surname: '{2}'", record[0], record[2], record[3]);
			}
	  
			sqlConnection1.Close();
	  
			// MedicineGroup ekleme ve trigger çalıştırma
			cmd.CommandText = "INSERT INTO MedicineGroups (Name) VALUES (@name)";
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = "YENİ GRUP2";
	  
			sqlConnection1.Open();
	  
			// Trigger should be fired
			cmd.ExecuteNonQuery();
	  
			// ----------------------------------------------------------------------*/

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			AuthService.DoLogin("Amy", "Fowler");
			Application.Run(new NewPrescription());
			//Application.Run(new MainForm());
			//Application.Run(new LoginForm());
		}
	}
}
