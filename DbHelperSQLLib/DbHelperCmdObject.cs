using System.Data;
using System.Data.SqlClient;

namespace DbHelperSQLLib
{
    public class DbHelperCmdObject
    {
        private CommandType _CmdCommandType = CommandType.Text;
        public CommandType CmdCommandType
        {
            get { return this._CmdCommandType; }
            set { this._CmdCommandType = value; }
        }
        public string StrSQL
        {
            get;
            set;
        }

        public SqlParameter[] Parameters
        {
            get;
            set;
        }
    }
}
