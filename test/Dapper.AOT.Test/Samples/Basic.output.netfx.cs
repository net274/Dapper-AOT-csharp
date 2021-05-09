// Output code has 2 diagnostics from 'Samples\Basic.input.cs':
// Samples\Basic.input.cs(14,24): error CS8795: Partial method 'Foo.ShouldIgnoreThis_NoAttribute(string)' must have an implementation part because it has accessibility modifiers.
// Samples\Basic.input.cs(48,32): error CS8795: Partial method 'A<TRandom>.B.ShouldAlsoDetectThisInB(string)' must have an implementation part because it has accessibility modifiers.
// Output code has 8 diagnostics from 'Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs':
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(60,20): error CS0234: The type or namespace name 'Span<>' does not exist in the namespace 'System' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(60,123): error CS0518: Predefined type 'System.Span`1' is not defined or imported
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(60,169): error CS0012: The type 'Span<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(61,5): error CS0012: The type 'Span<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(64,23): error CS1061: 'int?' does not contain a definition for 'Add' and no accessible extension method 'Add' accepting a first argument of type 'int?' could be found (are you missing a using directive or an assembly reference?)
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(64,27): error CS0012: The type 'ReadOnlySpan<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(164,26): error CS0012: The type 'ReadOnlySpan<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.
// Dapper.AOT.Analyzers\Dapper.CodeAnalysis.CommandGenerator\Basic.output.netfx.cs(255,26): error CS0012: The type 'ReadOnlySpan<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.

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
partial class Foo
{

	// available inactive command for ShouldDetectThis (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Basic_input_cs_ShouldDetectThis_11;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial int? ShouldDetectThis(global::System.Data.Common.DbConnection connection, string region)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		int? __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ShouldDetectThis_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(region);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			__dapper__result = new int?();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<int>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ShouldDetectThis_11, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ShouldDetectThis
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.Text;
			command.CommandText = @"/* Foo.ShouldDetectThis, Samples\Basic.input.cs #11 */ select * from Customers where Region = @region";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"region";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}
}
namespace X.Y.Z
{
	partial class A<TRandom>
	{
		partial class B
		{

			// available inactive command for ViaDapper (interlocked)
			private static global::System.Data.SqlClient.SqlCommand? s___dapper__command_Samples_Basic_input_cs_ViaDapper_32;

			[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
			public virtual partial global::X.Y.Z.Customer ViaDapper(string region, global::System.Data.SqlClient.SqlConnection c)
			{
				// locals
				global::System.Data.SqlClient.SqlCommand? __dapper__command = null;
				global::System.Data.SqlClient.SqlDataReader? __dapper__reader = null;
				bool __dapper__close = false;
				int[]? __dapper__tokenBuffer = null;
				try
				{
					// prepare connection
					if (c!.State == global::System.Data.ConnectionState.Closed)
					{
						c!.Open();
						__dapper__close = true;
					}

					// prepare command (excluding parameter values)
					if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ViaDapper_32, null)) is null)
					{
						__dapper__command = __dapper__CreateCommand(c!);
					}
					else
					{
						__dapper__command.Connection = c;
					}

					// assign parameter values
#pragma warning disable CS0618
					__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(region);
#pragma warning restore CS0618

					// execute reader
					const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
					__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
					__dapper__close = false; // performed via CommandBehavior

					// process single row
					global::X.Y.Z.Customer __dapper__result;
					if (__dapper__reader.HasRows && __dapper__reader.Read())
					{
						__dapper__result = global::Dapper.TypeReader.TryGetReader<global::X.Y.Z.Customer>()!.Read(__dapper__reader, ref __dapper__tokenBuffer);
					}
					else
					{
						__dapper__result = default!;
					}
					// consume additional results (ensures errors from the server are observed)
					while (__dapper__reader.NextResult()) { }
					return __dapper__result;

					// TODO: post-process parameters

				}
				finally
				{
					// cleanup
					global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
					__dapper__reader?.Dispose();
					if (__dapper__command is not null)
					{
						__dapper__command.Connection = default;
						__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ViaDapper_32, __dapper__command);
						__dapper__command?.Dispose();
					}
					if (__dapper__close) c?.Close();
				}

				// command factory for ViaDapper
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				static global::System.Data.SqlClient.SqlCommand __dapper__CreateCommand(global::System.Data.SqlClient.SqlConnection connection)
				{
					var command = connection.CreateCommand();
					command.CommandType = global::System.Data.CommandType.Text;
					command.CommandText = @"/* B.ViaDapper, Samples\Basic.input.cs #32 */ select * from Customers where Region = @region";
					var args = command.Parameters;

					var p = command.CreateParameter();
					p.ParameterName = @"region";
					p.Direction = global::System.Data.ParameterDirection.Input;
					p.Size = -1;
					args.Add(p);

					return command;
				}
			}


			// available inactive command for ViaOracle (interlocked)
			private static global::Oracle.ManagedDataAccess.Client.OracleCommand? s___dapper__command_Samples_Basic_input_cs_ViaOracle_35;

			[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
			public new static partial global::X.Y.Z.Customer ViaOracle(string region, global::Oracle.ManagedDataAccess.Client.OracleConnection c)
			{
				// locals
				global::Oracle.ManagedDataAccess.Client.OracleCommand? __dapper__command = null;
				global::Oracle.ManagedDataAccess.Client.OracleDataReader? __dapper__reader = null;
				bool __dapper__close = false;
				int[]? __dapper__tokenBuffer = null;
				try
				{
					// prepare connection
					if (c!.State == global::System.Data.ConnectionState.Closed)
					{
						c!.Open();
						__dapper__close = true;
					}

					// prepare command (excluding parameter values)
					if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ViaOracle_35, null)) is null)
					{
						__dapper__command = __dapper__CreateCommand(c!);
					}
					else
					{
						__dapper__command.Connection = c;
					}

					// assign parameter values
#pragma warning disable CS0618
					__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(region);
#pragma warning restore CS0618

					// execute reader
					const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
					__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
					__dapper__close = false; // performed via CommandBehavior

					// process single row
					global::X.Y.Z.Customer __dapper__result;
					if (__dapper__reader.HasRows && __dapper__reader.Read())
					{
						__dapper__result = global::Dapper.TypeReader.TryGetReader<global::X.Y.Z.Customer>()!.Read(__dapper__reader, ref __dapper__tokenBuffer);
					}
					else
					{
						__dapper__result = default!;
					}
					// consume additional results (ensures errors from the server are observed)
					while (__dapper__reader.NextResult()) { }
					return __dapper__result;

					// TODO: post-process parameters

				}
				finally
				{
					// cleanup
					global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
					__dapper__reader?.Dispose();
					if (__dapper__command is not null)
					{
						__dapper__command.Connection = default;
						__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Basic_input_cs_ViaOracle_35, __dapper__command);
						__dapper__command?.Dispose();
					}
					if (__dapper__close) c?.Close();
				}

				// command factory for ViaOracle
				[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
				static global::Oracle.ManagedDataAccess.Client.OracleCommand __dapper__CreateCommand(global::Oracle.ManagedDataAccess.Client.OracleConnection connection)
				{
					var command = connection.CreateCommand();
					command.BindByName = true;
					command.InitialLONGFetchSize = -1;
					command.CommandType = global::System.Data.CommandType.Text;
					command.CommandText = @"/* B.ViaOracle, Samples\Basic.input.cs #35 */ select * from Customers where Region = @region";
					var args = command.Parameters;

					var p = command.CreateParameter();
					p.ParameterName = @"region";
					p.Direction = global::System.Data.ParameterDirection.Input;
					p.Size = -1;
					args.Add(p);

					return command;
				}
			}

		}
	}
}
#endregion
