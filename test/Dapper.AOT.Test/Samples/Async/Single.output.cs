
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

	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Single_input_cs_TaskAsync_8;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Threading.Tasks.Task<global::SomeType> TaskAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				await connection.OpenAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_TaskAsync_8, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute
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
			// cleanup
			if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_TaskAsync_8, __dapper__command);
				if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
			}
			if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
		}

		// command factory for TaskAsync
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


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Single_input_cs_ValueTaskAsync_11;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Threading.Tasks.ValueTask<global::SomeType> ValueTaskAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				await connection.OpenAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_ValueTaskAsync_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute
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
			// cleanup
			if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_ValueTaskAsync_11, __dapper__command);
				if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
			}
			if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
		}

		// command factory for ValueTaskAsync
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


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Single_input_cs_TaskWithCancellationAsync_14;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Threading.Tasks.Task<global::SomeType> TaskWithCancellationAsync(global::System.Data.Common.DbConnection connection, int id, string name, global::System.Threading.CancellationToken cancellation)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				await connection.OpenAsync(cancellation).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_TaskWithCancellationAsync_14, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute
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
			// cleanup
			if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_TaskWithCancellationAsync_14, __dapper__command);
				if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
			}
			if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
		}

		// command factory for TaskWithCancellationAsync
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


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Single_input_cs_ValueWithCancellationTaskAsync_17;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Threading.Tasks.ValueTask<global::SomeType> ValueWithCancellationTaskAsync(global::System.Data.Common.DbConnection connection, int id, string name, global::System.Threading.CancellationToken cancellation)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection.State == global::System.Data.ConnectionState.Closed)
			{
				await connection.OpenAsync(cancellation).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_ValueWithCancellationTaskAsync_17, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute
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
			// cleanup
			if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Single_input_cs_ValueWithCancellationTaskAsync_17, __dapper__command);
				if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
			}
			if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
		}

		// command factory for ValueWithCancellationTaskAsync
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
}
#endregion
