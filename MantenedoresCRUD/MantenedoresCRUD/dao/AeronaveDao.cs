﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.dataBase;
using MantenedoresCRUD.modelo;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace MantenedoresCRUD.dao
{
    class AeronaveDao
    {

        private static Data conn;

        public AeronaveDao()
        {
            conn = Data.getInstance();
        }
        public DataSet ListarAeronaves(Aeronave aeronave)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_SELECT", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("tipo_aeronave_var", OracleDbType.Varchar2, aeronave.TipoAeronave.NombreTipo, ParameterDirection.Input);
                oraCmd.Parameters.Add("matricula_var", OracleDbType.Varchar2, aeronave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaAeronaves", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public DataSet ListarTipoAeronave()
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_TIPO_SELECT", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaTipoAeronave", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }
    }
}
