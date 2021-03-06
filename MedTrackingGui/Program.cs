﻿using System;
using System.Windows.Forms;

namespace MedTrackingGui {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			DBOperations.Initialize();
	  
			/*
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
			Application.Run(new LoginForm());
		}
	}
}
