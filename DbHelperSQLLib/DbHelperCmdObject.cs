using System.Data;
using System.Data.SqlClient;

namespace DbHelperSQLLib
{
    public class DbHelperCmdObject
    {
        public CommandType CmdCommandType { get; set; }
        public string StrSQL { get; set; }
        public SqlParameter[] Parameters { get; set; }

        public DbHelperCmdObject()
        {

        }

        public DbHelperCmdObject(string strSql, SqlParameter[] parameters, CommandType cmdCommandType = CommandType.Text)
        {
            this.CmdCommandType = cmdCommandType;
            this.StrSQL = strSql;
            this.Parameters = parameters;
        }
    }
}
