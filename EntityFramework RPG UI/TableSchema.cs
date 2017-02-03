namespace EntityFramework_RPG_UI
{
    public class TableSchema
    {
        private readonly string _table;
        private readonly string _schema;
        public TableSchema(string table, string schema)
        {
            _table = table;
            _schema = schema;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", _table, _schema);
        }

        public string TableName
        {
            get { return _table; }
        }
    }
}
