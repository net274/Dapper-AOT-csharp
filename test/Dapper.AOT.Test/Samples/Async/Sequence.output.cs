// Output code has 2 diagnostics from 'Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Sequence.output.cs':
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Sequence.output.cs(57,11): error CS0266: Cannot implicitly convert type 'SomeType' to 'System.Collections.Generic.IAsyncEnumerable<SomeType>'. An explicit conversion exists (are you missing a cast?)
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Sequence.output.cs(145,11): error CS0266: Cannot implicitly convert type 'SomeType' to 'System.Collections.Generic.IAsyncEnumerable<SomeType>'. An explicit conversion exists (are you missing a cast?)

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

	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8;

	public partial global::System.Collections.Generic.IAsyncEnumerable<global::SomeType> SequenceAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				connection.Open();
				__dapper__close = true;
			}
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
#pragma warning restore CS0618
#pragma warning disable CS0618
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			global::SomeType __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			while (__dapper__reader.NextResult()) { } // consumes TDS to check for exceptions
			return __dapper__result;
		}
		finally
		{
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

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

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11;

	public partial global::System.Collections.Generic.IAsyncEnumerable<global::SomeType> SequenceWithCancellationAsync(global::System.Data.Common.DbConnection connection, int id, string name, global::System.Threading.CancellationToken cancellation)
	{
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				connection.Open();
				__dapper__close = true;
			}
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
#pragma warning restore CS0618
#pragma warning disable CS0618
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618
#pragma warning disable CS0618
			__dapper__command.Parameters[2].Value = global::Dapper.Internal.InternalUtilities.AsValue(cancellation);
#pragma warning restore CS0618

			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			global::SomeType __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			while (__dapper__reader.NextResult()) { } // consumes TDS to check for exceptions
			return __dapper__result;
		}
		finally
		{
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

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

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"cancellation";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			return command;
		}
	}
}
#endregion
