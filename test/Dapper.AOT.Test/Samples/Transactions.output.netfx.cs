// Output code has 5 diagnostics from 'Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs':
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs(281,8): error CS0019: Operator '??' cannot be applied to operands of type 'DbConnection' and 'bool'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs(283,5): error CS0019: Operator '??' cannot be applied to operands of type 'DbConnection' and 'void'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs(283,5): error CS0201: Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs(312,25): error CS0019: Operator '??' cannot be applied to operands of type 'DbConnection' and 'void'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Transactions.output.netfx.cs(312,25): error CS0201: Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement

#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by:
//     Dapper.CodeAnalysis.CommandGenerator vN/A
// Changes to this file may cause incorrect behavior and
// will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#region Designer generated code
partial class Test
{

	// available inactive command for Abstract (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Transactions_input_cs_Abstract_9;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial void Abstract(global::System.Data.Common.DbConnection connection)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Abstract_9, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// execute non-query
			__dapper__command.ExecuteNonQuery();

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Abstract_9, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for Abstract
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			return command;
		}
	}


	// available inactive command for Interface (interlocked)
	private static global::System.Data.IDbCommand? s___dapper__command_Samples_Transactions_input_cs_Interface_12;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial void Interface(global::System.Data.IDbConnection connection)
	{
		// locals
		global::System.Data.IDbCommand? __dapper__command = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Interface_12, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// execute non-query
			__dapper__command.ExecuteNonQuery();

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Interface_12, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for Interface
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.IDbCommand __dapper__CreateCommand(global::System.Data.IDbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			return command;
		}
	}


	// available inactive command for Concrete (interlocked)
	private static global::System.Data.SqlClient.SqlCommand? s___dapper__command_Samples_Transactions_input_cs_Concrete_15;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial void Concrete(global::System.Data.SqlClient.SqlConnection connection)
	{
		// locals
		global::System.Data.SqlClient.SqlCommand? __dapper__command = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Concrete_15, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// execute non-query
			__dapper__command.ExecuteNonQuery();

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Concrete_15, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for Concrete
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.SqlClient.SqlCommand __dapper__CreateCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			var command = connection.CreateCommand();
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			return command;
		}
	}


	// available inactive command for Transaction (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Transactions_input_cs_Transaction_18;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial void Transaction(global::System.Data.Common.DbTransaction transaction)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (transaction?.Connection!.State == global::System.Data.ConnectionState.Closed)
			{
				transaction?.Connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Transaction_18, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(transaction?.Connection!);
			}
			else
			{
				__dapper__command.Connection = transaction?.Connection;
			}

			// execute non-query
			__dapper__command.ExecuteNonQuery();

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_Transaction_18, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) transaction?.Connection?.Close();
		}

		// command factory for Transaction
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			return command;
		}
	}


	// available inactive command for OptionalTransaction (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Transactions_input_cs_OptionalTransaction_21;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial void OptionalTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbTransaction? transaction)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection ?? transaction?.Connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection ?? transaction?.Connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_OptionalTransaction_21, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection ?? transaction?.Connection!);
			}
			else
			{
				__dapper__command.Connection = connection ?? transaction?.Connection;
			}

			// execute non-query
			__dapper__command.ExecuteNonQuery();

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Transactions_input_cs_OptionalTransaction_21, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection ?? transaction?.Connection?.Close();
		}

		// command factory for OptionalTransaction
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			return command;
		}
	}
}
#endregion
