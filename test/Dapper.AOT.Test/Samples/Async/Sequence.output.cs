
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

	// available inactive command for SequenceAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.IAsyncEnumerable<global::SomeType> SequenceAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// use wrapper method to add support for enumerator cancellation
		return __dapper__SequenceAsync(connection, id, name, global::System.Threading.CancellationToken.None);

		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static async global::System.Collections.Generic.IAsyncEnumerable<global::SomeType> __dapper__SequenceAsync(global::System.Data.Common.DbConnection connection, int id, string name, [global::System.Runtime.CompilerServices.EnumeratorCancellationAttribute] global::System.Threading.CancellationToken __dapper__cancellation)
		{
			// locals
			global::System.Data.Common.DbCommand? __dapper__command = null;
			global::System.Data.Common.DbDataReader? __dapper__reader = null;
			bool __dapper__close = false;
			int[]? __dapper__tokenBuffer = null;
			try
			{
				// prepare connection
				if (connection!.State == global::System.Data.ConnectionState.Closed)
				{
					await connection!.OpenAsync(__dapper__cancellation).ConfigureAwait(false);
					__dapper__close = true;
				}

				// prepare command (excluding parameter values)
				if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8, null)) is null)
				{
					__dapper__command = __dapper__CreateCommand(connection!);
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

				// execute reader
				const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
				__dapper__reader = await __dapper__command.ExecuteReaderAsync(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior, __dapper__cancellation).ConfigureAwait(false);
				__dapper__close = false; // performed via CommandBehavior

				// process multiple rows
				if (__dapper__reader.HasRows)
				{
					var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
					var __dapper__tokens = global::Dapper.TypeReader.RentSegment(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
					__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
					while (await __dapper__reader.ReadAsync(__dapper__cancellation).ConfigureAwait(false))
					{
						yield return await __dapper__parser.ReadAsync(__dapper__reader, __dapper__tokens, __dapper__cancellation).ConfigureAwait(false);
					}
				}
				// consume additional results (ensures errors from the server are observed)
				while (await __dapper__reader.NextResultAsync(__dapper__cancellation).ConfigureAwait(false)) { }

				// TODO: post-process parameters

			}
			finally
			{
				// cleanup
				global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
				if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
				if (__dapper__command is not null)
				{
					__dapper__command.Connection = default;
					__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceAsync_8, __dapper__command);
					if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
				}
				if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
			}
		}

		// command factory for SequenceAsync
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


	// available inactive command for SequenceWithCancellationAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Collections.Generic.IAsyncEnumerable<global::SomeType> SequenceWithCancellationAsync(global::System.Data.Common.DbConnection connection, int id, string name, [global::System.Runtime.CompilerServices.EnumeratorCancellationAttribute] global::System.Threading.CancellationToken cancellation)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				await connection!.OpenAsync(cancellation).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
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

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = await __dapper__command.ExecuteReaderAsync(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior, cancellation).ConfigureAwait(false);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				var __dapper__tokens = global::Dapper.TypeReader.RentSegment(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (await __dapper__reader.ReadAsync(cancellation).ConfigureAwait(false))
				{
					yield return await __dapper__parser.ReadAsync(__dapper__reader, __dapper__tokens, cancellation).ConfigureAwait(false);
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (await __dapper__reader.NextResultAsync(cancellation).ConfigureAwait(false)) { }

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			if (__dapper__reader is not null) await __dapper__reader.DisposeAsync().ConfigureAwait(false);
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Sequence_input_cs_SequenceWithCancellationAsync_11, __dapper__command);
				if (__dapper__command is not null) await __dapper__command.DisposeAsync().ConfigureAwait(false);
			}
			if (__dapper__close) await (connection?.CloseAsync() ?? global::System.Threading.Tasks.Task.CompletedTask).ConfigureAwait(false);
		}

		// command factory for SequenceWithCancellationAsync
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
